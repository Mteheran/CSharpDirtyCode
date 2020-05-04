using CSharpDirtyCode.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;

namespace CSharpDirtyCode
{
    public class DataSetService
    {
        private DataTable ResultToDataset(IList<object> data, List<ObjectResult> listOfValues)
        {
            try
            {

                DataTable ResultDt = new DataTable("Resultado");
                ResultDt.Columns.Add("Campo1", typeof(string));
                ResultDt.Columns.Add("Campo2", typeof(string));
                ResultDt.Columns.Add("Campo3", typeof(string));
                ResultDt.Columns.Add("Campo4", typeof(string));
                ResultDt.Columns.Add("Campo5", typeof(string));
                ResultDt.Columns.Add("Campo6", typeof(string));
                ResultDt.Columns.Add("Campo7", typeof(string));
                ResultDt.Columns.Add("Campo8", typeof(string));
                ResultDt.Columns.Add("Campo9", typeof(string));
                ResultDt.Columns.Add("Campo10", typeof(string));
                ResultDt.Columns.Add("Campo11", typeof(string));
                ResultDt.Columns.Add("Campo12", typeof(string));
                ResultDt.Columns.Add("Campo13", typeof(string));
                ResultDt.Columns.Add("Campo14", typeof(string));
                ResultDt.Columns.Add("Campo15", typeof(string));
                DataRow Row;

                foreach (ObjectResult Item in listOfValues)
                {
                    Row = ResultDt.NewRow();
                    Row["Campo1"] = (Item.Campo1 == null) ? null : Item.Campo1.ToString(CultureInfo.CurrentCulture);
                    Row["Campo2"] = (Item.Campo2 == null) ? null : Item.Campo2.ToString(CultureInfo.CurrentCulture);
                    Row["Campo3"] = (Item.Campo3 == null) ? null : Item.Campo3.ToString(CultureInfo.CurrentCulture);
                    Row["Campo4"] = (Item.Campo4 == null) ? null : Item.Campo4.ToString(CultureInfo.CurrentCulture);
                    Row["Campo5"] = (Item.Campo5 == null) ? null : Item.Campo5.ToString(CultureInfo.CurrentCulture);
                    Row["Campo6"] = (Item.Campo6 == null) ? null : Item.Campo6.ToString(CultureInfo.CurrentCulture);
                    Row["Campo7"] = (Item.Campo7 == null) ? null : Item.Campo7.ToString(CultureInfo.CurrentCulture);
                    Row["Campo8"] = (Item.Campo8 == null) ? null : Item.Campo8.ToString(CultureInfo.CurrentCulture);
                    Row["Campo9"] = (Item.Campo9 == null) ? null : Item.Campo9.ToString(CultureInfo.CurrentCulture);
                    Row["Campo10"] = (Item.Campo10 == null) ? null : Item.Campo10.ToString(CultureInfo.CurrentCulture);
                    Row["Campo11"] = (Item.Campo11 == null) ? null : Item.Campo11.ToString(CultureInfo.CurrentCulture);
                    Row["Campo12"] = (Item.Campo12 == null) ? null : Item.Campo12.ToString(CultureInfo.CurrentCulture);
                    Row["Campo13"] = (Item.Campo13 == null) ? null : Item.Campo13.ToString(CultureInfo.CurrentCulture);
                    Row["Campo14"] = (Item.Campo14 == null) ? null : Item.Campo14.ToString(CultureInfo.CurrentCulture);
                    Row["Campo15"] = (Item.Campo15 == null) ? null : Item.Campo15.ToString(CultureInfo.CurrentCulture);
                    ResultDt.Rows.Add(Row);
                }
                return ResultDt;

            }
            catch (Exception e)
            {
                DataTable ResultDt = new DataTable("Resultado");
                return ResultDt;
                // MessageBox.Show("Exepcion" + e.Message);
            }
        }
    }
}
