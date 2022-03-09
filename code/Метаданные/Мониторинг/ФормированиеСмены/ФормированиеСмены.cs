using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ФормированиеСмены
    {
        #region Данные
        #endregion //Данные

        #region Конструкторы
        #endregion //Конструкторы

        #region Свойства
        #endregion //Свойства

        #region Методы
        protected override bool Handling()
        {
            List<Техника> t = new List<Техника>();
            bool error = false;
            StringBuilder ts = new StringBuilder();
            foreach (var i in this.Таблица.Rows)
            {
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

            //Get rest по ФиксацияИстории на дату документа - тик. Оттуда берем время работы. Если статус в работе не менялся в ФиксацияИстории пишем старое время.
            //в РегистрСмен пишем время в работе 
            var рег = ФиксацияИстории.Новый();
            рег.New();
            рег.Объект = this.Объект;
            рег.Владелец = this;

            var регСмены = РегистрСмен.Новый();
            регСмены.New();
            регСмены.Document = this;

            foreach (var i in this.Таблица.Rows)
            {
                рег.Сотрудник = i.Сотрудник;
                рег.Техника = i.Техника;
                рег.GetRest(i.Время.AddTicks(-1));
                var предСтатусТехники = рег.СтатусТехники.Clone as СтатусТехники;
                рег.СтатусТехники = i.СтатусТехники;
                if (i.СтатусТехники != СтатусТехники.ВРаботе && предСтатусТехники == СтатусТехники.ВРаботе)
                {
                    //if (предСтатусТехники == СтатусТехники.ВРаботе)
                    {
                        var предВремя = рег.Время;
                        рег.Дата = рег.Время = i.Время.Date == NsgService.MinDate ?
                            this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date)) :
                            i.Время;
                        регСмены.ДатаДокумента = рег.Время;
                        регСмены.Объект = this.Объект;
                        регСмены.Сотрудник = i.Сотрудник;
                        регСмены.Техника = i.Техника;
                        регСмены.ОтработанноеВремя = (предВремя == NsgService.MinDate) ? 0 : (decimal)(рег.Время - предВремя).TotalHours;
                        регСмены.Сумма = this.Тариф.Стоимость * регСмены.ОтработанноеВремя;
                        регСмены.ВидДвижения = Сервис.ВидыДвижений.Расход;
                        регСмены.AddMovement();
                    }
                }
                else
                {
                    рег.Дата = рег.Время = i.Время.Date == NsgService.MinDate ?
                        this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date)) :
                        i.Время;
                }
                //рег.Дата = рег.КонецПериода = рег.Время;
                рег.Владелец = this;
                рег.AddMovement();
            }
            if (регСмены.MovementTable.Count > 0 && !регСмены.Post()) return false;
            рег.Владелец = this;
            return рег.Post();


            рег.GetRest(this.ДатаДокумента.AddTicks(-1));
            /*var */регСмены = РегистрСмен.Новый();
            регСмены.New();
            foreach (var i in this.Таблица.Rows)
            {
                if (i.СтатусТехники != СтатусТехники.ВРаботе)
                {
                    регСмены.Объект = this.Объект;
                    регСмены.Сотрудник = i.Сотрудник;
                    регСмены.Техника = i.Техника;
                    регСмены.ОтработанноеВремя = 0;
                    регСмены.Сумма = this.Тариф.Стоимость * регСмены.ОтработанноеВремя; //Брать из текущего тарифа по объекту * время работы
                    регСмены.AddMovement();
                }
            }
            return регСмены.Post();
        }
        #endregion //Методы
    }

}
