using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public class Calculadora
    {

        public int DividirporCero(int num1 , int num2) 
        {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                
                throw ex;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }

        public int DividirDosNumeros(int num1, int num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                
                throw ex;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
            
        }
    }
}
