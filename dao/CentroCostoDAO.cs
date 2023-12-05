using appPlanilla_2023.bean;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPlanilla_2023.dao
{
    internal class CentroCostoDAO
    {
        db.Db db = new db.Db("cnPlanillas");

        public DataTable getCentroCostos()
        {
            db.Sentencia("sp_getCentroCostos");
            return db.getDataTable();
        }

        public bool Guardar(CentroCosto centroCosto)
        {
            //db.Sentencia(string.Format("sp_GuardarCentroCosto '{0}','{1}'", centroCosto.id, centroCosto.Detalle));

            db.Sentencia("sp_GuardarCentroCosto");
            db.Parametros(centroCosto.getColumnas());
            return db.Ejecutar() > 0;
        }
    }
}
