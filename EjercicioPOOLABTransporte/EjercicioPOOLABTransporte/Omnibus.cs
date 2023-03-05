using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOOLABTransporte
{
    public class Omnibus : TransportePublico
    {
        

       public Omnibus(int _cantpasajeros) : base(_cantpasajeros) 
       {
       
       }

        #region Metodos
        public override string Avanzar()
        {
            return string.Format("El Omnibus avanza hacia la parada");
        }

        public override string Detenerse()
        {
            return string.Format("El Omnibus se detuvo para que los pasajeros suban");
        }
        #endregion
    }
}
