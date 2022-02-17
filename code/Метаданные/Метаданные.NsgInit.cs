using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Design;
using System.IO;
using NsgSoft.Common;

namespace TechControl.Метаданные
{
    public partial class Метаданные : NsgSoft.DataObjects.NsgMetaData
    {
        #region Данные
        #endregion //Данные

        #region Инициализация


        public static Метаданные Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("2dbd2646-52ef-4d89-8d8e-ef1f94e39426"));
            if (obj == null)
                obj = new Метаданные();
            return obj as Метаданные;
        }

        /// <summary>
        /// Инициализация
        /// </summary>
        protected override void InitObjectList()
        {
            ObjectList.AddRange( new NsgMultipleObject[] {TechControl.Метаданные.Сервис.DataAssemblyObject.Новый(),
	 TechControl.Метаданные.Сервис.БазыДанныхДляОбмена.Новый(),
	 TechControl.Метаданные.Сервис.ОбъектыОбмена.Новый(),
	 TechControl.Метаданные.Сервис.ТипыОбмена.Новый(),
	 TechControl.Метаданные.Сервис.ПравилаОбменаДанными.Новый(),
	 TechControl.Метаданные.Сервис.ПротоколОбмена.Новый(),
	 TechControl.Метаданные.Сервис.НастройкиКаналаОбмена.Новый(),
	 TechControl.Метаданные.Сервис.ОбменДанными.Новый(),
	 TechControl.Метаданные.Сервис.ИмпортДанных.Новый(),
	 TechControl.Метаданные.Сервис.СервисноеОбслуживание.Новый(),
	 TechControl.Метаданные.Сервис.СостоянияОбъекта.Новый(),
	 TechControl.Метаданные.Сервис.ВидыДвижений.Новый(),
	 TechControl.Метаданные.Сервис.ОбщийЖурнал.Новый(),
	 TechControl.Метаданные.Сервис.НеактуальностьИтоговРегистров.Новый(),
	 TechControl.Метаданные.Сервис.ПечатныеФормы.Новый(),
	 TechControl.Метаданные._SystemTables.СервисПечатныеФормыДвижения.Новый(),
	 TechControl.Метаданные.Сервис.КорректировкаРегистра.Новый(),
	 TechControl.Метаданные._SystemTables.PeriodicTable.Новый(),
	 TechControl.Метаданные.Мониторинг.ТипТС.Новый(),
	 TechControl.Метаданные.Мониторинг.Марка.Новый(),
	 TechControl.Метаданные.Мониторинг.РегистрМониторингТехники.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрМониторингТехникиДвижения.Новый(),
	 TechControl.Метаданные.Мониторинг.Техника.Новый(),
	 TechControl.Метаданные.Мониторинг.Модель.Новый(),
	 TechControl.Метаданные.Мониторинг.СистемаМониторинга.Новый()});
        }
        
        /// <summary>
        /// Инициализация
        /// </summary>
        private void InitializeComponent()
        {
            	//NsgMetaData
	IsLoadedFromDll = true;
	Guid = NsgService.StringToGuid("2dbd2646-52ef-4d89-8d8e-ef1f94e39426");
	PeriodicTable = "_SystemTables.PeriodicTable";
	SystemGroup = "_SystemTables";
	Version = "2022.2.17.1";
	ContainsUserInformation = false;
	UserActionsRegisteration = false;
	UseUserMenu = false;
	Groups = new System.String[]{"Сервис", "Мониторинг"};
	Name = "Метаданные";
	
            AfterLoad();
        }

        #endregion //Инициализация

        #region Свойства
        #endregion //Свойства

        #region Методы
        /// <summary>
        /// Идентификатор текущего уровня метаданных
        /// </summary>
        private string ID
        {
            get
            {
                return "TechControl";
            }
        }
        #endregion //Методы
    }
}
