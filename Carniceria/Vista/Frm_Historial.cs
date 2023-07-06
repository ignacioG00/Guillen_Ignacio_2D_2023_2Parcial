using Carniceria;
using System.IO;
using System.Security;

namespace Vista
{
    public partial class Frm_Historial : Form
    {
        StreamWriter streamWriter;
        public Frm_Historial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarListas();
        }

        public void ActualizarListas()
        {
            dgv_histFacturas.Rows.Clear();
            for (int i = 0; i < Negocio.ListFacturaAux.Count; i++)
            {
                int n = dgv_histFacturas.Rows.Add();

                dgv_histFacturas.Rows[n].Cells[0].Value = Negocio.ListFacturaAux[i].NombreVendedor;
                dgv_histFacturas.Rows[n].Cells[1].Value = Negocio.ListFacturaAux[i].NombreCliente;
                for (int j = 0; j < Negocio.ListFacturaAux[i].ProductosVendidos.Count; j++)
                {
                    if (Negocio.ListFacturaAux[i].ProductosVendidos[j].Stock > 0)
                    {
                        dgv_histFacturas.Rows[n].Cells[2].Value += Negocio.ListFacturaAux[i].ProductosVendidos[j].CorteDeCarne + " " + Negocio.ListFacturaAux[i].ProductosVendidos[j].Stock + "kg \n";
                    }
                }
                dgv_histFacturas.Rows[n].Cells[3].Value = Negocio.ListFacturaAux[i].MontoVenta;

            }
        }

        public void GuardarFacturasTxt()
        {
            int cont = 0;
            string rutaArchivo = $@"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Historial\historial_Factura0.txt";
            if (Negocio.ListFacturaAux.Count>0)
            {
                foreach (var factura in Negocio.ListFacturaAux)
                {
                    if (!File.Exists(rutaArchivo))
                    {
                        using (StreamWriter texto = new StreamWriter(rutaArchivo))
                        {
                            texto.WriteLine("Número de factura: " + 0);
                            texto.WriteLine("Fecha: " + DateTime.Today.ToString("dd/MM/yyyy"));
                            texto.WriteLine("Vendido por: " + factura.NombreVendedor);
                            texto.WriteLine("Cliente: " + factura.NombreCliente);
                            foreach (var producto in factura.ProductosVendidos)
                            {
                                texto.WriteLine($"Producto: {producto.CorteDeCarne} Cantidad: {producto.Stock} Precio: {producto.PrecioPorKilo * producto.Stock}");
                            }
                            texto.WriteLine("---------------------------------------------------");

                            texto.WriteLine("Total: $" + factura.MontoVenta.ToString("0.00"));
                            texto.WriteLine("---------------------------------------------------");
                        }
                    }
                    else
                    {
                        while (File.Exists(rutaArchivo))
                        {
                            cont++;
                            rutaArchivo = $@"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Historial\historial_Factura{cont}.txt";
                        }
                        using (StreamWriter texto = new StreamWriter(rutaArchivo, true))
                        {
                            texto.WriteLine("----------------------------------------------------");
                            texto.WriteLine("Número de factura: " + cont);
                            texto.WriteLine("Fecha: " + DateTime.Today.ToString("dd/MM/yyyy"));
                            texto.WriteLine("Vendido por: " + factura.NombreVendedor);
                            texto.WriteLine("Cliente: " + factura.NombreCliente);
                            texto.WriteLine("Metodo de pago: " + factura.MetodoDePago);
                            foreach (var producto in factura.ProductosVendidos)
                            {
                                texto.WriteLine($"Producto: {producto.CorteDeCarne} Cantidad: {producto.Stock} Precio: {producto.PrecioPorKilo * producto.Stock}");
                            }
                            texto.WriteLine("---------------------------------------------------");

                            texto.WriteLine("Total: $" + factura.MontoVenta.ToString("0.00"));
                            texto.WriteLine("---------------------------------------------------");
                        }
                        cont = 0;
                    }
                }
            }
        }
    

    /// <summary>
    /// Abre el archivo .txt que contiene la factura segun el nombre.
    /// </summary>
    /// <returns></returns>
    public static void AbrirArchivoFacturas()
    {
        string textoFacturas = string.Empty;
        int cont = 0;
        string rutaArchivo = $@"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Historial\historial_Factura0.txt";

        try
        {
            while (File.Exists(rutaArchivo))
            {
                textoFacturas = File.ReadAllText(rutaArchivo);
                MessageBox.Show(textoFacturas);
                cont++;
                rutaArchivo = $@"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Historial\historial_Factura{cont}.txt";
            }
            cont = 0;
        }
        catch (Exception ex)
        {
            List<Exception> innerExceptions = new List<Exception>();
            if (ex is InvalidOperationException ||
                ex is PathTooLongException ||
                ex is SecurityException ||
                ex is IOException)
            {
                innerExceptions.Add(ex);
            }

            if (innerExceptions.Count > 0)
            {
                throw new ArchivosExcepciones("Hubo un error al cargar las facturas.", innerExceptions);
            }
        }
        finally
        {
            if (textoFacturas == string.Empty)
            {
                textoFacturas = "Aún no se ha realizado ninguna venta";
            }
        }
    }
        private void Frm_Historial_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btn_GuardarFacturas_Click(object sender, EventArgs e)
        {
            GuardarFacturasTxt();
        }

        private void btn_verFacturas_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirArchivoFacturas();
                Negocio.ListFacturaAux.Clear();
            }
            catch (ArchivosExcepciones ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
