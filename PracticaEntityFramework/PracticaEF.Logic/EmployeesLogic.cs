using PracticaEF.Data;
using PracticaEF.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEF.Logic
{
    public class EmployeesLogic : BaseLogic ,IAbmLogic<Employees>
    {
        

        public List<Employees> GetAll() 
        {
            return _context.Employees.ToList();
        }

        public void Agregar(Employees _employees) 
        {
            try
            {
                _context.Employees.Add(_employees);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void Eliminar(int _employeesId)
        {
            

           var EmpleEliminar= _context.Employees.Single(r => r.EmployeeID == _employeesId);

            _context.Employees.Remove(EmpleEliminar);
            _context.SaveChanges();
        }

        public void Modificar(Employees _employeesId) 
        {
            var EmpleModificar = _context.Employees.Find(_employeesId.EmployeeID);

            EmpleModificar.FirstName = _employeesId.FirstName;
            EmpleModificar.LastName = _employeesId.LastName;
           
            
            _context.SaveChanges();
        }
    }
}
