using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPlanilla_2023.bean
{
    internal class Cargos
    {
        #region Propiedades
        public int id { get; set; }
        public string Detalle { get; set; }
        #endregion

        #region Metodos

        public Cargos(int id, string detalle)
        {
            this.id = id;
            this.Detalle = detalle;
        }

        public object[] getColumnasCargo()
        {
            return new object[] { id, Detalle };
        }


        #endregion
    }
}
