using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные.УчетСпецодеждыИСИЗ;
using System.Linq;
using TechControl.Метаданные.Мониторинг;

namespace TechControl.Метаданные.Учет
{
    
    public partial class Номенклатура
    {
        public decimal ПолучитьСтоимость(DateTime дата) 
        {
            ОстаткиНоменклатуры остаткиНоменклатуры = ОстаткиНоменклатуры.Новый();
            остаткиНоменклатуры.Номенклатура = this;
            остаткиНоменклатуры.GetRest(дата);
            decimal цена = 0;
            if (остаткиНоменклатуры.Количество != 0)
            {
                цена = остаткиНоменклатуры.Стоимость / остаткиНоменклатуры.Количество;
            }

            return цена;
        }

        protected override List<Guid> BasePost()
        {
            if (ТипНоменклатуры == ТипНоменклатуры.Спецодежда)
            {
                if (!ВидНоменклатуры.Selected)
                {
                    throw new Exception("Не выбран вид спецодежды!!!");
                }

                if (!ВидРазмернойСетки.Selected)
                {
                    throw new Exception("Не выбран вид размерной сетки!!!");
                }

            }
            else
            {
                ВидНоменклатуры = ВидСвойствНоменклатуры.Новый();
                ВидРазмернойСетки = ВидыРазмернойСетки.Новый();
            }
            return base.BasePost();
        }

        public static string ИмяКолонкиНоменклатуры = "Номенклатура";

        public NsgMemoryTable ПолучитьТаблицуПериодовЭксплуатации(Dictionary<Номенклатура, decimal> списокНоменклатурыИСтоимости) 
        {
            NsgMemoryTable список = new NsgMemoryTable(Метаданные.Новый());
            список.AddColumn(ИмяКолонкиНоменклатуры, typeof(Номенклатура));

            var списокПлановАмортизации = списокНоменклатурыИСтоимости.Keys
                .Select(x => x.ПланАмортизации)
                .Where(x => x.КоличествоПериодов != 0)
                .ToArray();

            foreach (var item in списокНоменклатурыИСтоимости)
            {
                var row = список.NewRow();
                row[ИмяКолонкиНоменклатуры].Value = item.Key;
                row.Post();
            }
            
            if (списокПлановАмортизации.Length > 0)
            {
                var списокПлановАмортизацииОтсортированный = списокПлановАмортизации
                .OrderBy(x => x.СрокАмортизацииМес / x.КоличествоПериодов)
                .ToArray();

                var планАмортизацииСМинимельнымПериодом = списокПлановАмортизацииОтсортированный.First();
                var минимальныйПериод = планАмортизацииСМинимельнымПериодом.СрокАмортизацииМес / планАмортизацииСМинимельнымПериодом.КоличествоПериодов;

                var максСрокАмортизации = списокПлановАмортизации.OrderByDescending(x => x.СрокАмортизацииМес).First().СрокАмортизацииМес;
                var текущийПериод = минимальныйПериод;

                while (текущийПериод <= максСрокАмортизации)
                {
                    var имяКолонки = $"{текущийПериод} - {текущийПериод + минимальныйПериод}";
                    список.AddColumn(имяКолонки, typeof(decimal));
                    foreach (var row in список.AllRows)
                    {
                        var номенклатура = row[ИмяКолонкиНоменклатуры].ToReferent() as Номенклатура;
                        if (номенклатура.ПланАмортизации.КоличествоПериодов != 0)
                        {
                            var периодБазовый = номенклатура.ПланАмортизации.СрокАмортизацииМес / номенклатура.ПланАмортизации.КоличествоПериодов;
                            var суммаБазовая = списокНоменклатурыИСтоимости[номенклатура];

                            if (текущийПериод <= периодБазовый)
                            {
                                row[имяКолонки].Value = суммаБазовая;
                            }
                            else if (текущийПериод > номенклатура.ПланАмортизации.СрокАмортизацииМес)
                            {
                                row[имяКолонки].Value = 0;
                            }
                            else
                            {
                                var sum = суммаБазовая;
                                
                                var период = периодБазовый;
                                while (текущийПериод > период)
                                {
                                    sum = sum - суммаБазовая / номенклатура.ПланАмортизации.КоличествоПериодов;
                                    период = период + периодБазовый;
                                }

                                row[имяКолонки].Value = sum;
                            }
                        }
                    }

                    текущийПериод = текущийПериод + минимальныйПериод;
                }
                
            }

            return список;

        }

        public decimal СтоимостьСУчетомАмортизацииНаДату(DateTime датаОпределенияСтоимости, DateTime датаНачалаЭксплуатации)
        {
            decimal сумма = 0;
            if (ПланАмортизации.Selected && ПланАмортизации.КоличествоПериодов != 0)
            {
                датаОпределенияСтоимости = датаОпределенияСтоимости.Date;
                датаНачалаЭксплуатации = датаНачалаЭксплуатации.Date;

                var периодБазовый = ПланАмортизации.СрокАмортизацииМес / ПланАмортизации.КоличествоПериодов;
                var суммаБазовая = ПолучитьСтоимость(датаНачалаЭксплуатации);
                var датаОкончанияПервогоПериода = датаНачалаЭксплуатации.AddMonths((int)периодБазовый);

                if (датаОпределенияСтоимости <= датаОкончанияПервогоПериода)
                {
                    сумма = суммаБазовая;
                }
                else if (датаОпределенияСтоимости > датаНачалаЭксплуатации.AddMonths((int)ПланАмортизации.СрокАмортизацииМес))
                {
                    сумма = 0;
                }
                else
                {
                    var sum = суммаБазовая;
                    var период = периодБазовый;
                    var датаОкончанияПериода = датаОкончанияПервогоПериода;

                    while (датаОпределенияСтоимости > датаОкончанияПериода)
                    {
                        sum = sum - суммаБазовая / ПланАмортизации.КоличествоПериодов;
                        период = период + периодБазовый;
                        датаОкончанияПериода = датаОкончанияПериода.AddMonths((int)период);
                    }

                    сумма = sum;
                }
            }

            return сумма;
        }


        //public Номенклатура СвязаннаяНоменклатураБУ()
        //{
        //    if (ЯвляетсяБУ)
        //        return this;

        //    if (НоменклатураБУ.Selected)
        //        return НоменклатураБУ;

        //    var cmp = new NsgCompare(NsgLogicalOperator.Or);
        //    var cmpName = new NsgCompare();
        //    cmpName.Add(Номенклатура.Names.Идентификатор, Идентификатор, NsgComparison.NotEqual);
        //    cmpName.Add(Номенклатура.Names.ЯвляетсяБУ, true);
        //    cmpName.Add(Номенклатура.Names.Наименование, string.Empty, NsgComparison.NotEqual);
        //    cmpName.Add(Номенклатура.Names.Наименование, Наименование, NsgComparison.ContainWords);
        //    cmp.Add(cmpName);

        //    var cmpFullName = new NsgCompare();
        //    cmpFullName.Add(Номенклатура.Names.Идентификатор, Идентификатор, NsgComparison.NotEqual);
        //    cmpFullName.Add(Номенклатура.Names.ЯвляетсяБУ, true);
        //    cmpFullName.Add(Номенклатура.Names.ПолноеНаименование, string.Empty, NsgComparison.NotEqual);
        //    cmpFullName.Add(Номенклатура.Names.ПолноеНаименование, ПолноеНаименование, NsgComparison.ContainWords);
        //    cmp.Add(cmpFullName);

        //    //var cmpFullName2 = new NsgCompare();
        //    //cmpFullName2.Add(Номенклатура.Names.Идентификатор, Идентификатор, NsgComparison.NotEqual);
        //    //cmpFullName2.Add(Номенклатура.Names.ПолноеНаименование2, string.Empty, NsgComparison.NotEqual);
        //    //cmpFullName2.Add(Номенклатура.Names.ПолноеНаименование2, ПолноеНаименование2, NsgComparison.ContainWords);
        //    //cmp.Add(cmpFullName2);

        //    //var cmpFullName3 = new NsgCompare();
        //    //cmpFullName3.Add(Номенклатура.Names.Идентификатор, Идентификатор, NsgComparison.NotEqual);
        //    //cmpFullName3.Add(Номенклатура.Names.ПолноеНаименование3, string.Empty, NsgComparison.NotEqual);
        //    //cmpFullName3.Add(Номенклатура.Names.ПолноеНаименование3, ПолноеНаименование3, NsgComparison.ContainWords);
        //    //cmp.Add(cmpFullName3);

        //    var nom = Номенклатура.Новый();
        //    if (!nom.Find(cmp))
        //    {
        //        nom.New();
        //        nom.CopyNotPredefinedFieldsFromObject(this);
        //        nom.ЯвляетсяБУ = true;
        //        nom.Наименование = Наименование + " (Б/У)";
        //        nom.ПолноеНаименование = ПолноеНаименование + " (Б/У)";
        //        nom.ПолноеНаименование2 = ПолноеНаименование2 + " (Б/У)";
        //        nom.ПолноеНаименование3 = ПолноеНаименование3 + " (Б/У)";
        //        nom.Post();
        //    }

        //    return nom;
        //}
    }

}
