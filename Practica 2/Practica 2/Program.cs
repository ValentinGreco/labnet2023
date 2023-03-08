using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculadora _calculadora = new Calculadora();

            //Punto 1
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPUNTO 1");
            Console.ResetColor();

            Console.WriteLine("\nPor favor ingrese un número entero para realizar la division por 0:");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            try
            {
                
                Console.WriteLine("\nEl número que devuelve es: " + _calculadora.DividirporCero(number, 0));
            }
            catch (DivideByZeroException )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError: No se puede dividir por cero.");
                Console.ResetColor();
                
            }finally 
            { Console.WriteLine("\nRecorrio el Finally"); }

           


            //Punto 2
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPUNTO 2");
            Console.ResetColor();

            bool inputIsValid = false;

            while (!inputIsValid)
            {
                Console.WriteLine("\nPor favor ingrese el numero Dividendo para realizar la division:");
                input = Console.ReadLine();
               
                if (!int.TryParse(input, out number ))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError: Seguro Ingreso una letra o no ingreso nada!");
                    Console.ResetColor();
                }
                else 
                {
                    
                    inputIsValid = true; 
                }
            }
            


            inputIsValid = false;
            
            while (!inputIsValid)
            {
                Console.WriteLine("\nPor favor ingrese el numero Divisor para realizar la division:");
                string input2 = Console.ReadLine();
                int number2 = int.Parse(input);


                if (!int.TryParse(input2, out number2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError: Seguro Ingreso una letra o no ingreso nada!");
                    Console.ResetColor();
                }
                else
                {
                  try 
                  { 
                      Console.WriteLine("\nEl número que devuelve es: " + _calculadora.DividirDosNumeros(number, number2)); 
                    
                  }
                    catch (DivideByZeroException)
                  {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nError: Solo Chuck Norris divide por 0!");
                        Console.ResetColor();
                   }
                    finally
                    {
                        Console.WriteLine("\nRecorrio el Finally");
                    }

                   
                    inputIsValid = true;
                }
            }

            //Punto 3
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPUNTO 3");
            Console.ResetColor();

            Logic _logic = new Logic();

            try
            {
                _logic.ThrowException();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nMensaje de la Excepción: {ex.Message}");
                Console.WriteLine($"\nTipo de la Excepción: {ex.GetType()}");
                Console.ResetColor();
            }

            //Punto 4
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPUNTO 4");
            Console.ResetColor();

            try
            {
                _logic.ThrowCustomException();
            }
            catch (MyCustomException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"\nMensaje de la Excepción: {ex.Message}");
                Console.WriteLine($"\nTipo de la Excepción: {ex.GetType()}");
                Console.ResetColor();
            }

            Console.ReadKey();  
        }
    }
}
