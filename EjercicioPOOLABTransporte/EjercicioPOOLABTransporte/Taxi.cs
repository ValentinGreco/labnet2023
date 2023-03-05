using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOOLABTransporte
{
    public class Taxi : TransportePublico
    {


        public Taxi(int _cantpasajeros) : base(_cantpasajeros)
        {

        }
        #region Metodos
        public override string Avanzar()
        {
            return string.Format("El Taxi avanza hacia los pasajeros");
        }

        public override string Detenerse()
        {
            return string.Format("El Taxi se detuvo para que los pasajeros suban ");
        }
        #endregion
    }
}
