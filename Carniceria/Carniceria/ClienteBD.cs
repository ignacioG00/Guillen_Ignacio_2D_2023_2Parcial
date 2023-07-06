using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    public class ClienteBD : ICarniceriaCRUD<Cliente>
    {
        private string stringConexion;
        private SqlCommand comando;
        private SqlConnection conexion;
        private SqlDataReader dataReader;

        public ClienteBD()
        {
            stringConexion = @"Data Source = URIEL;
                    Database = Carniceria_DB;
                    Trusted_Connection = True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(stringConexion);
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        public List<Cliente> LeerArchivos()
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT  c.MAIL, c.NOMBRE, c.CONTRASEÑA, c.MONTOMAX " +
                    "FROM CLIENTE AS c ";

                using (dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        clientes.Add(new Cliente(
                        Convert.ToDecimal(dataReader["MONTOMAX"]),
                        new List<Producto>(),
                        dataReader["NOMBRE"].ToString(),
                        dataReader["MAIL"].ToString(),
                        dataReader["CONTRASEÑA"].ToString()
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                List<Exception> innerExceptions = new List<Exception>();
                if (ex is SqlException ||
                    ex is InvalidOperationException ||
                    ex is SqlNullValueException)
                {
                    innerExceptions.Add(ex);
                }

                if (innerExceptions.Count > 0)
                {
                    throw new BDExcepciones("Hubo un error al leer la tabla de clientes.", innerExceptions);
                }
            }
            finally
            {
                conexion.Close();
            }

            return clientes;
        }

        //public Cliente BuscarPorEmailYContraseña(string email, string contraseña)
        //{
        //    Cliente cli;

        //    try
        //    {
        //        comando.Parameters.Clear();
        //        conexion.Open();
        //        comando.CommandText = $"SELECT * FROM CLIENTE,VENDEDOR WHERE MAIL = '{email}' AND CONTRASEÑA = '{contraseña}'";
                
        //        cli = new Cliente(
        //        Convert.ToDecimal(dataReader["MONTOMAX"]),
        //        new List<Producto>(),
        //        dataReader["NOMBRE"].ToString(),
        //        dataReader["MAIL"].ToString(),
        //        dataReader["CONTRASEÑA"].ToString()
        //        );
                
        //    }
        //    catch (Exception ex)
        //    {
        //        List<Exception> innerExceptions = new List<Exception>();
        //        if (ex is SqlException ||
        //            ex is InvalidOperationException ||
        //            ex is SqlNullValueException)
        //        {
        //            innerExceptions.Add(ex);
        //        }

        //        if (innerExceptions.Count > 0)
        //        {
        //            throw new BDExcepciones("Hubo un error al leer la tabla de usuarios.", innerExceptions);
        //        }
        //    }
        //    finally
        //    {
        //        conexion.Close();

        //    }
        //    return cli;

        //}

        public void ModificarArchivos(Cliente usuario)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE CLIENTE SET MONTOMAX = @DINERO WHERE CLIENTE.MAIL = '{usuario.Mail}'";
                comando.Parameters.AddWithValue("@DINERO", usuario.MontoMax);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                List<Exception> innerExceptions = new List<Exception>();
                if (ex is SqlException ||
                    ex is InvalidOperationException ||
                    ex is SqlNullValueException)
                {
                    innerExceptions.Add(ex);
                }

                if (innerExceptions.Count > 0)
                {
                    throw new BDExcepciones("Hubo un error al modificar la tabla de clientes.", innerExceptions);
                }
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
