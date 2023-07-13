using System.Reflection;

namespace Carniceria
{
    public static class StringExtensiones
    {
        public static string PrimerLetraMayus(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public static string Cartel(this string input)
        {
            return "Usuario :" + input.PrimerLetraMayus();
        }

        public static string FormatearFecha(this DateTime fecha)
        {
            fecha = DateTime.Now;
            string fechaStr = fecha.ToString("HH:mm:ss");
            return fechaStr;
        }
    }
}
