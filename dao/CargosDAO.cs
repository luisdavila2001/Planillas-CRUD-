using appPlanilla_2023.bean;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPlanilla_2023.dao
{
    internal class CargoDAO
    {
        db.Db db = new db.Db("cnPlanillas");

        public DataTable getCargo()
        {
            db.Sentencia("select * from vCargos order by id"); //sp_getCargos
            return db.getDataTable();
        }

        public bool Guardar(Cargos cargo)
        {
          
            db.Sentencia("sp_GuardarCargo");
            db.Parametros(cargo.getColumnasCargo());
            return db.Ejecutar() > 0;
        }

        public int EliminarCargo(int id)
        {
            db.Sentencia("sp_EliminarCargo");
            db.Parametros(id);
            return db.Ejecutar();
        }

    }
}
