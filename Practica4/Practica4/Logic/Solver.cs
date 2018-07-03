using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Practica4.Logic
{
    public class Solver {

        String exepcion;
        String resultado;
        static String path = WebConfigurationManager.AppSettings["Exeptions"];

        public Solver()
        {
            exepcion = "";
            resultado = "";
        }

        public void StringDivision(String dividendo, String divisor)
        {

            try
            {
                int x = int.Parse(dividendo);
                int y = int.Parse(divisor);

                Double val = Dividir(x, y);

                resultado = "" + val;
            }

            catch (DivideByZeroException e)
            {
                exepcion = "Solo Mascherano y Chuck Norris dividen por cero! " + e.Message;
                guardarExcepcion(e);
            }

            catch (FormatException e)
            {
                exepcion = "Seguro ingreso una letra o no ingreso nada!";
                guardarExcepcion(e);
            }
        }

        public static String CeroDivision()
        {
            String ret;

            try
            {
                Double val = Dividir(5, 0);

                ret = "" + val;
            }

            catch (DivideByZeroException e)
            {
                guardarExcepcion(e);
                return e.Message;
            }

            return ret;
        }

        public static Double Dividir(int dividendo, int divisor)
        {

            if (divisor == 0)
            {
                throw new System.DivideByZeroException();
            }

            return dividendo / divisor;
        }

        public static void LanzaExcepcion()
        {
            throw new Models.UltraExcepcion("Generada Automaticamente"); 
        }

        public static void guardarExcepcion(Exception e)
        {
            System.IO.File.AppendAllText(path, e.StackTrace);
        }

        public String Exepcion => exepcion;
        public String Resultado => resultado;
    }
}