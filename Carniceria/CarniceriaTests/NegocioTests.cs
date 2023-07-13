using Microsoft.VisualStudio.TestTools.UnitTesting;
using Carniceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria.Tests
{
    [TestClass()]
    public class NegocioTests
    {
        [TestMethod]
        public void TestBuscarClientes()
        {
            List<Cliente> clientes;
            ClienteBD bdClientes = new ClienteBD();

            clientes = bdClientes.LeerCRUD();

            Assert.AreNotEqual(clientes.Count, 0);
        }

        [TestMethod]
        public void TestLogin()
        {
            Usuario useraux; 
            ClienteBD bdClientes = new ClienteBD();
            VendedorBD bdVendedores = new VendedorBD();

            Negocio.Clientes = bdClientes.LeerCRUD();
            Negocio.Vendedores = bdVendedores.LeerCRUD();
            useraux =Negocio.LoguearUsuario("123!#$!$%", "....,.-.");
            Assert.IsNull(useraux);
        }

        [TestMethod]
        public void TestReponerProducto() 
        {
            List<Producto> listaux = Negocio.Heladera;
            Producto producto = listaux[0];
            Negocio.ReponerProducto(listaux, listaux[0].CorteDeCarne,300);
            Assert.IsTrue(listaux[0].Stock>300);
        }
    }
}