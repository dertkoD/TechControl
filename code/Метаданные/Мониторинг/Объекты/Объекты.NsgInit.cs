using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.IO;

using NsgSoft.DataObjects;
using NsgSoft.Design;
using NsgSoft.Database;
using NsgSoft.Common;

// ================================================================ //
// Этот файл создается автоматически, все изменения будут потеряны. //
// ================================================================ //

namespace TechControl.Метаданные.Мониторинг
{
    
    [NsgTypeName("NsgDataDictionary", Guid = "07d20ec3-3801-403d-805e-3d5bfd3eedbc")]
    public partial class Объекты : NsgSoft.DataObjects.NsgDataDictionary
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataDictionary
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataDictionary

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataDictionary
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataDictionary

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected Объекты()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Объекты(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Объекты Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("07d20ec3-3801-403d-805e-3d5bfd3eedbc"));
            if (obj == null)
                obj = new Объекты();
            return obj as Объекты;
        }

        /// <summary>
        /// Инициализация реквизитов объекта
        /// </summary>
        protected override void CreatePreDefinedFields()
		{
			#region необходимые операции до создания реквизитов и заполнения полей
			if (NsgSettings.Regime == NsgSoft.Common.NsgViewTypes.Load)
                base.CreatePreDefinedFields();
			#endregion //необходимые операции до создания реквизитов и заполнения полей
			#region начало инициализации NsgSoft.DataObjects.NsgDataDictionary
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataDictionary
			
			#region создание System.Guid Идентификатор
			{  
                NsgDataGuid Идентификатор = null;
				if (ObjectList.Contains("Идентификатор"))
                    Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                else
                    Идентификатор = new NsgDataGuid();
	//NsgDataGuid
	Идентификатор.IsLoadedFromDll = true;
	Идентификатор.StringFormat = "";
	Идентификатор.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Идентификатор.IncludeInPredefined = false;
	Идентификатор.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Идентификатор.Required = false;
	Идентификатор.EmptyValue = "";
	Идентификатор.NullAllow = false;
	Идентификатор.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Идентификатор.FieldName = "_ID";
	Идентификатор.SaveInDatabase = true;
	Идентификатор.InformMetaDataOnValueChanged = false;
	Идентификатор.Visible = true;
	Идентификатор.Name = "Идентификатор";
	Идентификатор.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Идентификатор.Description = "Идентификатор";
	Идентификатор.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Идентификатор.GroupName = "";
	Идентификатор.Guid = NsgService.StringToGuid("bb0340f9-41ba-485b-89ea-3f20ce65e4bb");
	
				if (!ObjectList.Contains("Идентификатор"))
                    ObjectList.Add(Идентификатор);
			}
			#endregion //создание System.Guid Идентификатор
			
			#region создание System.Int64 Автоинкремент
			{  
                NsgDataInteger Автоинкремент = null;
				if (ObjectList.Contains("Автоинкремент"))
                    Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                else
                    Автоинкремент = new NsgDataInteger();
	//NsgDataInteger
	Автоинкремент.IsLoadedFromDll = true;
	Автоинкремент.DefaultValue = 0M;
	Автоинкремент.MinValue = 0M;
	Автоинкремент.MaxValue = 0M;
	Автоинкремент.UseCalculator = true;
	Автоинкремент.StringFormat = "";
	Автоинкремент.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Автоинкремент.IncludeInPredefined = false;
	Автоинкремент.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Автоинкремент.Required = false;
	Автоинкремент.EmptyValue = "";
	Автоинкремент.NullAllow = false;
	Автоинкремент.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Автоинкремент.FieldName = "_AutoInc";
	Автоинкремент.SaveInDatabase = true;
	Автоинкремент.InformMetaDataOnValueChanged = false;
	Автоинкремент.Visible = true;
	Автоинкремент.Name = "Автоинкремент";
	Автоинкремент.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Автоинкремент.Description = "Автоинкремент";
	Автоинкремент.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	Автоинкремент.GroupName = "";
	Автоинкремент.Guid = NsgService.StringToGuid("d06f185b-4a91-41b4-ac7d-d69bbc5893f8");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание System.Boolean ЭтоГруппа
			{  
                NsgDataBoolean ЭтоГруппа = null;
				if (ObjectList.Contains("ЭтоГруппа"))
                    ЭтоГруппа = ObjectList["ЭтоГруппа"] as NsgDataBoolean;
                else
                    ЭтоГруппа = new NsgDataBoolean();
	//NsgDataBoolean
	ЭтоГруппа.IsLoadedFromDll = true;
	ЭтоГруппа.DefaultValue = false;
	ЭтоГруппа.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЭтоГруппа.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЭтоГруппа.StringFormat = "";
	ЭтоГруппа.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ЭтоГруппа.IncludeInPredefined = false;
	ЭтоГруппа.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЭтоГруппа.Required = false;
	ЭтоГруппа.EmptyValue = "";
	ЭтоГруппа.NullAllow = false;
	ЭтоГруппа.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ЭтоГруппа.FieldName = "_IsFolder";
	ЭтоГруппа.SaveInDatabase = true;
	ЭтоГруппа.InformMetaDataOnValueChanged = false;
	ЭтоГруппа.Visible = true;
	ЭтоГруппа.Name = "ЭтоГруппа";
	ЭтоГруппа.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЭтоГруппа.Description = "Это группа";
	ЭтоГруппа.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ЭтоГруппа.GroupName = "";
	ЭтоГруппа.Guid = NsgService.StringToGuid("ba7884a4-1b5e-4677-8716-6a0153040b92");
	
				if (!ObjectList.Contains("ЭтоГруппа"))
                    ObjectList.Add(ЭтоГруппа);
			}
			#endregion //создание System.Boolean ЭтоГруппа
			
			#region создание System.Guid ИдентификаторРодителя
			{  
                NsgDataGuid ИдентификаторРодителя = null;
				if (ObjectList.Contains("ИдентификаторРодителя"))
                    ИдентификаторРодителя = ObjectList["ИдентификаторРодителя"] as NsgDataGuid;
                else
                    ИдентификаторРодителя = new NsgDataGuid();
	//NsgDataGuid
	ИдентификаторРодителя.IsLoadedFromDll = true;
	ИдентификаторРодителя.StringFormat = "";
	ИдентификаторРодителя.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ИдентификаторРодителя.IncludeInPredefined = false;
	ИдентификаторРодителя.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИдентификаторРодителя.Required = false;
	ИдентификаторРодителя.EmptyValue = "";
	ИдентификаторРодителя.NullAllow = false;
	ИдентификаторРодителя.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ИдентификаторРодителя.FieldName = "_ParentID";
	ИдентификаторРодителя.SaveInDatabase = true;
	ИдентификаторРодителя.InformMetaDataOnValueChanged = false;
	ИдентификаторРодителя.Visible = true;
	ИдентификаторРодителя.Name = "ИдентификаторРодителя";
	ИдентификаторРодителя.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИдентификаторРодителя.Description = "Идентификатор родителя";
	ИдентификаторРодителя.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ИдентификаторРодителя.GroupName = "";
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("34a3841e-d26e-4770-811b-a7f0412549a6");
	
				if (!ObjectList.Contains("ИдентификаторРодителя"))
                    ObjectList.Add(ИдентификаторРодителя);
			}
			#endregion //создание System.Guid ИдентификаторРодителя
			
			#region создание System.Byte Уровень
			{  
                NsgDataByte Уровень = null;
				if (ObjectList.Contains("Уровень"))
                    Уровень = ObjectList["Уровень"] as NsgDataByte;
                else
                    Уровень = new NsgDataByte();
	//NsgDataByte
	Уровень.IsLoadedFromDll = true;
	Уровень.DefaultValue = 0M;
	Уровень.MinValue = 0M;
	Уровень.MaxValue = 0M;
	Уровень.UseCalculator = true;
	Уровень.StringFormat = "";
	Уровень.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Уровень.IncludeInPredefined = false;
	Уровень.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Уровень.Required = false;
	Уровень.EmptyValue = "";
	Уровень.NullAllow = false;
	Уровень.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Уровень.FieldName = "_Level";
	Уровень.SaveInDatabase = true;
	Уровень.InformMetaDataOnValueChanged = false;
	Уровень.Visible = true;
	Уровень.Name = "Уровень";
	Уровень.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Уровень.Description = "Уровень";
	Уровень.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Уровень.GroupName = "";
	Уровень.Guid = NsgService.StringToGuid("6ecf49e9-b59c-4cdf-80d1-bc158d8bfeea");
	
				if (!ObjectList.Contains("Уровень"))
                    ObjectList.Add(Уровень);
			}
			#endregion //создание System.Byte Уровень
			
			#region создание System.String ПрефиксКода
			{  
                NsgDataString ПрефиксКода = null;
				if (ObjectList.Contains("ПрефиксКода"))
                    ПрефиксКода = ObjectList["ПрефиксКода"] as NsgDataString;
                else
                    ПрефиксКода = new NsgDataString();
	//NsgDataString
	ПрефиксКода.IsLoadedFromDll = true;
	ПрефиксКода.Length = 10;
	ПрефиксКода.StringFormat = "";
	ПрефиксКода.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПрефиксКода.IncludeInPredefined = false;
	ПрефиксКода.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПрефиксКода.Required = false;
	ПрефиксКода.EmptyValue = "";
	ПрефиксКода.NullAllow = false;
	ПрефиксКода.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ПрефиксКода.FieldName = "_CodePrefix";
	ПрефиксКода.SaveInDatabase = true;
	ПрефиксКода.InformMetaDataOnValueChanged = false;
	ПрефиксКода.Visible = true;
	ПрефиксКода.Name = "ПрефиксКода";
	ПрефиксКода.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПрефиксКода.Description = "Префикс кода";
	ПрефиксКода.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ПрефиксКода.GroupName = "";
	ПрефиксКода.Guid = NsgService.StringToGuid("58212ae4-90ba-4d1a-bf3d-3b6f7e038e39");
	
				if (!ObjectList.Contains("ПрефиксКода"))
                    ObjectList.Add(ПрефиксКода);
			}
			#endregion //создание System.String ПрефиксКода
			
			#region создание System.Int64 НомерКода
			{  
                NsgDataInteger НомерКода = null;
				if (ObjectList.Contains("НомерКода"))
                    НомерКода = ObjectList["НомерКода"] as NsgDataInteger;
                else
                    НомерКода = new NsgDataInteger();
	//NsgDataInteger
	НомерКода.IsLoadedFromDll = true;
	НомерКода.DefaultValue = 0M;
	НомерКода.MinValue = 0M;
	НомерКода.MaxValue = 0M;
	НомерКода.UseCalculator = true;
	НомерКода.StringFormat = "";
	НомерКода.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НомерКода.IncludeInPredefined = false;
	НомерКода.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерКода.Required = false;
	НомерКода.EmptyValue = "";
	НомерКода.NullAllow = false;
	НомерКода.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	НомерКода.FieldName = "_CodeNumber";
	НомерКода.SaveInDatabase = true;
	НомерКода.InformMetaDataOnValueChanged = false;
	НомерКода.Visible = true;
	НомерКода.Name = "НомерКода";
	НомерКода.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НомерКода.Description = "Номер кода";
	НомерКода.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	НомерКода.GroupName = "";
	НомерКода.Guid = NsgService.StringToGuid("a82e49ee-5e6a-4b11-bb97-927581adc627");
	
				if (!ObjectList.Contains("НомерКода"))
                    ObjectList.Add(НомерКода);
			}
			#endregion //создание System.Int64 НомерКода
			
			#region создание System.String Код
			{  
                NsgDataVirtualObject Код = null;
				if (ObjectList.Contains("Код"))
                    Код = ObjectList["Код"] as NsgDataVirtualObject;
                else
                    Код = new NsgDataVirtualObject();
	//NsgDataVirtualObject
	Код.IsLoadedFromDll = true;
	Код.ArrayField = new System.String[]{"ПрефиксКода", "НомерКода"};
	Код.SaveInDatabase = false;
	Код.StringFormat = "";
	Код.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Код.IncludeInPredefined = false;
	Код.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Код.Required = false;
	Код.EmptyValue = "";
	Код.NullAllow = false;
	Код.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Код.FieldName = "_Code";
	Код.InformMetaDataOnValueChanged = false;
	Код.Visible = true;
	Код.Name = "Код";
	Код.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Код.Description = "Код элемента справочника";
	Код.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Код.GroupName = "";
	Код.Guid = NsgService.StringToGuid("f7d1ce02-044a-4f5a-aadf-424c4076ff81");
	
				if (!ObjectList.Contains("Код"))
                    ObjectList.Add(Код);
			}
			#endregion //создание System.String Код
			
			#region создание System.String Наименование
			{  
                NsgDataString Наименование = null;
				if (ObjectList.Contains("Наименование"))
                    Наименование = ObjectList["Наименование"] as NsgDataString;
                else
                    Наименование = new NsgDataString();
	//NsgDataString
	Наименование.IsLoadedFromDll = true;
	Наименование.Length = 255;
	Наименование.StringFormat = "";
	Наименование.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Наименование.IncludeInPredefined = true;
	Наименование.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Наименование.Required = false;
	Наименование.EmptyValue = "";
	Наименование.NullAllow = false;
	Наименование.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Наименование.FieldName = "Naimenovanie";
	Наименование.SaveInDatabase = true;
	Наименование.InformMetaDataOnValueChanged = false;
	Наименование.Visible = true;
	Наименование.Name = "Наименование";
	Наименование.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Наименование.Description = "Наименование элемента справочника";
	Наименование.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Наименование.GroupName = "";
	Наименование.Guid = NsgService.StringToGuid("23ac2032-13d2-443e-aa03-8f0cf586625c");
	
				if (!ObjectList.Contains("Наименование"))
                    ObjectList.Add(Наименование);
			}
			#endregion //создание System.String Наименование
			
			#region создание Сервис.СостоянияОбъекта СостояниеДокумента
			{  
                NsgDataEnumReference СостояниеДокумента = null;
				if (ObjectList.Contains("СостояниеДокумента"))
                    СостояниеДокумента = ObjectList["СостояниеДокумента"] as NsgDataEnumReference;
                else
                    СостояниеДокумента = new NsgDataEnumReference();
	//NsgDataEnumReference
	СостояниеДокумента.IsLoadedFromDll = true;
	СостояниеДокумента.ReferentGroup = "Сервис";
	СостояниеДокумента.ReferentName = "СостоянияОбъекта";
	СостояниеДокумента.SaveInDatabase = true;
	СостояниеДокумента.OwnerName = "";
	СостояниеДокумента.AllowEmptyOwner = false;
	СостояниеДокумента.StringFormat = "";
	СостояниеДокумента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	СостояниеДокумента.IncludeInPredefined = false;
	СостояниеДокумента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СостояниеДокумента.Required = false;
	СостояниеДокумента.EmptyValue = "";
	СостояниеДокумента.NullAllow = false;
	СостояниеДокумента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СостояниеДокумента.FieldName = "_State";
	СостояниеДокумента.InformMetaDataOnValueChanged = false;
	СостояниеДокумента.Visible = true;
	СостояниеДокумента.Name = "СостояниеДокумента";
	СостояниеДокумента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СостояниеДокумента.Description = "Состояние документа";
	СостояниеДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	СостояниеДокумента.GroupName = "";
	СостояниеДокумента.Guid = NsgService.StringToGuid("8bce027f-6224-4dcb-81b0-5df37cf7fd12");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание System.String Адрес
			{  
                NsgDataString Адрес = null;
				if (ObjectList.Contains("Адрес"))
                    Адрес = ObjectList["Адрес"] as NsgDataString;
                else
                    Адрес = new NsgDataString();
	//NsgDataString
	Адрес.IsLoadedFromDll = true;
	Адрес.Length = 255;
	Адрес.StringFormat = "";
	Адрес.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Адрес.IncludeInPredefined = false;
	Адрес.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Адрес.Required = false;
	Адрес.EmptyValue = "";
	Адрес.NullAllow = false;
	Адрес.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Адрес.FieldName = "Adres";
	Адрес.SaveInDatabase = true;
	Адрес.InformMetaDataOnValueChanged = false;
	Адрес.Visible = true;
	Адрес.Name = "Адрес";
	Адрес.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Адрес.Description = "Адрес";
	Адрес.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Адрес.GroupName = "";
	Адрес.Guid = NsgService.StringToGuid("73adabc8-8417-464a-b974-a6be6b4de147");
	
				if (!ObjectList.Contains("Адрес"))
                    ObjectList.Add(Адрес);
			}
			#endregion //создание System.String Адрес
			
			#region создание Мониторинг.Контрагенты Заказчик
			{  
                NsgDataTypedReference Заказчик = null;
				if (ObjectList.Contains("Заказчик"))
                    Заказчик = ObjectList["Заказчик"] as NsgDataTypedReference;
                else
                    Заказчик = new NsgDataTypedReference();
	//NsgDataTypedReference
	Заказчик.IsLoadedFromDll = true;
	Заказчик.ReferentGroup = "Мониторинг";
	Заказчик.ReferentName = "Контрагенты";
	Заказчик.SaveInDatabase = true;
	Заказчик.OwnerName = "";
	Заказчик.AllowEmptyOwner = false;
	Заказчик.StringFormat = "";
	Заказчик.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Заказчик.IncludeInPredefined = false;
	Заказчик.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Заказчик.Required = false;
	Заказчик.EmptyValue = "";
	Заказчик.NullAllow = false;
	Заказчик.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Заказчик.FieldName = "Zakazchik";
	Заказчик.InformMetaDataOnValueChanged = false;
	Заказчик.Visible = true;
	Заказчик.Name = "Заказчик";
	Заказчик.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Заказчик.Description = "Заказчик";
	Заказчик.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Заказчик.GroupName = "";
	Заказчик.Guid = NsgService.StringToGuid("448c7c60-4809-499d-8f87-8ef5a0646058");
	
				if (!ObjectList.Contains("Заказчик"))
                    ObjectList.Add(Заказчик);
			}
			#endregion //создание Мониторинг.Контрагенты Заказчик
			
			#region создание Мониторинг.ТипСобственности СобственностьТехники
			{  
                NsgDataEnumReference СобственностьТехники = null;
				if (ObjectList.Contains("СобственностьТехники"))
                    СобственностьТехники = ObjectList["СобственностьТехники"] as NsgDataEnumReference;
                else
                    СобственностьТехники = new NsgDataEnumReference();
	//NsgDataEnumReference
	СобственностьТехники.IsLoadedFromDll = true;
	СобственностьТехники.ReferentGroup = "Мониторинг";
	СобственностьТехники.ReferentName = "ТипСобственности";
	СобственностьТехники.SaveInDatabase = true;
	СобственностьТехники.OwnerName = "";
	СобственностьТехники.AllowEmptyOwner = false;
	СобственностьТехники.StringFormat = "";
	СобственностьТехники.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	СобственностьТехники.IncludeInPredefined = false;
	СобственностьТехники.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СобственностьТехники.Required = false;
	СобственностьТехники.EmptyValue = "";
	СобственностьТехники.NullAllow = false;
	СобственностьТехники.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СобственностьТехники.FieldName = "SobstvennostTekhniki";
	СобственностьТехники.InformMetaDataOnValueChanged = false;
	СобственностьТехники.Visible = true;
	СобственностьТехники.Name = "СобственностьТехники";
	СобственностьТехники.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СобственностьТехники.Description = "Собственность техники";
	СобственностьТехники.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СобственностьТехники.GroupName = "";
	СобственностьТехники.Guid = NsgService.StringToGuid("f7f10b9e-3ec5-476a-b1e3-9fd1e861784c");
	
				if (!ObjectList.Contains("СобственностьТехники"))
                    ObjectList.Add(СобственностьТехники);
			}
			#endregion //создание Мониторинг.ТипСобственности СобственностьТехники
			
			#region создание System.String ГраницаОбъектаМониторинга
			{  
                NsgDataString ГраницаОбъектаМониторинга = null;
				if (ObjectList.Contains("ГраницаОбъектаМониторинга"))
                    ГраницаОбъектаМониторинга = ObjectList["ГраницаОбъектаМониторинга"] as NsgDataString;
                else
                    ГраницаОбъектаМониторинга = new NsgDataString();
	//NsgDataString
	ГраницаОбъектаМониторинга.IsLoadedFromDll = true;
	ГраницаОбъектаМониторинга.Length = 0;
	ГраницаОбъектаМониторинга.StringFormat = "";
	ГраницаОбъектаМониторинга.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ГраницаОбъектаМониторинга.IncludeInPredefined = false;
	ГраницаОбъектаМониторинга.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ГраницаОбъектаМониторинга.Required = false;
	ГраницаОбъектаМониторинга.EmptyValue = "";
	ГраницаОбъектаМониторинга.NullAllow = false;
	ГраницаОбъектаМониторинга.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ГраницаОбъектаМониторинга.FieldName = "GranicaObektaMoni";
	ГраницаОбъектаМониторинга.SaveInDatabase = true;
	ГраницаОбъектаМониторинга.InformMetaDataOnValueChanged = false;
	ГраницаОбъектаМониторинга.Visible = true;
	ГраницаОбъектаМониторинга.Name = "ГраницаОбъектаМониторинга";
	ГраницаОбъектаМониторинга.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ГраницаОбъектаМониторинга.Description = "Граница объекта мониторинга";
	ГраницаОбъектаМониторинга.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ГраницаОбъектаМониторинга.GroupName = "";
	ГраницаОбъектаМониторинга.Guid = NsgService.StringToGuid("dcf03f83-9cc9-4c88-8d30-8784d15bfe7c");
	
				if (!ObjectList.Contains("ГраницаОбъектаМониторинга"))
                    ObjectList.Add(ГраницаОбъектаМониторинга);
			}
			#endregion //создание System.String ГраницаОбъектаМониторинга
			
			#region создание System.DateTime НачалоРабочейСмены
			{  
                NsgDataDateTime НачалоРабочейСмены = null;
				if (ObjectList.Contains("НачалоРабочейСмены"))
                    НачалоРабочейСмены = ObjectList["НачалоРабочейСмены"] as NsgDataDateTime;
                else
                    НачалоРабочейСмены = new NsgDataDateTime();
	//NsgDataDateTime
	НачалоРабочейСмены.IsLoadedFromDll = true;
	НачалоРабочейСмены.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	НачалоРабочейСмены.StringFormat = "";
	НачалоРабочейСмены.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	НачалоРабочейСмены.IncludeInPredefined = false;
	НачалоРабочейСмены.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НачалоРабочейСмены.Required = false;
	НачалоРабочейСмены.EmptyValue = "";
	НачалоРабочейСмены.NullAllow = false;
	НачалоРабочейСмены.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НачалоРабочейСмены.FieldName = "NachaloRabocheijS";
	НачалоРабочейСмены.SaveInDatabase = true;
	НачалоРабочейСмены.InformMetaDataOnValueChanged = false;
	НачалоРабочейСмены.Visible = true;
	НачалоРабочейСмены.Name = "НачалоРабочейСмены";
	НачалоРабочейСмены.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НачалоРабочейСмены.Description = "Начало рабочей смены";
	НачалоРабочейСмены.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НачалоРабочейСмены.GroupName = "";
	НачалоРабочейСмены.Guid = NsgService.StringToGuid("12cb973b-2fe5-4e97-ab9e-cf6c894f8e63");
	
				if (!ObjectList.Contains("НачалоРабочейСмены"))
                    ObjectList.Add(НачалоРабочейСмены);
			}
			#endregion //создание System.DateTime НачалоРабочейСмены
			
			#region создание Мониторинг.Сотрудники Ответственный
			{  
                NsgDataTypedReference Ответственный = null;
				if (ObjectList.Contains("Ответственный"))
                    Ответственный = ObjectList["Ответственный"] as NsgDataTypedReference;
                else
                    Ответственный = new NsgDataTypedReference();
	//NsgDataTypedReference
	Ответственный.IsLoadedFromDll = true;
	Ответственный.ReferentGroup = "Мониторинг";
	Ответственный.ReferentName = "Сотрудники";
	Ответственный.SaveInDatabase = true;
	Ответственный.OwnerName = "";
	Ответственный.AllowEmptyOwner = false;
	Ответственный.StringFormat = "";
	Ответственный.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Ответственный.IncludeInPredefined = false;
	Ответственный.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Ответственный.Required = false;
	Ответственный.EmptyValue = "";
	Ответственный.NullAllow = false;
	Ответственный.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Ответственный.FieldName = "Otvetstvennyij";
	Ответственный.InformMetaDataOnValueChanged = false;
	Ответственный.Visible = true;
	Ответственный.Name = "Ответственный";
	Ответственный.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Ответственный.Description = "Ответственный";
	Ответственный.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Ответственный.GroupName = "";
	Ответственный.Guid = NsgService.StringToGuid("4e4c78d6-af38-422a-81be-d3fa921ef67f");
	
				if (!ObjectList.Contains("Ответственный"))
                    ObjectList.Add(Ответственный);
			}
			#endregion //создание Мониторинг.Сотрудники Ответственный
			
			#region создание System.DateTime КонецРабочейСмены
			{  
                NsgDataDateTime КонецРабочейСмены = null;
				if (ObjectList.Contains("КонецРабочейСмены"))
                    КонецРабочейСмены = ObjectList["КонецРабочейСмены"] as NsgDataDateTime;
                else
                    КонецРабочейСмены = new NsgDataDateTime();
	//NsgDataDateTime
	КонецРабочейСмены.IsLoadedFromDll = true;
	КонецРабочейСмены.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	КонецРабочейСмены.StringFormat = "";
	КонецРабочейСмены.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	КонецРабочейСмены.IncludeInPredefined = false;
	КонецРабочейСмены.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КонецРабочейСмены.Required = false;
	КонецРабочейСмены.EmptyValue = "";
	КонецРабочейСмены.NullAllow = false;
	КонецРабочейСмены.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КонецРабочейСмены.FieldName = "KonecRabocheijSmeny";
	КонецРабочейСмены.SaveInDatabase = true;
	КонецРабочейСмены.InformMetaDataOnValueChanged = false;
	КонецРабочейСмены.Visible = true;
	КонецРабочейСмены.Name = "КонецРабочейСмены";
	КонецРабочейСмены.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КонецРабочейСмены.Description = "Конец рабочей смены";
	КонецРабочейСмены.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КонецРабочейСмены.GroupName = "";
	КонецРабочейСмены.Guid = NsgService.StringToGuid("f802ff8a-24a8-42c5-9790-62677d53a26b");
	
				if (!ObjectList.Contains("КонецРабочейСмены"))
                    ObjectList.Add(КонецРабочейСмены);
			}
			#endregion //создание System.DateTime КонецРабочейСмены
			
			#region создание Мониторинг.Контрагенты Фирма
			{  
                NsgDataTypedReference Фирма = null;
				if (ObjectList.Contains("Фирма"))
                    Фирма = ObjectList["Фирма"] as NsgDataTypedReference;
                else
                    Фирма = new NsgDataTypedReference();
	//NsgDataTypedReference
	Фирма.IsLoadedFromDll = true;
	Фирма.ReferentGroup = "Мониторинг";
	Фирма.ReferentName = "Контрагенты";
	Фирма.SaveInDatabase = true;
	Фирма.OwnerName = "";
	Фирма.AllowEmptyOwner = false;
	Фирма.StringFormat = "";
	Фирма.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Фирма.IncludeInPredefined = false;
	Фирма.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Фирма.Required = false;
	Фирма.EmptyValue = "";
	Фирма.NullAllow = false;
	Фирма.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Фирма.FieldName = "Firma";
	Фирма.InformMetaDataOnValueChanged = false;
	Фирма.Visible = true;
	Фирма.Name = "Фирма";
	Фирма.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Фирма.Description = "Фирма";
	Фирма.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Фирма.GroupName = "";
	Фирма.Guid = NsgService.StringToGuid("c4c7ca53-fb13-4569-8df4-8078918021da");
	
				if (!ObjectList.Contains("Фирма"))
                    ObjectList.Add(Фирма);
			}
			#endregion //создание Мониторинг.Контрагенты Фирма
			
			#region создание Мониторинг.РежимыРаботы РежимРаботы
			{  
                NsgDataTypedReference РежимРаботы = null;
				if (ObjectList.Contains("РежимРаботы"))
                    РежимРаботы = ObjectList["РежимРаботы"] as NsgDataTypedReference;
                else
                    РежимРаботы = new NsgDataTypedReference();
	//NsgDataTypedReference
	РежимРаботы.IsLoadedFromDll = true;
	РежимРаботы.ReferentGroup = "Мониторинг";
	РежимРаботы.ReferentName = "РежимыРаботы";
	РежимРаботы.SaveInDatabase = true;
	РежимРаботы.OwnerName = "";
	РежимРаботы.AllowEmptyOwner = false;
	РежимРаботы.StringFormat = "";
	РежимРаботы.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	РежимРаботы.IncludeInPredefined = false;
	РежимРаботы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	РежимРаботы.Required = false;
	РежимРаботы.EmptyValue = "";
	РежимРаботы.NullAllow = false;
	РежимРаботы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	РежимРаботы.FieldName = "RezhimRaboty";
	РежимРаботы.InformMetaDataOnValueChanged = false;
	РежимРаботы.Visible = true;
	РежимРаботы.Name = "РежимРаботы";
	РежимРаботы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	РежимРаботы.Description = "Режим работы";
	РежимРаботы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	РежимРаботы.GroupName = "";
	РежимРаботы.Guid = NsgService.StringToGuid("ca0becdd-c3bd-4458-85f9-2d0044b1c845");
	
				if (!ObjectList.Contains("РежимРаботы"))
                    ObjectList.Add(РежимРаботы);
			}
			#endregion //создание Мониторинг.РежимыРаботы РежимРаботы
			
			#region создание System.String Договор
			{  
                NsgDataString Договор = null;
				if (ObjectList.Contains("Договор"))
                    Договор = ObjectList["Договор"] as NsgDataString;
                else
                    Договор = new NsgDataString();
	//NsgDataString
	Договор.IsLoadedFromDll = true;
	Договор.Length = 50;
	Договор.StringFormat = "";
	Договор.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Договор.IncludeInPredefined = false;
	Договор.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Договор.Required = false;
	Договор.EmptyValue = "";
	Договор.NullAllow = false;
	Договор.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Договор.FieldName = "Dogovor";
	Договор.SaveInDatabase = true;
	Договор.InformMetaDataOnValueChanged = false;
	Договор.Visible = true;
	Договор.Name = "Договор";
	Договор.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Договор.Description = "Договор";
	Договор.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Договор.GroupName = "";
	Договор.Guid = NsgService.StringToGuid("3616a987-735a-45f8-ab82-5e1309c6fc38");
	
				if (!ObjectList.Contains("Договор"))
                    ObjectList.Add(Договор);
			}
			#endregion //создание System.String Договор
			
			#region создание System.Boolean Включен
			{  
                NsgDataBoolean Включен = null;
				if (ObjectList.Contains("Включен"))
                    Включен = ObjectList["Включен"] as NsgDataBoolean;
                else
                    Включен = new NsgDataBoolean();
	//NsgDataBoolean
	Включен.IsLoadedFromDll = true;
	Включен.DefaultValue = false;
	Включен.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Включен.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Включен.StringFormat = "";
	Включен.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Включен.IncludeInPredefined = false;
	Включен.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Включен.Required = false;
	Включен.EmptyValue = "";
	Включен.NullAllow = false;
	Включен.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Включен.FieldName = "Vkljuchen";
	Включен.SaveInDatabase = true;
	Включен.InformMetaDataOnValueChanged = false;
	Включен.Visible = true;
	Включен.Name = "Включен";
	Включен.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Включен.Description = "Включен";
	Включен.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Включен.GroupName = "";
	Включен.Guid = NsgService.StringToGuid("82b3fc61-5e0d-41de-a844-8d7bc4f49cd6");
	
				if (!ObjectList.Contains("Включен"))
                    ObjectList.Add(Включен);
			}
			#endregion //создание System.Boolean Включен
			
			#region создание _SystemTables.МониторингОбъектыТаблицаПерсонал ТаблицаПерсонал
			{  
                NsgDataTableReference ТаблицаПерсонал = null;
				if (ObjectList.Contains("ТаблицаПерсонал"))
                    ТаблицаПерсонал = ObjectList["ТаблицаПерсонал"] as NsgDataTableReference;
                else
                    ТаблицаПерсонал = new NsgDataTableReference();
	//NsgDataTableReference
	ТаблицаПерсонал.IsLoadedFromDll = true;
	ТаблицаПерсонал.Name = "ТаблицаПерсонал";
	ТаблицаПерсонал.SaveInDatabase = false;
	ТаблицаПерсонал.ReferentGroup = "_SystemTables";
	ТаблицаПерсонал.ReferentName = "МониторингОбъектыТаблицаПерсонал";
	ТаблицаПерсонал.OwnerName = "";
	ТаблицаПерсонал.AllowEmptyOwner = false;
	ТаблицаПерсонал.StringFormat = "";
	ТаблицаПерсонал.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	ТаблицаПерсонал.IncludeInPredefined = false;
	ТаблицаПерсонал.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТаблицаПерсонал.Required = false;
	ТаблицаПерсонал.EmptyValue = "";
	ТаблицаПерсонал.NullAllow = false;
	ТаблицаПерсонал.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТаблицаПерсонал.FieldName = "TablicaPersonal";
	ТаблицаПерсонал.InformMetaDataOnValueChanged = false;
	ТаблицаПерсонал.Visible = true;
	ТаблицаПерсонал.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТаблицаПерсонал.Description = "Таблица персонал";
	ТаблицаПерсонал.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТаблицаПерсонал.GroupName = "";
	ТаблицаПерсонал.Guid = NsgService.StringToGuid("503fcae0-6281-4f53-bbf8-e517cf449a59");
	
				if (!ObjectList.Contains("ТаблицаПерсонал"))
                    ObjectList.Add(ТаблицаПерсонал);
			}
			#endregion //создание _SystemTables.МониторингОбъектыТаблицаПерсонал ТаблицаПерсонал
			
			#region создание _SystemTables.МониторингОбъектыТаблицаТехника ТаблицаТехника
			{  
                NsgDataTableReference ТаблицаТехника = null;
				if (ObjectList.Contains("ТаблицаТехника"))
                    ТаблицаТехника = ObjectList["ТаблицаТехника"] as NsgDataTableReference;
                else
                    ТаблицаТехника = new NsgDataTableReference();
	//NsgDataTableReference
	ТаблицаТехника.IsLoadedFromDll = true;
	ТаблицаТехника.Name = "ТаблицаТехника";
	ТаблицаТехника.SaveInDatabase = false;
	ТаблицаТехника.ReferentGroup = "_SystemTables";
	ТаблицаТехника.ReferentName = "МониторингОбъектыТаблицаТехника";
	ТаблицаТехника.OwnerName = "";
	ТаблицаТехника.AllowEmptyOwner = false;
	ТаблицаТехника.StringFormat = "";
	ТаблицаТехника.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	ТаблицаТехника.IncludeInPredefined = false;
	ТаблицаТехника.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТаблицаТехника.Required = false;
	ТаблицаТехника.EmptyValue = "";
	ТаблицаТехника.NullAllow = false;
	ТаблицаТехника.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТаблицаТехника.FieldName = "TablicaTekhnika";
	ТаблицаТехника.InformMetaDataOnValueChanged = false;
	ТаблицаТехника.Visible = true;
	ТаблицаТехника.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТаблицаТехника.Description = "Таблица техника";
	ТаблицаТехника.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТаблицаТехника.GroupName = "";
	ТаблицаТехника.Guid = NsgService.StringToGuid("99a1e19e-06a1-4e30-a5f4-f3422c93dcb2");
	
				if (!ObjectList.Contains("ТаблицаТехника"))
                    ObjectList.Add(ТаблицаТехника);
			}
			#endregion //создание _SystemTables.МониторингОбъектыТаблицаТехника ТаблицаТехника
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Наименование";
	PeriodicTable = "";
	MaxGroupLevel = 100;
	HasOwner = false;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Объекты";
	Visible = true;
	Guid = NsgService.StringToGuid("07d20ec3-3801-403d-805e-3d5bfd3eedbc");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Наименование}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_dic_Obekty";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Справочник";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Мониторинг";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataDictionary
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataDictionary

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataDictionary.Names
        {
            
            /// <summary>
            /// Идентификатор
            /// </summary>
            public static String Идентификатор
            {
                get
                {
                    return "Идентификатор";
                }
            }
            
            /// <summary>
            /// Автоинкремент
            /// </summary>
            public static String Автоинкремент
            {
                get
                {
                    return "Автоинкремент";
                }
            }
            
            /// <summary>
            /// Это группа
            /// </summary>
            public static String ЭтоГруппа
            {
                get
                {
                    return "ЭтоГруппа";
                }
            }
            
            /// <summary>
            /// Идентификатор родителя
            /// </summary>
            public static String ИдентификаторРодителя
            {
                get
                {
                    return "ИдентификаторРодителя";
                }
            }
            
            /// <summary>
            /// Уровень
            /// </summary>
            public static String Уровень
            {
                get
                {
                    return "Уровень";
                }
            }
            
            /// <summary>
            /// Префикс кода
            /// </summary>
            public static String ПрефиксКода
            {
                get
                {
                    return "ПрефиксКода";
                }
            }
            
            /// <summary>
            /// Номер кода
            /// </summary>
            public static String НомерКода
            {
                get
                {
                    return "НомерКода";
                }
            }
            
            /// <summary>
            /// Код элемента справочника
            /// </summary>
            public static String Код
            {
                get
                {
                    return "Код";
                }
            }
            
            /// <summary>
            /// Наименование элемента справочника
            /// </summary>
            public static String Наименование
            {
                get
                {
                    return "Наименование";
                }
            }
            
            /// <summary>
            /// Состояние документа
            /// </summary>
            public static String СостояниеДокумента
            {
                get
                {
                    return "СостояниеДокумента";
                }
            }
            
            /// <summary>
            /// Адрес
            /// </summary>
            public static String Адрес
            {
                get
                {
                    return "Адрес";
                }
            }
            
            /// <summary>
            /// Заказчик
            /// </summary>
            public static String Заказчик
            {
                get
                {
                    return "Заказчик";
                }
            }
            
            /// <summary>
            /// Собственность техники
            /// </summary>
            public static String СобственностьТехники
            {
                get
                {
                    return "СобственностьТехники";
                }
            }
            
            /// <summary>
            /// Граница объекта мониторинга
            /// </summary>
            public static String ГраницаОбъектаМониторинга
            {
                get
                {
                    return "ГраницаОбъектаМониторинга";
                }
            }
            
            /// <summary>
            /// Начало рабочей смены
            /// </summary>
            public static String НачалоРабочейСмены
            {
                get
                {
                    return "НачалоРабочейСмены";
                }
            }
            
            /// <summary>
            /// Ответственный
            /// </summary>
            public static String Ответственный
            {
                get
                {
                    return "Ответственный";
                }
            }
            
            /// <summary>
            /// Конец рабочей смены
            /// </summary>
            public static String КонецРабочейСмены
            {
                get
                {
                    return "КонецРабочейСмены";
                }
            }
            
            /// <summary>
            /// Фирма
            /// </summary>
            public static String Фирма
            {
                get
                {
                    return "Фирма";
                }
            }
            
            /// <summary>
            /// Режим работы
            /// </summary>
            public static String РежимРаботы
            {
                get
                {
                    return "РежимРаботы";
                }
            }
            
            /// <summary>
            /// Договор
            /// </summary>
            public static String Договор
            {
                get
                {
                    return "Договор";
                }
            }
            
            /// <summary>
            /// Включен
            /// </summary>
            public static String Включен
            {
                get
                {
                    return "Включен";
                }
            }
            
            /// <summary>
            /// Таблица персонал
            /// </summary>
            public static String ТаблицаПерсонал
            {
                get
                {
                    return "ТаблицаПерсонал";
                }
            }
            
            /// <summary>
            /// Таблица техника
            /// </summary>
            public static String ТаблицаТехника
            {
                get
                {
                    return "ТаблицаТехника";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public override NsgMultipleObjectDescriptor Descriptor
        {
            get
            {
                if (descriptor == null)
                {
                    descriptor = new NsgMultipleObjectDescriptor();
                    descriptor.Name = "Объекты";
                    descriptor.GroupName = "Мониторинг";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "Мониторинг.Объекты";
        }

        
        /// <summary>
        /// Идентификатор
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataGuid")]
        
        public System.Guid Идентификатор
        {
            get
            {
				 NsgDataGuid __Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                 return (System.Guid)__Идентификатор.Value;
            }
            set
            {
                NsgDataGuid __Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                __Идентификатор.Value = value;
            }
        }
        
        /// <summary>
        /// Автоинкремент
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 Автоинкремент
        {
            get
            {
				 NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                 return (System.Int64)__Автоинкремент.Value;
            }
            set
            {
                NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                __Автоинкремент.Value = value;
            }
        }
        
        /// <summary>
        /// Это группа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ЭтоГруппа
        {
            get
            {
				 NsgDataBoolean __ЭтоГруппа = ObjectList["ЭтоГруппа"] as NsgDataBoolean;
                 return (System.Boolean)__ЭтоГруппа.Value;
            }
            set
            {
                NsgDataBoolean __ЭтоГруппа = ObjectList["ЭтоГруппа"] as NsgDataBoolean;
                __ЭтоГруппа.Value = value;
            }
        }
        
        /// <summary>
        /// Идентификатор родителя
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataGuid")]
        
        public System.Guid ИдентификаторРодителя
        {
            get
            {
				 NsgDataGuid __ИдентификаторРодителя = ObjectList["ИдентификаторРодителя"] as NsgDataGuid;
                 return (System.Guid)__ИдентификаторРодителя.Value;
            }
            set
            {
                NsgDataGuid __ИдентификаторРодителя = ObjectList["ИдентификаторРодителя"] as NsgDataGuid;
                __ИдентификаторРодителя.Value = value;
            }
        }
        
        /// <summary>
        /// Уровень
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataByte")]
        
        public System.Byte Уровень
        {
            get
            {
				 NsgDataByte __Уровень = ObjectList["Уровень"] as NsgDataByte;
                 return (System.Byte)__Уровень.Value;
            }
            set
            {
                NsgDataByte __Уровень = ObjectList["Уровень"] as NsgDataByte;
                __Уровень.Value = value;
            }
        }
        
        /// <summary>
        /// Префикс кода
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ПрефиксКода
        {
            get
            {
				 NsgDataString __ПрефиксКода = ObjectList["ПрефиксКода"] as NsgDataString;
                 return (System.String)__ПрефиксКода.Value;
            }
            set
            {
                NsgDataString __ПрефиксКода = ObjectList["ПрефиксКода"] as NsgDataString;
                __ПрефиксКода.Value = value;
            }
        }
        
        /// <summary>
        /// Номер кода
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 НомерКода
        {
            get
            {
				 NsgDataInteger __НомерКода = ObjectList["НомерКода"] as NsgDataInteger;
                 return (System.Int64)__НомерКода.Value;
            }
            set
            {
                NsgDataInteger __НомерКода = ObjectList["НомерКода"] as NsgDataInteger;
                __НомерКода.Value = value;
            }
        }
        
        /// <summary>
        /// Код элемента справочника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataVirtualObject")]
        
        public System.String Код
        {
            get
            {
				 NsgDataVirtualObject __Код = ObjectList["Код"] as NsgDataVirtualObject;
                 return (System.String)__Код.Value;
            }
            set
            {
                NsgDataVirtualObject __Код = ObjectList["Код"] as NsgDataVirtualObject;
                __Код.Value = value;
            }
        }
        
        /// <summary>
        /// Наименование элемента справочника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Наименование
        {
            get
            {
				 NsgDataString __Наименование = ObjectList["Наименование"] as NsgDataString;
                 return (System.String)__Наименование.Value;
            }
            set
            {
                NsgDataString __Наименование = ObjectList["Наименование"] as NsgDataString;
                __Наименование.Value = value;
            }
        }
        
        /// <summary>
        /// Состояние документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.СостоянияОбъекта СостояниеДокумента
        {
            get
            {
				 NsgDataEnumReference __СостояниеДокумента = ObjectList["СостояниеДокумента"] as NsgDataEnumReference;
                 return (Сервис.СостоянияОбъекта)__СостояниеДокумента.Referent;
            }
            set
            {
                NsgDataEnumReference __СостояниеДокумента = ObjectList["СостояниеДокумента"] as NsgDataEnumReference;
                __СостояниеДокумента.Referent = value;
            }
        }
        
        /// <summary>
        /// Адрес
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Адрес
        {
            get
            {
				 NsgDataString __Адрес = ObjectList["Адрес"] as NsgDataString;
                 return (System.String)__Адрес.Value;
            }
            set
            {
                NsgDataString __Адрес = ObjectList["Адрес"] as NsgDataString;
                __Адрес.Value = value;
            }
        }
        
        /// <summary>
        /// Заказчик
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Контрагенты Заказчик
        {
            get
            {
				 NsgDataTypedReference __Заказчик = ObjectList["Заказчик"] as NsgDataTypedReference;
                 return (Мониторинг.Контрагенты)__Заказчик.Referent;
            }
            set
            {
                NsgDataTypedReference __Заказчик = ObjectList["Заказчик"] as NsgDataTypedReference;
                __Заказчик.Referent = value;
            }
        }
        
        /// <summary>
        /// Собственность техники
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Мониторинг.ТипСобственности СобственностьТехники
        {
            get
            {
				 NsgDataEnumReference __СобственностьТехники = ObjectList["СобственностьТехники"] as NsgDataEnumReference;
                 return (Мониторинг.ТипСобственности)__СобственностьТехники.Referent;
            }
            set
            {
                NsgDataEnumReference __СобственностьТехники = ObjectList["СобственностьТехники"] as NsgDataEnumReference;
                __СобственностьТехники.Referent = value;
            }
        }
        
        /// <summary>
        /// Граница объекта мониторинга
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ГраницаОбъектаМониторинга
        {
            get
            {
				 NsgDataString __ГраницаОбъектаМониторинга = ObjectList["ГраницаОбъектаМониторинга"] as NsgDataString;
                 return (System.String)__ГраницаОбъектаМониторинга.Value;
            }
            set
            {
                NsgDataString __ГраницаОбъектаМониторинга = ObjectList["ГраницаОбъектаМониторинга"] as NsgDataString;
                __ГраницаОбъектаМониторинга.Value = value;
            }
        }
        
        /// <summary>
        /// Начало рабочей смены
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime НачалоРабочейСмены
        {
            get
            {
				 NsgDataDateTime __НачалоРабочейСмены = ObjectList["НачалоРабочейСмены"] as NsgDataDateTime;
                 return (System.DateTime)__НачалоРабочейСмены.Value;
            }
            set
            {
                NsgDataDateTime __НачалоРабочейСмены = ObjectList["НачалоРабочейСмены"] as NsgDataDateTime;
                __НачалоРабочейСмены.Value = value;
            }
        }
        
        /// <summary>
        /// Ответственный
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Сотрудники Ответственный
        {
            get
            {
				 NsgDataTypedReference __Ответственный = ObjectList["Ответственный"] as NsgDataTypedReference;
                 return (Мониторинг.Сотрудники)__Ответственный.Referent;
            }
            set
            {
                NsgDataTypedReference __Ответственный = ObjectList["Ответственный"] as NsgDataTypedReference;
                __Ответственный.Referent = value;
            }
        }
        
        /// <summary>
        /// Конец рабочей смены
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime КонецРабочейСмены
        {
            get
            {
				 NsgDataDateTime __КонецРабочейСмены = ObjectList["КонецРабочейСмены"] as NsgDataDateTime;
                 return (System.DateTime)__КонецРабочейСмены.Value;
            }
            set
            {
                NsgDataDateTime __КонецРабочейСмены = ObjectList["КонецРабочейСмены"] as NsgDataDateTime;
                __КонецРабочейСмены.Value = value;
            }
        }
        
        /// <summary>
        /// Фирма
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Контрагенты Фирма
        {
            get
            {
				 NsgDataTypedReference __Фирма = ObjectList["Фирма"] as NsgDataTypedReference;
                 return (Мониторинг.Контрагенты)__Фирма.Referent;
            }
            set
            {
                NsgDataTypedReference __Фирма = ObjectList["Фирма"] as NsgDataTypedReference;
                __Фирма.Referent = value;
            }
        }
        
        /// <summary>
        /// Режим работы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.РежимыРаботы РежимРаботы
        {
            get
            {
				 NsgDataTypedReference __РежимРаботы = ObjectList["РежимРаботы"] as NsgDataTypedReference;
                 return (Мониторинг.РежимыРаботы)__РежимРаботы.Referent;
            }
            set
            {
                NsgDataTypedReference __РежимРаботы = ObjectList["РежимРаботы"] as NsgDataTypedReference;
                __РежимРаботы.Referent = value;
            }
        }
        
        /// <summary>
        /// Договор
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Договор
        {
            get
            {
				 NsgDataString __Договор = ObjectList["Договор"] as NsgDataString;
                 return (System.String)__Договор.Value;
            }
            set
            {
                NsgDataString __Договор = ObjectList["Договор"] as NsgDataString;
                __Договор.Value = value;
            }
        }
        
        /// <summary>
        /// Включен
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean Включен
        {
            get
            {
				 NsgDataBoolean __Включен = ObjectList["Включен"] as NsgDataBoolean;
                 return (System.Boolean)__Включен.Value;
            }
            set
            {
                NsgDataBoolean __Включен = ObjectList["Включен"] as NsgDataBoolean;
                __Включен.Value = value;
            }
        }
        
        /// <summary>
        /// Таблица персонал
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингОбъектыТаблицаПерсонал ТаблицаПерсонал
        {
            get
            {
				 NsgDataTableReference __ТаблицаПерсонал = ObjectList["ТаблицаПерсонал"] as NsgDataTableReference;
                 return (_SystemTables.МониторингОбъектыТаблицаПерсонал)__ТаблицаПерсонал.Referent;
            }
            set
            {
                NsgDataTableReference __ТаблицаПерсонал = ObjectList["ТаблицаПерсонал"] as NsgDataTableReference;
                __ТаблицаПерсонал.Referent = value;
            }
        }
        
        /// <summary>
        /// Таблица техника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингОбъектыТаблицаТехника ТаблицаТехника
        {
            get
            {
				 NsgDataTableReference __ТаблицаТехника = ObjectList["ТаблицаТехника"] as NsgDataTableReference;
                 return (_SystemTables.МониторингОбъектыТаблицаТехника)__ТаблицаТехника.Referent;
            }
            set
            {
                NsgDataTableReference __ТаблицаТехника = ObjectList["ТаблицаТехника"] as NsgDataTableReference;
                __ТаблицаТехника.Referent = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataDictionary
        

        /// <summary>
		/// Родитель для данного элемента справочника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        public Объекты Родитель
        {
            get
            {
                return base.Parent as Объекты;
            }
            set
            {
                base.Parent = value;
            }
        }
        #region #Comment_Predefined#
        
        #endregion //#Comment_Predefined#
		

        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataDictionary

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataDictionary
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataDictionary

        #region Методы NsgMultipleObject
        private Объекты[] convertArray(NsgMultipleObject[] array)
        {
            Объекты[] res = new Объекты[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск множества результатов на полное совпадение. Перегруженные методы.
        /// <summary>
        /// Метод поиска в БД по одному и более реквизитов с ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        /// </remarks>
        /// <param name="compare">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual Объекты[] FindAll(NsgCompare compare)
        {
            return convertArray(base.FindAll(compare));
        }

        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному и более реквизитов
        ///  c ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="paramAll">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual Объекты[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, compare));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Имя реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual Объекты[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Идентификатор реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual Объекты[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Объекты(this as NsgObject);
            }
        }

        #endregion // Методы NsgMultipleObject
        #endregion // Методы

        /// <summary>
        /// Описатель колонки источника данных
        /// </summary>
        public new class ColumnDescriptor : NsgSoft.Forms.NsgColumnDescriptor
        {
            public ColumnDescriptor()
                : base()
            {
                base.NSGType = typeof(Объекты);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Объекты Value
            {
                get
                {
                    return (Объекты)base.Value;
                }
                set
                {
                    base.Value = value;
                }
            }

            /// <summary>
            /// Имя иконки колонки
            /// </summary>
            public override string ImageKey
            {
                get
                {
                    return "s_NsgDataDictionary";
                }
            }
        }

    }

}
