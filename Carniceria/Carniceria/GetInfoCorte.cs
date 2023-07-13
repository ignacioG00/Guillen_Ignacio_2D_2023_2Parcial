using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    public class GetInfoCorte : EventArgs
    {
        private string corteCarne;

        public string CorteCarne
        {
            get { return this.corteCarne; }
        }

        public GetInfoCorte(Producto producto)
        {
            this.corteCarne = producto.CorteDeCarne;
        }
    }
}
