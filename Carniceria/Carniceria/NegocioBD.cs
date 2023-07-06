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
    public class NegocioBD : ICarniceriaCRUD<Producto>
    {
        private string stringConexion;
        private SqlCommand comando;
        private SqlConnection conexion;
        private SqlDataReader dataReader;

        public NegocioBD()
        {
            stringConexion = @"Data Source = URIEL;
                    Database = Carniceria_DB;
                    Trusted_Connection = True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(stringConexion);
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        public List<Producto> LeerArchivos()
        {
            List<Producto> carnes = new List<Producto>();

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT p.CORTEDECARNE,p.PRECIOXKILO,p.STOCK FROM PRODUCTO AS p";

                using (dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        carnes.Add(new Producto(
                            Convert.ToDecimal(dataReader["PRECIOXKILO"]),
                            Convert.ToInt32(dataReader["STOCK"]),
                            dataReader["CORTEDECARNE"].ToString()));
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
                   throw new BDExcepciones("Hubo un error al leer la tabla de productos.", innerExceptions);
                }
            }
            finally
            {
                conexion.Close();
            }
            return carnes;
        }

        public void Guardar(Producto corte)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO PRODUCTO VALUES (@CORTEDECARNE, @STOCK, @PRECIOXKG)";
                comando.Parameters.AddWithValue("@CORTEDECARNE", corte.CorteDeCarne);
                comando.Parameters.AddWithValue("@STOCK", corte.Stock);
                comando.Parameters.AddWithValue("@PRECIOXKG", corte.PrecioPorKilo);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
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
                   throw new BDExcepciones("Hubo un error al guardar la tabla de productos.", innerExceptions);
                }
            }
            finally
            {
                conexion.Close();
            }
        }

        public void ModificarArchivos(Producto corte)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE PRODUCTO SET  STOCK = @STOCK, PRECIOXKILO = @PRECIOKG WHERE PRODUCTO.CORTEDECARNE = '{corte.CorteDeCarne}'";
                comando.Parameters.AddWithValue("@STOCK", corte.Stock);
                comando.Parameters.AddWithValue("@PRECIOKG", corte.PrecioPorKilo);
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
                  throw new BDExcepciones("Hubo un error al modificar la tabla de productos.", innerExceptions);
                }
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Eliminar(Producto corte)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"DELETE FROM PRODUCTO WHERE PRODUCTO.CORTEDECARNE = {corte.CorteDeCarne}";
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
                 //   throw new BaseDeDatosException("Hubo un error al eliminar un producto de la tabla.", innerExceptions);
                }
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
