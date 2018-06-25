using System;

namespace EjercicioTransporte
{
    public static class Fecha
    {
        public static String FormatearExtension(this DateTime datetime)
        {
            return datetime.ToString("dd-MM-yy");
        }

        public static String Formatear(DateTime datetime)
        {
            return datetime.ToString("dd-MM-yy");
            //return datetime.FormatearExtension();
        }

        public static String Formatear(DateTime? datetime)
        {
            if (datetime.HasValue)
                return datetime.Value.ToString("dd-MM-yy");

            return "Hola";

            //return datetime.FormatearExtension();
        }
    }
}
