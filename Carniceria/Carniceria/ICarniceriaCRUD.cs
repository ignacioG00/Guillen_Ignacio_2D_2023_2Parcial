using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    public interface ICarniceriaCRUD<T>
    {
        public List<T> LeerArchivos();

        public void ModificarArchivos(T usuario);
       
    }
}
