using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;





namespace TechControl.Метаданные.СпециальнаяОдежда
{
    
    public partial class ПеремещениеИнструментаФормаЭлемента

    {
        public ПеремещениеИнструментаФормаЭлемента()
        {
            InitializeComponent();
		}

        #region #Comments_Data# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Data# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Methods# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Methods# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Properties# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Properties# NsgSoft.Forms.NsgMultipleObjectElementForm

        private void nsgIGrid1_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName.Contains("Цена"))
            {
                if (Количество.Value != 0)
                {
                    Сумма.Value = Цена.Value * Количество.Value;
                }
            }
            else if (e.ColumnName.Contains("Сумма"))
            {
                if (Количество.Value != 0)
                {
                    Цена.Value = Сумма.Value / Количество.Value;
                }
            }
            else if (e.ColumnName.Contains("Количество"))
            {
                if (Сумма.Value != 0 && Цена.Value == 0)
                {
                    Цена.Value = Сумма.Value / Количество.Value;
                }
                else if (Цена.Value != 0 && Сумма.Value == 0)
                {
                    Сумма.Value = Цена.Value * Количество.Value;
                }
            }
        }
    }
    


}