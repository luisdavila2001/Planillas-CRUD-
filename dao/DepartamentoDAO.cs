using appPlanilla_2023.bean;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPlanilla_2023.dao
{
    internal class DepartamentoDAO
    {
        db.Db db = new db.Db("cnplanillas");

        public DataTable getDepartamento()
        {
            db.Sentencia("sp_getDepartamentos");
            return db.getDataTable();
        }

        public bool Guardar(Departamento Departamento)
        {
          
            db.Sentencia("sp_GuardarDepartamento");
            db.Parametros(Departamento.getColumnasDepartamento());
            return db.Ejecutar() > 0;
        }

        public int EliminarDepartamento(int id)
        {
            db.Sentencia("sp_EliminarDepartamento");
            db.Parametros(id);
            return db.Ejecutar();
        }

    }
}
