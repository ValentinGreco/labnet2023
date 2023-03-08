using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public class MyCustomException : Exception
    {
        public MyCustomException(string message)  : base(message) { }  
    }
}
