using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    public interface ICarniceriaCRUD<T>
    {
        public List<T> LeerCRUD();

        public void ModificarCRUD(T usuario);
       
    }
}
