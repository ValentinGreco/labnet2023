using PracticaEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEF.Logic
{
    public interface IAbmLogic<T> 
    {
        List<T> GetAll();
        void Agregar(T _employees);
        void Eliminar(int _employeesId);
        void Modificar(T _employeesId);
    }
}
