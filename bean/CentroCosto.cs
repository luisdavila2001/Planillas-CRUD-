using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPlanilla_2023.bean
{
    internal class CentroCosto
    {
        #region Propiedades
        public int id { get; set; }
        public string Detalle { get; set; }
        #endregion

        #region Metodos

        public CentroCosto(int id, string detalle) 
        {
            this.id = id;
            this.Detalle = detalle;
        }

        public object[] getColumnas()
        {
            return new object[] { id, Detalle };
        }

        
        #endregion
        
    }
}
