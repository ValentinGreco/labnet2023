using PracticaEF.Data;
using PracticaEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEF.Logic
{
    public class ShippersLogic : BaseLogic , IAbmLogic<Shippers>
    {
        public void Agregar(Shippers _employees)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int _employeesId)
        {
            throw new NotImplementedException();
        }

        public List<Shippers> GetAll()
        {
            return _context.Shippers.ToList();
        }

        public void Modificar(Shippers _employeesId)
        {
            throw new NotImplementedException();
        }
    }
}
