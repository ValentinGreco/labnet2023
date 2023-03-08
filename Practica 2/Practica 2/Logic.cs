using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public class Logic
    {
        //Punto 3
        public void ThrowException()
        {
            throw new Exception("¡Ha ocurrido una excepción!");
        }

        //Punto 4
        public void ThrowCustomException()
        {
            throw new MyCustomException("¡HOLA,Se obtuvo una Excepción Personalizada!");
        }
    }
}
