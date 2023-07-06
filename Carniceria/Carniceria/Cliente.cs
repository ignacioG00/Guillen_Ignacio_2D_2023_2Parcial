using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Carniceria
{
     public class Cliente : Usuario
    {
        decimal montoMax;
        List<Producto> productosComprados = new();

        public Cliente(decimal montoMax, List<Producto> productosComprados, string nombre, string mail, string contraseña) : base(nombre, mail, contraseña)
        {
            this.MontoMax = montoMax;
            this.ProductosComprados = productosComprados;
        }

        public decimal MontoMax { get => montoMax; set => montoMax = value; }
        public List<Producto> ProductosComprados { get => productosComprados; set => productosComprados = value; }

        public static Cliente RetornarCliente(string mail, List<Cliente> listaClientes) 
        {
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (mail == listaClientes[i].Mail)
                {
                    return listaClientes[i];
                }
            }
            return null;
        }

        public override bool ComprobarContra(string datoIngresado)
        {
            return (!string.IsNullOrEmpty(datoIngresado) && datoIngresado.Trim() == Contraseña.Trim());
        }

        // Serializar la clase en formato JSON
        public string Serializar()
        {
            return JsonSerializer.Serialize(this);
        }

        // Deserializar una cadena JSON en una instancia de la clase
        public static Cliente Deserializar(string jsonString)
        {
            return JsonSerializer.Deserialize<Cliente>(jsonString);
        }
    }
}
