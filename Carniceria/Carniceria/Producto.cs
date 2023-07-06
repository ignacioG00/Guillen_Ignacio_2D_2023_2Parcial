using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Carniceria
{
    public class Producto
    {
        private decimal precioPorKilo;
        private decimal stock;
        private string corteDeCarne;

        public Producto(decimal precioPorKilo, decimal stock, string corteDeCarne)
        {
            this.precioPorKilo = precioPorKilo;
            this.stock = stock;
            this.corteDeCarne = corteDeCarne;
        }

        public Producto()
        {
        }

        
        [XmlElement] public string CorteDeCarne { get { return corteDeCarne; } set => corteDeCarne = value; }
        public decimal PrecioPorKilo { get => precioPorKilo; set => precioPorKilo = value; }
        public decimal Stock { get { return stock; } set { stock = value; } }


        public static bool CorteNoExistente(List<Producto> listCarnes,string nombreCorte)
        {
            int contador = 0;
            for (int i = 0; i < listCarnes.Count; i++)
            {
                if (nombreCorte == listCarnes[i].CorteDeCarne)
                {
                    contador +=1;
                }
            }
            return (contador == 0);
        }

        public static bool operator ==(Producto producto1, Producto producto2)
        {
            if (ReferenceEquals(producto1, producto2))
            {
                return true;
            }

            if (ReferenceEquals(producto1, null) || ReferenceEquals(producto2, null))
            {
                return false;
            }

            return producto1.corteDeCarne == producto2.corteDeCarne;
        }

        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

    }
}
