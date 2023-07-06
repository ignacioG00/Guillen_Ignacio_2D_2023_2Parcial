using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    public class Factura
    {
        int idFactura;
        string nombreCliente;
        string nombreVendedor;
        string productosVendidosStr;
        List<Producto> productosVendidos;
        decimal montoVenta;
        private string metodoDePago;

        public Factura(string nombreCliente, string nombreVendedor, List<Producto> productosVendidos, decimal montoVenta, int idFactura,string metodoDePago)
        {
            this.NombreCliente = nombreCliente;
            this.NombreVendedor = nombreVendedor;
            this.ProductosVendidos = productosVendidos;
            this.MontoVenta = montoVenta;
            this.IdFactura = idFactura;
            this.MetodoDePago = metodoDePago;
        }

        public Factura(string nombreCliente, string nombreVendedor, string productosVendidosStr, decimal montoVenta, int idFactura) 
        {
            this.NombreCliente = nombreCliente;
            this.NombreVendedor = nombreVendedor;
            this.ProductosVendidosStr = productosVendidosStr;
            this.MontoVenta = montoVenta;
            this.IdFactura = idFactura;
        }

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string NombreVendedor { get => nombreVendedor; set => nombreVendedor = value; }
        public List<Producto> ProductosVendidos { get => productosVendidos; set => productosVendidos = value; }
        public decimal MontoVenta { get => montoVenta; set => montoVenta = value; }
        public int IdFactura { get => idFactura; set => idFactura = value; }
        public string ProductosVendidosStr { get => productosVendidosStr; set => productosVendidosStr = value; }
        public string MetodoDePago { get => metodoDePago; set => metodoDePago = value; }
    }
}
