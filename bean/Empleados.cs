using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace appPlanilla_2023.bean
{
    internal class Empleados
    {
        #region Propiedades
        public int id { get; set; }
        public string Dni { get; set; }
        public string Ruc { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public string Passwordd { get; set; }
        public int idDomiciliado { get; set; }
        public int idEstadoCivil { get; set; }
        public int idNivelEducativo { get; set; }
        public int idDepartamento { get; set; }
        public int idProvincia { get; set; }
        public int idDistrito { get; set; }
        #endregion

        #region Metodos

        public void setEmpleado(DataRow dr)
        {
            if (dr == null) return;

            id = int.Parse(dr["id"].ToString());
            Dni = dr["Dni"].ToString();
            Ruc = dr["Ruc"].ToString();
            Nombres = dr["Nombres"].ToString();
            ApellidoPaterno = dr["ApellidoPaterno"].ToString();
            ApellidoMaterno = dr["ApellidoMaterno"].ToString();
            Direccion = dr["Direccion"].ToString();
            Correo = dr["Correo"].ToString();
            Celular = dr["Celular"].ToString();
            Passwordd = dr["Passwordd"].ToString();
            idDomiciliado = int.Parse(dr["idDomiciliado"].ToString());
            idEstadoCivil = int.Parse(dr["idEstadoCivil"].ToString());
            idNivelEducativo = int.Parse(dr["idNivelEducativo"].ToString());
            idDepartamento = int.Parse(dr["idDepartamento"].ToString());
            idProvincia = int.Parse(dr["idProvincia"].ToString());
            idDistrito = int.Parse(dr["idDistrito"].ToString());
        }

        internal void setEmpleado(object v)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

