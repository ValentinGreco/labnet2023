using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOOLABTransporte
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Variables Locales
            Omnibus _omnibus; 
            Taxi _taxi;
            #endregion

            Console.WriteLine($"Indique Transporte desea crear:\n[1] Omnibus\n[2] Taxi\n\n Seleccion :  ");
            int seleccion = int.Parse(Console.ReadLine());

            Console.WriteLine($"Indique la cantidad de pasajeros:");
            int cantp = int.Parse(Console.ReadLine());

            if (seleccion == 1 )
            {
                _omnibus = new Omnibus(cantp);

                Console.WriteLine($"El Omnibus posee {_omnibus.Obtenerpasajeros()} pasajeros");
                Console.WriteLine($"{_omnibus.Avanzar()} ");
                Console.WriteLine($"{_omnibus.Detenerse()} ");
            }
            else 
            {
                _taxi = new Taxi(cantp);

                Console.WriteLine($"El Taxi posee {_taxi.Obtenerpasajeros()} pasajeros");
                Console.WriteLine($"{_taxi.Avanzar()} ");
                Console.WriteLine($"{_taxi.Detenerse()} ");
            }
           
            
            Console.WriteLine($"\nDeseas Crear mas Transportes:\n[1] si\n[0] no ");
            int _validar = int.Parse(Console.ReadLine());

            while (_validar == 1 )//  N° Bucle de Repeticion
            {
                Console.WriteLine($"\nIndique Transporte desea crear:\n[1] Omnibus\n[2] Taxi\n\n Seleccion :  ");
                seleccion = int.Parse(Console.ReadLine());
                
                if (seleccion == 1)
                {
                    Console.WriteLine($"Indique la cantidad de pasajeros:");
                    cantp = int.Parse(Console.ReadLine());

                    _omnibus = new Omnibus(cantp);
                   
                    Console.WriteLine($"\nEl Omnibus posee {_omnibus.Obtenerpasajeros()} pasajeros");
                    Console.WriteLine($"{_omnibus.Avanzar()} ");
                    Console.WriteLine($"{_omnibus.Detenerse()} ");
                }
                else
                {
                    Console.WriteLine($"Indique la cantidad de pasajeros:");
                    cantp = int.Parse(Console.ReadLine());
                    
                    _taxi = new Taxi(cantp);

                    Console.WriteLine($"\nEl Taxi posee {_taxi.Obtenerpasajeros()} pasajeros");
                    Console.WriteLine($"{_taxi.Avanzar()} ");
                    Console.WriteLine($"{_taxi.Detenerse()} ");
                }

                Console.WriteLine($"\nDeseas seguir Creando mas Transportes:\n[1] si\n[0] no ");
                _validar = int.Parse(Console.ReadLine());
            }
            
           
            
        }
    }
}
