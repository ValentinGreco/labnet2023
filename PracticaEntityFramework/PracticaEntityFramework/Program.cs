using PracticaEF.Entidades;
using PracticaEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEF.UI
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            
                EmployeesLogic _employeesLogic = new EmployeesLogic();
                ShippersLogic _shippersLogic = new ShippersLogic();


            string seleccion = "1";
                
                while (seleccion != "0") 
                {
                    Console.Write($"\nPor favor Ingrese: [1] para mostrar una las Listas  o [2] para realizar una Alta, Baja o Modificacion  o [0] para salir: ");
                     seleccion = Console.ReadLine();

                    if (seleccion == "1")
                    {
                        
                        
                            Console.Write($"\nPor favor Ingrese: [1] para mostrar una  lista  de Empleados o [2] para mostrar la lista de Shippers :");
                            seleccion = Console.ReadLine();
                            if (seleccion == "1")
                            {
                                foreach (Employees employees in _employeesLogic.GetAll())
                                {
                                    Console.WriteLine($"{employees.EmployeeID} - {employees.FirstName} {employees.LastName} ");

                                }
                                

                                Console.Write($"\nPor favor Ingrese: [1] para volver al menu o [2] para salir :");
                                seleccion = Console.ReadLine();
                                if(seleccion == "2") { Environment.Exit(0); }

                            }
                            if (seleccion == "2")
                            {
                                foreach (Shippers shippers in _shippersLogic.GetAll())
                                {
                                    Console.WriteLine($"{shippers.ShipperID} - {shippers.Phone} {shippers.CompanyName} ");

                                }
                                
                                Console.Write($"\nPor favor Ingrese: [1] para volver al menu o [2] para salir :");
                                seleccion = Console.ReadLine();
                                if (seleccion == "2") { Environment.Exit(0); }
                            }
                        
                        
                        
                    }
                    if (seleccion == "2")
                    {
                         Console.WriteLine($"\nIndique que quiere quiere realizar:[1]Alta /[2]baja/[3]Modificar");
                        string _seleccion = (Console.ReadLine());
                       
                        
                            if (_seleccion == "1") // Agregar
                            {
                                Employees NewEmployee = new Employees();

                                Console.WriteLine($"\nIndique el nombre para el empleado:");
                                NewEmployee.FirstName = Console.ReadLine();

                                Console.WriteLine($"\nIndique el apellido para el empleado:");
                                NewEmployee.LastName = Console.ReadLine();

                                Console.WriteLine($"\nEl Empleado fue agregado Correctamente");

                                _employeesLogic.Agregar(NewEmployee);
                            }
                            if (_seleccion == "2") // Eliminar
                            {
                                bool flag = false;

                                Console.WriteLine($"\nIndique el ID que desea eliminar:");

                                int idE;

                                if (int.TryParse(Console.ReadLine(), out idE))
                                {
                                    foreach (Employees employees in _employeesLogic.GetAll())
                                    {
                                        if (employees.EmployeeID == idE)
                                        {
                                            _employeesLogic.Eliminar(idE);
                                            Console.WriteLine($"El ID ingresado se Elimino Correctamente");
                                            flag = true;
                                            break;
                                        }
                                    }
                                    if (flag == false)
                                    {
                                        Console.WriteLine($"\nPor favor verifique el ID ingresado");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"\nPor favor ingrese un valor entero válido");
                                }

                            }
                            if (_seleccion == "3") // Modificar
                            {
                                Employees ModEmployee = new Employees();
                                bool flag = false;
                                Console.WriteLine($"\nIndique el ID que desea Modificar:");

                                int idM;

                                
                                if (int.TryParse(Console.ReadLine(), out idM))
                                {
                                    ModEmployee.EmployeeID = idM;

                                    foreach (Employees employees in _employeesLogic.GetAll())
                                    {
                                        if (employees.EmployeeID == ModEmployee.EmployeeID)
                                        {
                                            Console.WriteLine($"\nIndique el nombre a Modificar:");
                                            ModEmployee.FirstName = Console.ReadLine();

                                            Console.WriteLine($"\nIndique el apellido a Modificar:");
                                            ModEmployee.LastName = Console.ReadLine();

                                            _employeesLogic.Modificar(ModEmployee);
                                            Console.WriteLine($"\nSe modificó el usuario correctamente {employees.EmployeeID} - {ModEmployee.FirstName} {ModEmployee.LastName}");
                                            flag = true;
                                            break;
                                        }
                                    }
                                    if (flag == false)
                                    {
                                        Console.WriteLine($"\nPor favor verifique el ID ingresado");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"\nPor favor ingrese un valor entero válido");
                                }

                            }
                        
                        
                    }
                    else
                    {
                        seleccion = "3";
                        Console.WriteLine($"\nIngrese una opcion valida");    

                    }
                }
           


            Console.ReadKey();

        }
    }
}
