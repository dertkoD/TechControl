using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные.УчетСпецодеждыИСИЗ;
using TechControl.Метаданные._SystemTables;
using System.Linq;
using TechControl.Метаданные.Сервис;
using TechControl.Метаданные.ПечатныеФормыДокументов;
using TechControl.Метаданные.УчетИнструмента;

namespace TechControl.Метаданные.Учет
{
    
    public partial class ПриходнаяНакладная
    {
        protected override bool Handling()
        {
            bool снятиеРезервов = true;
            if (ДокументОснование != null && ДокументОснование.Selected)
            {
                if (ДокументОснование is ЗаявкаНаСотрудника заявкаНаСотрудника)
                {
                    снятиеРезервов = ПроведениеПоРезервамЗнС(заявкаНаСотрудника);
                }
                else if (ДокументОснование is ЗаявкиПоставщикам заявкаПоставщику)
                {
                    снятиеРезервов = ПроведениеПоРезервамЗП(заявкаПоставщику);
                }
            }
            return ПроведениеПоОстаткамНоменклатурыИРегиструУчетаИнструмента() && снятиеРезервов;
        }

        private bool ПроведениеПоОстаткамНоменклатурыИРегиструУчетаИнструмента() 
        {
            РегистрУчетИнструмента рег = РегистрУчетИнструмента.Новый(this);
            рег.New();

            ОстаткиНоменклатуры остаткиНоменклатуры = ОстаткиНоменклатуры.Новый(this);
            остаткиНоменклатуры.New();

            foreach (var i in this.Таблица.Rows)
            {
                остаткиНоменклатуры.ВидДвижения = Сервис.ВидыДвижений.Приход;
                остаткиНоменклатуры.Количество = i.Количество;
                остаткиНоменклатуры.Номенклатура = i.Номенклатура;
                остаткиНоменклатуры.Объект = this.Объект;
                остаткиНоменклатуры.Размер = i.Размер;
                остаткиНоменклатуры.Стоимость = i.Стоимость;
                остаткиНоменклатуры.AddMovement();

                if (i.Номенклатура.ТипНоменклатуры == ТипНоменклатуры.Инструменты || i.Номенклатура.ТипНоменклатуры == ТипНоменклатуры.МатериальныеЦенности)
                {
                    for (int j = 0; j < i.Количество; j++)
                    {
                        рег.Сотрудник = Сотрудник;
                        рег.НоменклатураИнструмента = i.Номенклатура;
                        рег.Объект = this.Объект;
                        рег.СерийныйНомер = Guid.NewGuid().ToString();
                        рег.Дата = ДатаДокумента;

                        рег.AddMovement();
                    }
                }
            }

            return остаткиНоменклатуры.Post() && рег.Post();
        }

        private bool ПроведениеПоРезервамЗнС(ЗаявкаНаСотрудника заявкаНаСотрудника)
        {
            var cmp = new NsgCompare();
            cmp.Add(УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Names.ДокументЗаявкиНаСотрудника, заявкаНаСотрудника);
            var резервы = УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Новый().FindAll(cmp);

            РегистрРезерваЗнС регистрРезервыЗнС = РегистрРезерваЗнС.Новый(this);
            
            foreach (var i in резервы)
            {
                регистрРезервыЗнС.New();
                регистрРезервыЗнС.CopyNotPredefinedFieldsFromObject(i);
                регистрРезервыЗнС.ВидДвижения = Сервис.ВидыДвижений.Расход;
                регистрРезервыЗнС.AddMovement();
            }

            return регистрРезервыЗнС.Post();
        }

        private bool ПроведениеПоРезервамЗП(ЗаявкиПоставщикам заявкаПоставщику)
        {
            var cmp = new NsgCompare();
            cmp.Add(УчетСпецодеждыИСИЗРегистрРезерваЗПДвижения.Names.ДокументЗаявкиПоставщикам, заявкаПоставщику);
            var резервы = УчетСпецодеждыИСИЗРегистрРезерваЗПДвижения.Новый().FindAll(cmp);

            РегистрРезерваЗП регистрРезерваЗП = РегистрРезерваЗП.Новый(this);

            foreach (var i in резервы)
            {
                регистрРезерваЗП.New();
                регистрРезерваЗП.CopyNotPredefinedFieldsFromObject(i);
                регистрРезерваЗП.ВидДвижения = Сервис.ВидыДвижений.Расход;
                регистрРезерваЗП.AddMovement();
            }

            return регистрРезерваЗП.Post();
        }

        public void ВводНаОсновании(NsgDataDocument document) 
        {
            if (document is ЗаявкаНаСотрудника заявкаНаСотрудника)
            {
                ДокументОснование = заявкаНаСотрудника;
                Контрагент = заявкаНаСотрудника.Контрагент;
                Объект = заявкаНаСотрудника.Объект;
                Сотрудник = заявкаНаСотрудника.Сотрудник;
                foreach (var item in заявкаНаСотрудника.Таблица.AllRows)
                {
                    var row = Таблица.NewRow();
                    row.Номенклатура = item.Номенклатура;
                    row.Размер = item.Размер;
                    row.Количество = item.Количество;
                    row.Цена = item.Цена;
                    row.Стоимость = item.Сумма;
                    row.Post();
                }
            }
            else if (document is ЗаявкиПоставщикам заявкаПоставщику)
            {
                ДокументОснование = заявкаПоставщику;
                Контрагент = заявкаПоставщику.Поставщик;
                Объект = заявкаПоставщику.Объект;
                Сотрудник = заявкаПоставщику.Сотрудник;
                foreach (var item in заявкаПоставщику.Таблица.AllRows)
                {
                    var row = Таблица.NewRow();
                    row.Номенклатура = item.Номенклатура;
                    row.Размер = item.Размер;
                    row.Количество = item.Количество;
                    row.Цена = item.Цена;
                    row.Стоимость = item.Стоимость;
                    row.Post();
                }
            }
        }
    }

}
