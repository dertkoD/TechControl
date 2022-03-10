using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Мониторинг
{

    public partial class ЗакрытиеСмены
    {
        protected override bool Handling()
        {
            var фиксацияИстории = ФиксацияИстории.Новый(this);
            фиксацияИстории.New();
            фиксацияИстории.Владелец = this;
            фиксацияИстории.Объект = this.Объект;
            //фиксацияИстории.Техника = this.Техника;
            var allRests = фиксацияИстории.GetRests(this.Время,
                new NsgCompare().Add(ФиксацияИстории.Names.Объект, this.Объект).Add(ФиксацияИстории.Names.СтатусТехники, СтатусТехники.ВРаботе));
            foreach (var i in allRests.Rows)
            {

                var предВремя = i[ФиксацияИстории.Names.Дата].ToDateTime();
                РегистрСмен регистрСмен = РегистрСмен.Новый(this);
                фиксацияИстории.New();
                регистрСмен.New();
                регистрСмен.Техника = фиксацияИстории.Техника = /*this.Техника;*/ i[ФиксацияИстории.Names.Техника].ToReferent() as Техника;
                регистрСмен.Объект = фиксацияИстории.Объект = /*this.Объект;*/ i[ФиксацияИстории.Names.Объект].ToReferent() as Объекты;
                decimal price;
                if (i[ФиксацияИстории.Names.Владелец].ToReferent() is ФормированиеСмены doc)
                {
                    price = doc.Тариф.Стоимость;
                }
                else
                {
                    регистрСмен.GetRest(this.Время);
                    price = (регистрСмен.ОтработанноеВремя == 0) ? 0 : регистрСмен.Сумма / регистрСмен.ОтработанноеВремя;
                }
                регистрСмен.Сотрудник = фиксацияИстории.Сотрудник = i[ФиксацияИстории.Names.Сотрудник].ToReferent() as Сотрудники;
                регистрСмен.ДатаДокумента = фиксацияИстории.Дата = фиксацияИстории.Время = NsgService.EndOfDay(this.ДатаДокумента);
                фиксацияИстории.СтатусТехники = СтатусТехники.НеРаботает;
                фиксацияИстории.Владелец = this;
                фиксацияИстории.AddMovement();
                //фиксацияИстории.Post();

                регистрСмен.ОтработанноеВремя = (предВремя == NsgService.MinDate) ? 0 : (decimal)(фиксацияИстории.Время - предВремя).TotalHours;
                регистрСмен.Сумма = price * регистрСмен.ОтработанноеВремя;
                регистрСмен.ВидДвижения = Сервис.ВидыДвижений.Расход;
                регистрСмен.AddMovement();
                регистрСмен.Post();

                //фиксацияИстории.New();
                фиксацияИстории.Техника = /*this.Техника;*/ i[ФиксацияИстории.Names.Техника].ToReferent() as Техника;
                фиксацияИстории.Объект = /*this.Объект;*/ i[ФиксацияИстории.Names.Объект].ToReferent() as Объекты;
                фиксацияИстории.Дата = фиксацияИстории.Время = NsgService.BeginOfDay(this.ДатаДокумента.AddDays(1));
                фиксацияИстории.СтатусТехники = СтатусТехники.ВРаботе;
                фиксацияИстории.Владелец = this;
                фиксацияИстории.AddMovement();
                фиксацияИстории.Post();
            }
            return true;
        }
    }

}
