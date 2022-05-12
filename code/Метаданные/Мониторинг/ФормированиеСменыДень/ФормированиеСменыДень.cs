using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные._SystemTables;

namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ФормированиеСменыДень
    {
        protected override List<Guid> BasePost()
        {
            foreach (var i in this.ТаблицаТехника.Rows)
            {
                i.Время = this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date));
                if (i.НомерСмены < 0 || i.НомерСмены > 3) i.НомерСмены = 0;
                if (!i.Тариф.Selected)
                {
                    var tariff = this.Объект.ТаблицаТарифы.FindRow(new NsgCompare()
                        .Add(МониторингОбъектыТаблицаТарифы.Names.ИспользоватьПоУмолчанию, true)
                        .Add(МониторингОбъектыТаблицаТарифы.Names.ГруппаСпецТехники, i.Техника.ГруппаСпецТехники));
                    if (tariff == null)
                    {
                        tariff = this.Объект.ТаблицаТарифы.FindRow(new NsgCompare()
                            .Add(МониторингОбъектыТаблицаТарифы.Names.ИспользоватьПоУмолчанию, true)
                            .Add(МониторингОбъектыТаблицаТарифы.Names.ГруппаСпецТехники, ГруппыСпецТехники.Новый()));
                    }
                    if (tariff != null)
                    {
                        i.Тариф = tariff.Тариф;
                    }
                }
                i.Post();
            }
            foreach (var i in this.ТаблицаПерсонал.Rows)
            {
                i.Время = this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date));
                if (i.НомерСмены < 0 || i.НомерСмены > 3) i.НомерСмены = 0;
                if (!i.Тариф.Selected)
                {
                    var tariff = this.Объект.ТаблицаТарифыСотрудников.FindRow(new NsgCompare()
                        .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.ИспользоватьПоУмолчанию, true)
                        .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.Должность, i.Сотрудник.Должность));
                    if (tariff == null)
                    {
                        tariff = this.Объект.ТаблицаТарифыСотрудников.FindRow(new NsgCompare()
                            .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.ИспользоватьПоУмолчанию, true)
                            .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.Должность, Должности.Новый()));
                    }
                    if (tariff != null)
                    {
                        i.Тариф = tariff.Тариф;
                    }
                }
                i.Post();
            }
            return base.BasePost();
        }

        protected override bool Handling()
        {
            List<Техника> t = new List<Техника>();
            bool error = false;
            StringBuilder ts = new StringBuilder();
            foreach (var i in this.ТаблицаТехника.Rows)
            {
                if (!i.Техника.Selected)
                {
                    NsgSettings.MainForm.ShowMessage($"Таблица техники: В некоторых строках не выбрана техника",
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                if (!i.Тариф.Selected)
                {
                    NsgSettings.MainForm.ShowMessage($"Техника: {i.Техника} - не выбран тариф",
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                var tariff = this.Объект.ТаблицаТарифы.FindRow(new NsgCompare()
                    .Add(МониторингОбъектыТаблицаТарифы.Names.Тариф, i.Тариф)
                    .Add(МониторингОбъектыТаблицаТарифы.Names.ГруппаСпецТехники, i.Техника.ГруппаСпецТехники));
                if (tariff == null)
                {
                    tariff = this.Объект.ТаблицаТарифы.FindRow(new NsgCompare()
                        .Add(МониторингОбъектыТаблицаТарифы.Names.Тариф, i.Тариф)
                        .Add(МониторингОбъектыТаблицаТарифы.Names.ГруппаСпецТехники, ГруппыСпецТехники.Новый()));
                }
                if (tariff == null)
                {
                    NsgSettings.MainForm.ShowMessage(
                        $"Техника: {i.Техника} - выбранный тариф на задан на объекте для группы техники {i.Техника.ГруппаСпецТехники}",
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                if (!i.Сотрудник.Selected)
                {
                    NsgSettings.MainForm.ShowMessage($"Техника: {i.Техника} - не выбран сотрудник",
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                if (t.Contains(i.Техника))
                {
                    error = true;
                    ts.Append('\n' + i.Техника.ToString());
                }
                t.Add(i.Техника);
            }
            if (error)
            {
                NsgSettings.MainForm.ShowMessage($"Техника не должна встречаться более одного раза:" + ts.ToString(),
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
            List<Сотрудники> s = new List<Сотрудники>();
            error = false;
            ts.Clear();
            foreach (var i in this.ТаблицаПерсонал.Rows)
            {
                if (!i.Тариф.Selected)
                {
                    NsgSettings.MainForm.ShowMessage($"Сотрудник: {i.Сотрудник} - не выбран тариф",
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                var tariff = this.Объект.ТаблицаТарифыСотрудников.FindRow(new NsgCompare()
                    .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.Тариф, i.Тариф)
                    .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.Должность, i.Сотрудник.Должность));
                if (tariff == null)
                {
                    tariff = this.Объект.ТаблицаТарифыСотрудников.FindRow(new NsgCompare()
                        .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.Тариф, i.Тариф)
                        .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.Должность, Должности.Новый()));
                }
                if (tariff == null)
                {
                    NsgSettings.MainForm.ShowMessage(
                        $"Сотрудник: {i.Сотрудник} - выбранный тариф на задан на объекте для должности {i.Сотрудник.Должность}",
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                if (!i.Сотрудник.Selected)
                {
                    NsgSettings.MainForm.ShowMessage($"Таблица персонала: В некоторых строках не выбран сотрудник",
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                if (s.Contains(i.Сотрудник))
                {
                    error = true;
                    ts.Append('\n' + i.Сотрудник.ToString());
                }
                s.Add(i.Сотрудник);
            }
            if (error)
            {
                NsgSettings.MainForm.ShowMessage($"Сотрудник не должен встречаться более одного раза:" + ts.ToString(),
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }

            //Get rest по ФиксацияИстории на дату документа - тик. Оттуда берем время работы. Если статус в работе не менялся в ФиксацияИстории пишем старое время.
            //в РегистрСмен пишем время в работе 
            var рег = ФиксацияИстории.Новый(this);
            рег.New();
            рег.Объект = this.Объект;
            рег.Владелец = this;
            var регС = ФиксацияИсторииСотрудников.Новый(this);
            регС.New();
            регС.Объект = this.Объект;
            регС.Владелец = this;

            var регСмены = РегистрСмен.Новый(this);
            регСмены.New();

            #region техника
            foreach (var i in this.ТаблицаТехника.Rows)
            {
                рег.Сотрудник = i.Сотрудник;
                рег.Техника = i.Техника;
                рег.НомерСмены = i.НомерСмены;
                рег.GetRest(i.Время.AddTicks(-1));
                var предСтатусТехники = рег.СтатусТехники.Clone as СтатусТехники;
                рег.Тариф = i.Тариф;
                рег.СтатусТехники = i.СтатусТехники;
                if (i.СтатусТехники != СтатусТехники.ВРаботе && предСтатусТехники == СтатусТехники.ВРаботе)
                {
                    if (i.Время == i.Время.Date)
                        i.Время = i.Время.AddSeconds(-1);
                    var предВремя = рег.Время;
                    рег.Дата = рег.Время = i.Время == NsgService.MinDate ?
                        this.ДатаДокумента :
                        this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date));
                    регСмены.ДатаДокумента = предВремя;
                    регСмены.Объект = this.Объект;
                    регСмены.Сотрудник = i.Сотрудник;
                    регСмены.Техника = i.Техника;
                    регСмены.НомерСмены = i.НомерСмены;
                    регСмены.ОтработанноеВремя = (предВремя == NsgService.MinDate) ? 0 : (decimal)(рег.Время - предВремя).TotalHours;
                    регСмены.Сумма = рег.Тариф.Стоимость * регСмены.ОтработанноеВремя;
                    регСмены.ВидДвижения = Сервис.ВидыДвижений.Приход;
                    регСмены.AddMovement();
                }
                else
                {
                    if (i.Время == i.Время.Date)
                        i.Время = i.Время.AddSeconds(1);
                    рег.Дата = рег.Время = i.Время == NsgService.MinDate ?
                        this.ДатаДокумента :
                        this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date));
                }
                рег.Владелец = this;
                рег.AddMovement();
            }
            #endregion
            if (регСмены.MovementTable.Count > 0 && !регСмены.Post()) return false;
            #region персонал
            регСмены.New();
            foreach (var i in this.ТаблицаПерсонал.Rows)
            {
                регС.Сотрудник = i.Сотрудник;
                регС.НомерСмены = i.НомерСмены;
                регС.GetRest(i.Время.AddTicks(-1));
                var предСтатусСотрудника = регС.СтатусСотрудника.Clone as СтатусСотрудника;
                регС.Тариф = i.Тариф;
                if (i.СтатусСотрудника != СтатусСотрудника.НаРаботе && предСтатусСотрудника == СтатусСотрудника.НаРаботе)
                {
                    if (i.Время == i.Время.Date)
                        i.Время = i.Время.AddSeconds(-1);
                    var предВремя = рег.Время;
                    регС.Дата = регС.Время = i.Время == NsgService.MinDate ?
                        this.ДатаДокумента :
                        this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date));
                    регСмены.ДатаДокумента = предВремя;
                    регСмены.Объект = this.Объект;
                    регСмены.Сотрудник = i.Сотрудник;
                    регСмены.НомерСмены = i.НомерСмены;
                    регСмены.ОтработанноеВремя = (предВремя == NsgService.MinDate) ? 0 : (decimal)(регС.Время - предВремя).TotalHours;
                    регСмены.Сумма = i.Тариф.Стоимость * регСмены.ОтработанноеВремя;
                    регСмены.ВидДвижения = Сервис.ВидыДвижений.Приход;
                    регСмены.AddMovement();
                }
                else
                {
                    if (i.Время == i.Время.Date)
                        i.Время = i.Время.AddSeconds(1);
                    регС.Дата = регС.Время = i.Время == NsgService.MinDate ?
                        this.ДатаДокумента :
                        this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date));
                }
                регС.Владелец = this;
                регС.AddMovement();
            }
            #endregion
            if (регСмены.MovementTable.Count > 0 && !регСмены.Post()) return false;
            рег.Владелец = регС.Владелец = this;

            return регС.Post() && рег.Post();
        }

        protected override void OnAfterHandle(HandleEventArgs e)
        {
            base.OnAfterHandle(e);
            ФиксацияИстории фиксацияИстории = ФиксацияИстории.Новый();
            foreach (var i in this.ТаблицаТехника.Rows)
            {
                var t = i.Техника;
                фиксацияИстории.New();
                фиксацияИстории.Техника = t;
                фиксацияИстории.GetRest(DateTime.Now);
                if (t.Статус != фиксацияИстории.СтатусТехники)
                {
                    t.Edit();
                    t.Статус = фиксацияИстории.СтатусТехники;
                    t.Post();
                }
            }
            ФиксацияИсторииСотрудников фиксацияИсторииСотрудников = ФиксацияИсторииСотрудников.Новый();
            foreach (var i in this.ТаблицаПерсонал.Rows)
            {
                var t = i.Сотрудник;
                фиксацияИсторииСотрудников.New();
                фиксацияИсторииСотрудников.Сотрудник = t;
                фиксацияИсторииСотрудников.GetRest(DateTime.Now);
                if (t.Статус != фиксацияИсторииСотрудников.СтатусСотрудника)
                {
                    t.Edit();
                    t.Статус = i.СтатусСотрудника;
                    t.Post();
                }
            }
            if (Объект.Selected)
            {
                Объект.Edit();
                string ТАБЛИЦАТЕХНИКАСТАТУС = МониторингОбъектыТаблицаТехника.Names.Техника + '.' + Техника.Names.Статус;
                Объект.МашинВРаботе = Объект.ТаблицаТехника.CountAll(new NsgCompare()
                    .Add(ТАБЛИЦАТЕХНИКАСТАТУС, СтатусТехники.ВРаботе));
                Объект.МашинНеВРаботе = Объект.ТаблицаТехника.CountAll(new NsgCompare()
                    .Add(ТАБЛИЦАТЕХНИКАСТАТУС, СтатусТехники.НеРаботает));
                Объект.МашинСломано = Объект.ТаблицаТехника.CountAll(new NsgCompare()
                    .Add(ТАБЛИЦАТЕХНИКАСТАТУС, СтатусТехники.Сломан));
                Объект.Post();
            }
        }

        public void Заполнить()
        {
            //if (!this.Объект.Selected)
            //{
            //    NsgSettings.MainForm.ShowMessage("Не выбран объект", MessageBoxIcon.Exclamation);
            //    return;
            //}
            List<Техника> техникаОбъекта = new List<Техника>();
            foreach (var i in this.Объект.ТаблицаТехника.Rows)
            {
                //if (vmoТаблица.Data.DataTable.FindRow(new NsgCompare().Add(МониторингФормированиеСменыТаблица.Names.Техника, i.Техника)) == null)
                {
                    //МониторингФормированиеСменыТаблица.Строка row = vmoТаблица.Data.DataTable.NewRow() as МониторингФормированиеСменыТаблица.Строка;
                    //row.Техника = i.Техника;
                    //row.Post();
                    техникаОбъекта.Add(i.Техника);
                }
            }
            List<Сотрудники> персоналОбъекта = new List<Сотрудники>();
            foreach (var i in this.Объект.ТаблицаПерсонал.Rows)
            {
                //if (vmoТаблицаПерсонал.Data.DataTable.FindRow(new NsgCompare().Add(МониторингФормированиеСменыДеньТаблицаПерсонал.Names.Сотрудник, i.Сотрудник)) == null)
                {
                    персоналОбъекта.Add(i.Сотрудник);
                }
            }
            ФиксацияИстории фиксацияИстории = ФиксацияИстории.Новый();
            NsgCompare cmp = new NsgCompare()
                .Add(ФиксацияИстории.Names.Объект, this.Объект)
                .Add(ФиксацияИстории.Names.Техника, техникаОбъекта.ToArray(), NsgSoft.Database.NsgComparison.In)
                .Add(ФиксацияИстории.Names.Сотрудник, персоналОбъекта.ToArray(), NsgSoft.Database.NsgComparison.In);
            var rsts = фиксацияИстории.GetRests(this.ДатаДокумента, cmp);
            this.ТаблицаТехника.FullClear();
            foreach (var i in rsts.Rows)
            {
                МониторингФормированиеСменыДеньТаблицаТехника.Строка row = null;
                row = this.ТаблицаТехника.FindRow(new NsgCompare()
                    .Add(МониторингФормированиеСменыДеньТаблицаТехника.Names.Техника, i[МониторингФормированиеСменыДеньТаблицаТехника.Names.Техника].Value));
                if (row == null)
                    row = this.ТаблицаТехника.NewRow();

                row.CopyNotPredefinedFieldsFromObject(i, МониторингФормированиеСменыДеньТаблицаТехника.Names.СтатусТехники, МониторингФормированиеСменыДеньТаблицаТехника.Names.Время);
                var смена = row[МониторингФормированиеСменыДеньТаблицаТехника.Names.НомерСмены].ToInt();
                var статус = i[МониторингФормированиеСменыДеньТаблицаТехника.Names.СтатусТехники].ToReferent() as СтатусТехники;
                if (статус == Мониторинг.СтатусТехники.ВРаботе)
                {
                    row[МониторингФормированиеСменыДеньТаблицаТехника.Names.СтатусТехники].Value = Мониторинг.СтатусТехники.НеРаботает;
                }
                else
                {
                    row[МониторингФормированиеСменыДеньТаблицаТехника.Names.СтатусТехники].Value = Мониторинг.СтатусТехники.ВРаботе;
                }
                if (смена > 0)
                {
                    if (this.Объект.РежимРаботы.Selected)
                    {
                        ДеньНедели деньНедели = ДеньНедели.ByDayOfWeek[this.ДатаДокумента.DayOfWeek];
                        var cmpRR = new NsgCompare()
                            .Add(МониторингРежимыРаботыТаблицаГрафик.Names.ДеньНедели, деньНедели);
                        var RRRow = this.Объект.РежимРаботы.ТаблицаГрафик.FindRow(cmpRR);
                        if (RRRow != null)
                        {
                            if (статус == Мониторинг.СтатусТехники.ВРаботе)
                            {
                                row[МониторингФормированиеСменыДеньТаблицаТехника.Names.Время].Value = RRRow[$"ВремяОкончанияСмены{смена}"].Value;
                            }
                            else
                            {
                                row[МониторингФормированиеСменыДеньТаблицаТехника.Names.Время].Value = RRRow[$"ВремяНачалаСмены{смена}"].Value;
                            }
                        }
                    }
                }
                row.Post();
            }
            foreach (var i in техникаОбъекта)
            {
                if (this.ТаблицаТехника.FindRow(new NsgCompare()
                    .Add(МониторингФормированиеСменыДеньТаблицаТехника.Names.Техника, i)) == null)
                {
                    var row = this.ТаблицаТехника.NewRow();
                    row[МониторингФормированиеСменыДеньТаблицаТехника.Names.Техника].Value = i;
                    row.Post();
                }
            }

            ФиксацияИсторииСотрудников фиксацияИсторииСотрудников = ФиксацияИсторииСотрудников.Новый();
            cmp = new NsgCompare()
                .Add(ФиксацияИсторииСотрудников.Names.Объект, this.Объект)
                .Add(ФиксацияИсторииСотрудников.Names.Сотрудник, персоналОбъекта.ToArray(), NsgSoft.Database.NsgComparison.In);
            rsts = фиксацияИсторииСотрудников.GetRests(this.ДатаДокумента, cmp);
            this.ТаблицаПерсонал.FullClear();
            foreach (var i in rsts.Rows)
            {
                МониторингФормированиеСменыДеньТаблицаПерсонал.Строка row = null;
                row = this.ТаблицаПерсонал.FindRow(new NsgCompare()
                    .Add(МониторингФормированиеСменыДеньТаблицаПерсонал.Names.Сотрудник, i[МониторингФормированиеСменыДеньТаблицаПерсонал.Names.Сотрудник].Value));
                if (row == null)
                    row = this.ТаблицаПерсонал.NewRow();

                row.CopyNotPredefinedFieldsFromObject(i, МониторингФормированиеСменыДеньТаблицаПерсонал.Names.СтатусСотрудника, МониторингФормированиеСменыДеньТаблицаПерсонал.Names.Время);
                var смена = row[МониторингФормированиеСменыДеньТаблицаПерсонал.Names.НомерСмены].ToInt();
                var статус = i[МониторингФормированиеСменыДеньТаблицаПерсонал.Names.СтатусСотрудника].ToReferent() as СтатусСотрудника;
                if (статус == Мониторинг.СтатусСотрудника.НаРаботе)
                {
                    row[МониторингФормированиеСменыДеньТаблицаПерсонал.Names.СтатусСотрудника].Value = Мониторинг.СтатусСотрудника.Отсутствует;
                }
                else
                {
                    row[МониторингФормированиеСменыДеньТаблицаПерсонал.Names.СтатусСотрудника].Value = Мониторинг.СтатусСотрудника.НаРаботе;
                }
                if (смена > 0)
                {
                    if (this.Объект.РежимРаботы.Selected)
                    {
                        ДеньНедели деньНедели = ДеньНедели.ByDayOfWeek[this.ДатаДокумента.DayOfWeek];
                        var cmpRR = new NsgCompare()
                            .Add(МониторингРежимыРаботыТаблицаГрафик.Names.ДеньНедели, деньНедели);
                        var RRRow = this.Объект.РежимРаботы.ТаблицаГрафик.FindRow(cmpRR);
                        if (RRRow != null)
                        {
                            if (статус == Мониторинг.СтатусСотрудника.НаРаботе)
                            {
                                row[МониторингФормированиеСменыДеньТаблицаПерсонал.Names.Время].Value = RRRow[$"ВремяОкончанияСмены{смена}"].Value;
                            }
                            else
                            {
                                row[МониторингФормированиеСменыДеньТаблицаПерсонал.Names.Время].Value = RRRow[$"ВремяНачалаСмены{смена}"].Value;
                            }
                        }
                    }
                }
                row.Post();
            }
            foreach (var i in персоналОбъекта)
            {
                if (this.ТаблицаПерсонал.FindRow(new NsgCompare()
                    .Add(МониторингФормированиеСменыДеньТаблицаПерсонал.Names.Сотрудник, i)) == null)
                {
                    var row = this.ТаблицаПерсонал.NewRow();
                    row[МониторингФормированиеСменыДеньТаблицаПерсонал.Names.Сотрудник].Value = i;
                    row.Post();
                }
            }
        }
    }

}
