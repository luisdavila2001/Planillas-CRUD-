using appPlanilla_2023.bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPlanilla_2023.dao
{
    internal class EmpleadoDAO
    {
        db.Db db = new db.Db("cnplanillas");

        public bool Login(Empleados empleado)
        {
            db.Sentencia(string.Format("sp_EmpleadoLogin '{0},'{1}'", empleado.Dni, empleado.Passwordd));
            empleado.setEmpleado(db.getDataRow());
            return empleado.id > 0;
        }
    }
}
