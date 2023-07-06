using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Carniceria
{
    public static class ArchivosCarniceria
    {
        static XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Producto>));
        static string jsonString;
        static string archivoXml = "Productos.xml";
        static string archivoJson = "Productos.json";
        static StreamWriter streamWriter;
        static StreamReader streamReader;

   
       

        /// <summary>
        /// Recibe una lista de cortes de carne y los serializa en formato XML, guardándolos en su archivo correspondiente.
        /// </summary>
        /// <param name="productos"></param>
        public static void SerializarProductosXml(List<Producto> productos)
        {
            using (streamWriter = new StreamWriter(archivoXml))
            {
                try
                {
                    xmlSerializer.Serialize(streamWriter, productos);
                }
                catch (Exception ex)
                {
                    List<Exception> innerExceptions = new List<Exception>();
                    if (ex is InvalidOperationException ||
                        ex is PathTooLongException ||
                        ex is SecurityException ||
                        ex is IOException ||
                        ex is SerializationException ||
                        ex is FormatException)
                    {
                        innerExceptions.Add(ex);
                    }

                    if (innerExceptions.Count > 0)
                    {
                        throw new ArchivosExcepciones("Hubo un error al serializar los productos.", innerExceptions);
                    }
                }

            }
        }

        /// <summary>
        /// Lee el archivo de productos XML y los convierte en una nueva lista de productos.
        /// </summary>
        /// <returns></returns>
        public static string DeserializarProductosXml()
        {
            List<Producto>? productos = new List<Producto>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lista de productos deserializada en XML\n");

            try
            {
                using (streamReader = new StreamReader(archivoXml))
                {
                    productos = xmlSerializer.Deserialize(streamReader) as List<Producto>;
                }
            }
            catch (Exception ex)
            {
                List<Exception> innerExceptions = new List<Exception>();
                if (ex is InvalidOperationException ||
                    ex is PathTooLongException ||
                    ex is SecurityException ||
                    ex is IOException ||
                    ex is SerializationException ||
                    ex is FormatException)
                {
                    innerExceptions.Add(ex);
                }

                if (innerExceptions.Count > 0)
                {
                    throw new ArchivosExcepciones("Hubo un error al deserializar los productos.", innerExceptions);
                }
            }
            foreach (Producto carne in productos)
            {
                sb.AppendLine($"Corte: " + carne.CorteDeCarne +  $", Cantidad: {carne.Stock}, Precio por KG: {carne.PrecioPorKilo}");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Recibe una lista de cortes de carne y los serializa en formato JSON, guardándolos en su archivo correspondiente.
        /// </summary>
        /// <param name="productos"></param>
        public static void SerializarProductosJson(List<Producto> productos)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            try
            {
                jsonString = JsonSerializer.Serialize(productos, opciones);

                using (streamWriter = new StreamWriter(archivoJson))
                {
                    streamWriter.Write(jsonString);
                }
            }
            catch (Exception ex)
            {
                List<Exception> innerExceptions = new List<Exception>();
                if (ex is InvalidOperationException ||
                    ex is PathTooLongException ||
                    ex is SecurityException ||
                    ex is IOException ||
                    ex is SerializationException ||
                    ex is FormatException)
                {
                    innerExceptions.Add(ex);
                }

                if (innerExceptions.Count > 0)
                {
                    throw new ArchivosExcepciones("Hubo un error al serializar los productos.", innerExceptions);
                }
            }
        }

        /// <summary>
        /// Lee el archivo de productos JSON y los convierte en una nueva lista de productos.
        /// </summary>
        /// <returns></returns>
        public static string DeserializarProductosJson()
        {
            List<Producto> productos = new List<Producto>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lista de productos deserializada en JSON\n");

            try
            {
                using (streamReader = new StreamReader(archivoJson))
                {
                    productos = JsonSerializer.Deserialize<List<Producto>>(jsonString);
                }
            }
            catch (Exception ex)
            {
                List<Exception> innerExceptions = new List<Exception>();
                if (ex is InvalidOperationException ||
                    ex is PathTooLongException ||
                    ex is SecurityException ||
                    ex is IOException ||
                    ex is SerializationException ||
                    ex is FormatException)
                {
                    innerExceptions.Add(ex);
                }

                if (innerExceptions.Count > 0)
                {
                    throw new ArchivosExcepciones("Hubo un error al deserializar los productos.", innerExceptions);
                }
            }

            foreach (Producto corte in productos)
            {
                sb.AppendLine($"Corte: {corte.CorteDeCarne}, Cantidad: {corte.Stock}, Precio por KG: {corte.PrecioPorKilo}");
            }

            return sb.ToString();
        }
    }
}