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
    public class VendedorBD : ICarniceriaCRUD<Vendedor>
    {
        private string stringConexion;
        private SqlCommand comando;
        private SqlConnection conexion;
        private SqlDataReader dataReader;

        public VendedorBD() 
        {
            stringConexion = @"Data Source = URIEL;
                    Database = Carniceria_DB;
                    Trusted_Connection = True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(stringConexion);
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        public List<Vendedor> LeerArchivos()
        {
            List<Vendedor> vendedores = new List<Vendedor>();

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT v.MAIL, v.NOMBRE, v.CONTRASEÑA FROM VENDEDOR AS v ";

                using (dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        vendedores.Add(new Vendedor(
                            dataReader["NOMBRE"].ToString(),
                            dataReader["MAIL"].ToString(),
                            dataReader["CONTRASEÑA"].ToString()));
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
                    throw new BDExcepciones("Hubo un error al leer la tabla de vendedores.", innerExceptions);
                }
            }
            finally
            {
                conexion.Close();
            }

            return vendedores;
        }

        public void ModificarArchivos(Vendedor usuario)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE VENDEDOR SET CONTRASEÑA = @CONTRASEÑA WHERE VENDEDOR.MAIL= {usuario.Mail}";
                comando.Parameters.AddWithValue("@CONTRASEÑA", usuario.Contraseña);
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
                    throw new BDExcepciones("Hubo un error al modificar la tabla de vendedores.", innerExceptions);
                }
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
