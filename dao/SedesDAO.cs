using System;
using System.Data;
using System.Windows.Forms;

namespace appPlanilla_2023.dao
{
    internal class SedesDAO
    {
        db.Db db = new db.Db("cnPlanillas");
        db.Db dbOnpe = new db.Db("cnOnpe");
        


        internal void getDepartamentos(ComboBox cboDepartamento, string sTexto = null)
        {
            dbOnpe.Sentencia("usp_getDepartamentos 1,25");
            dbOnpe.getComboBox(cboDepartamento, sTexto);
        }

        internal void getProvincias(ComboBox cboDepartamento, object idDepartamento, string sTexto = null) 
        {
            dbOnpe.Sentencia("usp_getProvincias " + idDepartamento);
            dbOnpe.getComboBox(cboDepartamento, sTexto);
        }

        internal void getDistritos(ComboBox cboDepartamento, object idProvincia, string sTexto = null)
        {
            dbOnpe.Sentencia("usp_getDistritos " + idProvincia);
            dbOnpe.getComboBox(cboDepartamento, sTexto);
        }

        internal DataTable getSedes()
        {
            db.Sentencia("sp_getSedes");
            return db.getDataTable();
        }
    }
}
