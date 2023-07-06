using Carniceria;
using System.Data;
using System.Media;
using System.Numerics;

namespace Vista
{
    public partial class Frm_Login : Form
    {
        Frm_Heladera heladera = new Frm_Heladera();
        Frm_Compra compras = new Frm_Compra();
        Usuario userAux;
        private ClienteBD clientesCRUD;
        private VendedorBD vendedoresCRUD;
        private SoundPlayer sonidoLogin= new SoundPlayer();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Negocio.Clientes = clientesCRUD.LeerArchivos();
            Negocio.Vendedores = vendedoresCRUD.LeerArchivos();
            ValidarIngreso(tb_usuario.Text, tb_contra.Text);
            if (userAux is not null)
            {
                sonidoLogin.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\correct.wav";
                sonidoLogin.Play();
                if (Negocio.Vendedores.Find(v => v.Mail == tb_usuario.Text && v.Contraseña == tb_contra.Text) is not null)
                {
                    compras.userAux = (Vendedor)userAux;
                    heladera.BackColor = Color.RosyBrown;
                    heladera.Show();
                    compras.BackColor = Color.RosyBrown;
                    compras.cb_listaClientes.Show();
                    compras.btn_historial.Show();
                    compras.lb_venderA.Text = "Vender a:";
                    compras.Show();
                }
                else
                if (Negocio.Clientes.Find(c => c.Mail == tb_usuario.Text && c.Contraseña == tb_contra.Text) is not null)
                {
                    compras.userAux = (Cliente)userAux;
                    compras.cb_listaClientes.Hide();
                    compras.btn_historial.Hide();
                    compras.lb_venderA.Text = "Cliente Actual: " + userAux.Nombre;
                    MessageBox.Show("INGRESE MONTO A GASTAR PARA PODER REALIZAR LA COMPRA.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    compras.BackColor = Color.LightGreen;

                    compras.Show();

                }
            }
        }
        private void btn_autoVendedor_Click(object sender, EventArgs e)
        {
            tb_usuario.Text = "lucas@gmail.com";
            tb_contra.Text = "1234";
        }

        private void btn_autoCliente_Click(object sender, EventArgs e)
        {
            tb_usuario.Text = "romualdo@gmail.com";
            tb_contra.Text = "ric123";
        }

        public void ValidarIngreso(string email, string contra)
        {
            if (String.IsNullOrEmpty(email))
            {
                sonidoLogin.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                sonidoLogin.Play();
                MessageBox.Show("ERROR. ESCRIBA EL USUARIO!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userAux = null;
            }
            else if (String.IsNullOrEmpty(contra))
            {
                sonidoLogin.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                sonidoLogin.Play();
                MessageBox.Show("ERROR. ESCRIBA CONTRASEÑA!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userAux = null;

            }
            else if (Negocio.LoguearUsuario(email, contra) is null)
            {
                sonidoLogin.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                sonidoLogin.Play();
                MessageBox.Show("ERROR. EL USUARIO NO EXISTE!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userAux = null;
            }
            else
            {
                sonidoLogin.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                sonidoLogin.Play();
                userAux = Negocio.LoguearUsuario(email, contra);
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            clientesCRUD = new ClienteBD();
            vendedoresCRUD = new VendedorBD();
        }
    }
}