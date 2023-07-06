using Carniceria;
using System.Media;

namespace Vista
{
    public partial class Frm_Heladera : Form
    {
        private SoundPlayer sonidoCarne = new SoundPlayer();
        NegocioBD bdNegocio = new NegocioBD();
        public Frm_Heladera()
        {
            InitializeComponent();
        }

        private void Frm_Heladera_Load(object sender, EventArgs e)
        {
            ActualizarListas();
            CargarCarnes();
        }

        /// <summary>
        /// Carga la lista de cortes de carne del objeto Negocio en un ComboBox.
        /// </summary>
        public void CargarCarnes()
        {
            cb_listaCarnes.Items.Clear();
            for (int i = 0; i < Negocio.ListaCarnes.Count; i++)
            {
                cb_listaCarnes.Items.Add(Negocio.ListaCarnes[i].CorteDeCarne);
            }
        }

        /// <summary>
        /// Actualiza la lista de carnes en dgv y en el combobox.
        /// </summary>
        public void ActualizarListas()
        {
            try
            {
                CargarCarnes();
                dgv_listaCarnes.Rows.Clear();
                for (int i = 0; i < Negocio.Heladera.Count; i++)
                {
                    int n = dgv_listaCarnes.Rows.Add();

                    dgv_listaCarnes.Rows[n].Cells[0].Value = Negocio.Heladera[i].CorteDeCarne;
                    dgv_listaCarnes.Rows[n].Cells[1].Value = Negocio.Heladera[i].Stock;
                    dgv_listaCarnes.Rows[n].Cells[2].Value = Negocio.Heladera[i].PrecioPorKilo;
                }
                foreach (var carnes in Negocio.Heladera)
                {
                    bdNegocio.ModificarArchivos(carnes);
                }
                MessageBox.Show("STOCK DE CARNES CARGADOS CORRECTAMENTE!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (BDExcepciones ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_actualizarLista_Click(object sender, EventArgs e)
        {
            sonidoCarne.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\correct.wav";
            sonidoCarne.Play();
            ActualizarListas();
        }

        private void btn_fijarPrecioxKilo_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < Negocio.Heladera.Count; i++)
            {
                if (cb_listaCarnes.Text == Negocio.Heladera[i].CorteDeCarne)
                {
                    if (decimal.TryParse(tb_fijarPrecio.Text, out decimal result))
                    {
                        sonidoCarne.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\caja.wav";
                        sonidoCarne.Play();
                        Negocio.Heladera[i].PrecioPorKilo = result;
                        ActualizarListas();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un valor numérico válido");
                        sonidoCarne.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                        sonidoCarne.Play();
                    }
                }
                
            }

        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_nuevoProducto_Click(object sender, EventArgs e)
        {
            
            if (Producto.CorteNoExistente(Negocio.Heladera, tb_nombreCorte.Text))
            {
                if (decimal.TryParse(tb_precioxkilo.Text, out decimal result))
                {
                    sonidoCarne.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\correct.wav";
                    sonidoCarne.Play();
                    Negocio.Heladera.Add(new Producto(result, 0, tb_nombreCorte.Text));
                    ActualizarListas();
                    CargarCarnes();
                }
                else
                {
                    sonidoCarne.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                    sonidoCarne.Play();
                    MessageBox.Show("Ingrese un valor numérico válido");
                }
            }
        }

        private void btn_reponerCarnes_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(tb_cantAReponer.Text, out decimal result))
            {
                sonidoCarne.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\vaca.wav";
                sonidoCarne.Play();
                Negocio.ReponerProducto(Negocio.Heladera, cb_listaCarnes.Text, result);
                ActualizarListas();
            }
            else
            {
                sonidoCarne.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                sonidoCarne.Play();
                MessageBox.Show("Ingrese un valor numérico válido");
            }
        }

        private void tb_precioxkilo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_cantAReponer_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_fijarPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
