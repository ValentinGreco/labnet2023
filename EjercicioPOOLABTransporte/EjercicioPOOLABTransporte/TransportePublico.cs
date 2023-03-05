using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOOLABTransporte
{
    public abstract class TransportePublico //Clase Base Abstracta
    {
        private int pasajeros { get; set; } // Propiedad privada

        public TransportePublico(int _cantpasajeros) //Constructor
        {
           this.pasajeros = _cantpasajeros;
        }
        

        #region  Metodos
        public abstract string Avanzar();
        public abstract string Detenerse();
        public int Obtenerpasajeros()
        {
            return this.pasajeros;
        }
        #endregion
    }
}
