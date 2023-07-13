using Carniceria;
using System.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Vista
{
    public partial class Frm_Compra : Form
    {
        private DateTime reloj;
        decimal cuenta = 0;
        decimal total = 0;
        decimal kilosLlevados = 0;
        Producto producto;
        int contadorFacturas=0;
        public Usuario userAux;
        NegocioBD bdNegocio = new NegocioBD();
        ClienteBD bdClientes = new ClienteBD();
        CancellationTokenSource cancellationTokenHora= new CancellationTokenSource();
        private SoundPlayer sonidoCompra = new SoundPlayer();


        static List<Producto> listAux = new List<Producto>();
        private void CargarLista() 
        {
            foreach (Producto item in Negocio.Heladera)
            {
                listAux.Add(new Producto (item.PrecioPorKilo,0,item.CorteDeCarne));
            }
        }
        

        public Frm_Compra()
        {
            InitializeComponent();
            ActualizarListas();
            LimpiarVentana();
            CargarLista();
            CargarCarnes();
            producto = new Producto();
            
            cb_tipoPago.DataSource = Enum.GetValues(typeof(Negocio.TipoPago));
        }

        public void MostrarStockLleno(object producto, GetInfoCorte info)
        {
            MessageBox.Show($"Se ha rellenado el stock del producto {info.CorteCarne}.");
        }


        private List<Producto> RetornarCopiaListAux(List<Producto> productos) 
        {
            List<Producto> listCopia = new List<Producto>();
            foreach (var item in productos)
            {
                if (item.Stock>0)
                {
                    Producto nuevoProducto = new Producto(item.PrecioPorKilo, item.Stock, item.CorteDeCarne);
                    listCopia.Add(nuevoProducto);
                }
            }
            return listCopia;
        }
        private void Frm_Compra_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Negocio.Clientes.Count; i++)
            {
                cb_listaClientes.Items.Add(Negocio.Clientes[i].Mail);
            }
            lb_cartel.Text = userAux.Nombre.Cartel();
            producto.StockBajo += MostrarStockLleno;
            CargarCarnes();
            TareaReloj();
            
        }

        private void btn_anotarPedido_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("DESEA AGREGAR EL PRODUCTO?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\correct.wav";
                sonidoCompra.Play();
                HacerPedido();
            }
            else
            {
                sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                sonidoCompra.Play();
                MessageBox.Show("PEDIDO NO CARGADO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_anularCompra_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("DESEA BORRAR LA LISTA DE VENTAS? SE BORRARAN LOS PEDIDOS DETALLADOS", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes && total > 0)
            {
                AnularPedidos();
            }
            else
            {
                sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                sonidoCompra.Play();
                MessageBox.Show("ERROR. NO HAY PEDIDOS CREADOS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_actualizarLista_Click(object sender, EventArgs e)
        {
            sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\correct.wav";
            sonidoCompra.Play();
            ActualizarListas();
        }

        private void btn_realizarPago_Click(object sender, EventArgs e)
        {
            Cliente clienteAux;

            if (string.IsNullOrEmpty(tb_montoMax.Text) || decimal.Parse(tb_montoMax.Text) < 0)
            {
                sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                sonidoCompra.Play();
                MessageBox.Show("COLOQUE MONTO VALIDO PARA REALIZAR COMPRA (debe ser un numero mayor a 0)!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Negocio.SelectorUsuario(userAux.Mail) == "vendedor")
            {
                if (string.IsNullOrEmpty(cb_listaClientes.Text))
                {
                    sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                    sonidoCompra.Play();
                    MessageBox.Show("ERROR.ELIJA UN CLIENTE!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                clienteAux = Cliente.RetornarCliente(cb_listaClientes.Text, Negocio.Clientes);
            }
            else
            {
                clienteAux = Cliente.RetornarCliente(userAux.Mail, Negocio.Clientes);
            }
            clienteAux.MontoMax = decimal.Parse(tb_montoMax.Text);
            decimal totalConRecargo = total * (decimal)1.05;

            DialogResult resultado = MessageBox.Show("DESEA REALIZAR EL PAGO? \n" + rtb_cuenta.Text +
                "\nSi eligio credito tendra un 5% de recargo.\n" +
                "Total c/credito: $" + totalConRecargo + " / " +
                "Total s/credito: $" + total +
                "\n Saldo de " + clienteAux.Nombre +
                ": $" + clienteAux.MontoMax
                , "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes && total > 0 && clienteAux.MontoMax > total)
            {
                sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\caja.wav";
                sonidoCompra.Play();
                clienteAux.ProductosComprados = RetornarCopiaListAux(listAux);
                if (cb_tipoPago.Text == "Credito")
                {
                    clienteAux.MontoMax -= totalConRecargo;
                    RealizarPago(clienteAux, totalConRecargo);
                    try
                    {
                        DialogResult res = MessageBox.Show("DESEA RELLENAR STOCK?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (res == DialogResult.Yes)
                        {
                            producto.RellenarStock();
                        }
                        ActualizarListas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
                else
                {
                    RealizarPago(clienteAux, total);
                    try
                    {
                        DialogResult res = MessageBox.Show("DESEA RELLENAR STOCK?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (res == DialogResult.Yes)
                        {
                            producto.RellenarStock();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
            else
            {
                if (tb_kg.Text == "" || int.Parse(tb_kg.Text) < 1)
                {
                    sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                    sonidoCompra.Play();
                    MessageBox.Show("ERROR NO COLOCO NINGUNA CANTIDAD EN KILOS!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (clienteAux.MontoMax < total)
                {
                    sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                    sonidoCompra.Play();
                    MessageBox.Show("EL MONTO MAXIMO ES MENOR AL DE LA COMPRA, AGREGAR MONTO!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                    sonidoCompra.Play();
                    MessageBox.Show("VENTA NO REALIZADA!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clienteAux.ProductosComprados.Clear();
                }
            }
            VaciarStockComprado();
        }
        private void cb_tipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipoPago.Text == "credito")
            {
                lb_total.Text = "total: " + (total * (decimal)1.05) + " PESOS";
            }
            else
            {
                lb_total.Text = "total: " + total + " PESOS";
            }
        }

        private void btn_historial_Click(object sender, EventArgs e)
        {
            sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\correct.wav";
            sonidoCompra.Play();
            Frm_Historial historial = new Frm_Historial();
            historial.Show();
        }

        private void btn_limpiarRtb_Click(object sender, EventArgs e)
        {
            sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\correct.wav";
            sonidoCompra.Play();
            rtb_cuenta.Clear();
        }

        private void Frm_Compra_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Frm_Compra_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            cancellationTokenHora.Cancel();
            cancellationTokenHora.Dispose();
        }

        static void VaciarStockComprado()
        {
            for (int i = 0; i < listAux.Count; i++)
            {
                listAux[i].Stock = 0;
            }
        }

        /// <summary>
        /// Realiza el pago de la compra realizada por un cliente y descuenta su monto máximo disponible.
        /// </summary>
        /// <param name="cliente">El objeto cliente que realizó la compra.</param>
        /// <param name="montoACobrar">El monto total a cobrar por la compra.</param>
        private void RealizarPago(Cliente cliente, decimal montoACobrar)
        {
            cliente.MontoMax -= total;
            string factura = "* FACTURA DE LA COMPRA * \n";
            for (int i = 0; i < cliente.ProductosComprados.Count; i++)
            {
                if (cliente.ProductosComprados[i].Stock > 0)
                {
                    factura += cliente.ProductosComprados[i].CorteDeCarne.ToString() + " " + cliente.ProductosComprados[i].Stock + "\n";
                }
            }

            Factura facturaAux = new Factura(cliente.Nombre, userAux.Nombre, cliente.ProductosComprados, montoACobrar, contadorFacturas++,cb_tipoPago.Text);
            Negocio.ListFacturaAux.Add(facturaAux);
            MessageBox.Show(factura, "COMPRA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarVentana();

            total = 0;
            cuenta = 0;
        }
        /// <summary>
        /// Método para anular los pedidos realizados por el cliente.
        /// Este método limpia la cuenta del cliente y el total a cobrar, y recorre los productos comprados por el cliente para cargarles los productos que compro.
        /// </summary>
        private void AnularPedidos()
        {
            rtb_cuenta.Clear();
            lb_total.Text = "total: ";
            cuenta = 0;
            total = 0;
            foreach (var item in Negocio.Heladera)
            {
                for (int i = 0; i < listAux.Count; i++)
                {
                    if (item == listAux[i])
                    {
                        item.Stock += listAux[i].Stock;
                        listAux[i].Stock = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Hace un pedido de carne según los elementos seleccionados en CheckedListBox y la cantidad ingresada en el TextBox de kilos.
        /// Actualiza el stock de la carne seleccionada y la cuenta total del pedido.
        /// </summary>
        private void HacerPedido()
        {
            if (!string.IsNullOrEmpty(tb_kg.Text))
            {
                if (decimal.TryParse(tb_kg.Text, out decimal result))
                {
                    kilosLlevados += result;
                }
                else
                {
                    sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                    sonidoCompra.Play();
                    MessageBox.Show("ERROR. ELIJE UNA CANTIDAD VALIDA!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (var item in clb_carnes.CheckedItems)
                {
                    for (int i = 0; i < Negocio.Heladera.Count; i++)
                    {
                        if (item.ToString() == Negocio.Heladera[i].CorteDeCarne)
                        {
                            if (Negocio.Heladera[i].Stock > int.Parse(tb_kg.Text))
                            {
                                listAux[i].Stock += kilosLlevados;
                                cuenta = Negocio.Heladera[i].PrecioPorKilo * Decimal.Parse(tb_kg.Text);
                                Negocio.QuitarProducto(Negocio.Heladera, Negocio.Heladera[i].CorteDeCarne, kilosLlevados);
                                total += cuenta;
                                rtb_cuenta.AppendText(item.ToString() + " " + kilosLlevados + " kg" + "\n");
                            }
                            else
                            {
                                sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                                sonidoCompra.Play();
                                MessageBox.Show($"ERROR. NO HAY STOCK DE: {item}!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                        }
                    }
                    rtb_cuenta.AppendText(cuenta + "\n");
                }
                kilosLlevados = 0;
                lb_total.Text = "total: " + total + " PESOS";
                ActualizarListas();
            }
            else
            {
                sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                sonidoCompra.Play();
                MessageBox.Show("ERROR NO COLOCO NINGUNA CANTIDAD EN KILOS!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Actualiza la lista del datagriedview y recarga el combolistbox en caso de añadirse un nuevo producto.
        /// </summary>
        public void ActualizarListas()
        {
            sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\correct.wav";
            sonidoCompra.Play();
            try
            {
                foreach (var carne in Negocio.Heladera)
                {
                    bdNegocio.ModificarCRUD(carne);
                    if (carne.Stock<3)
                    {
                        
                            carne.RellenarStock();
                        
                    }
                }
                dgv_listaCarnes.Rows.Clear();
                for (int i = 0; i < Negocio.Heladera.Count; i++)
                {
                    int n = dgv_listaCarnes.Rows.Add();

                    dgv_listaCarnes.Rows[n].Cells[0].Value = Negocio.Heladera[i].CorteDeCarne;
                    dgv_listaCarnes.Rows[n].Cells[1].Value = Negocio.Heladera[i].Stock;
                    dgv_listaCarnes.Rows[n].Cells[2].Value = Negocio.Heladera[i].PrecioPorKilo;
                }
                
                CargarCarnes();
                MessageBox.Show("STOCK DE CARNES CARGADOS CORRECTAMENTE!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (BDExcepciones ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CargarCarnes()
        {
            /// <summary>
            /// Carga la lista de cortes de carne del objeto Negocio en un ComboListBox.
            /// </summary>
            /// 
            Negocio.Heladera = bdNegocio.LeerCRUD();
            clb_carnes.Items.Clear();
            for (int i = 0; i < Negocio.Heladera.Count; i++)
            {
                clb_carnes.Items.Add(Negocio.Heladera[i].CorteDeCarne);
            }
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var carnes in Negocio.Heladera)
                {
                    bdNegocio.ModificarCRUD(carnes);
                    
                }
                foreach (var clientes in Negocio.Clientes)
                {
                    bdClientes.ModificarCRUD(clientes);
                }
            }
            catch (BDExcepciones ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();

        }

        private void tb_montoMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // solo permitir un punto decimal
            if ((e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_kg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // solo permitir un punto decimal
            if ((e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void TareaReloj()
        {
            try
            {
                Task.Run(() => ActualizarReloj());
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ejecutar la tarea Reloj.");
            }
        }

        private void ActualizarReloj()
        {
            try
            {
                while (!cancellationTokenHora.IsCancellationRequested)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        lb_reloj.Text = reloj.FormatearFecha();
                    });
                    Thread.Sleep(1000);
                }
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("Error al ejecutar la tarea Reloj.");
            }
        }

        private void LimpiarVentana()
        {
            tb_kg.Text = "";
            tb_montoMax.Text = "";
            rtb_cuenta.Text = "";
            lb_total.Text = "Total: ";
        }
        private void btn_serializar_Click(object sender, EventArgs e)
        {
            try
            {
                ArchivosCarniceria.SerializarProductosXml(listAux);
            }
            catch (ArchivosExcepciones ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_deserializar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(ArchivosCarniceria.DeserializarProductosXml(), "Productos serializados en XMl", MessageBoxButtons.OK);
            }
            catch (ArchivosExcepciones ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_deserialJson_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(ArchivosCarniceria.DeserializarProductosJson(), "Productos serializados en JSON", MessageBoxButtons.OK);
            }
            catch (ArchivosExcepciones ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_serialJson_Click(object sender, EventArgs e)
        {
            try
            {
                ArchivosCarniceria.SerializarProductosJson(Negocio.ListaCarnes);
            }
            catch (ArchivosExcepciones ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
