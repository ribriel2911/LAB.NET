using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Practica3.Mechanics { 

    public class Solver {

        DateTime time;
        List<int> nums;
        Random azar;
        int numero;
        int intentos;

        public Solver()
        {
            nums = new List<int>();
            azar = new Random();
            numero = azar.Next(51);
            intentos = 5;
            time = DateTime.Today;
        }

        public void Add(int n)
        {
            nums.Add(n);
        }

        public void Clear()
        {
            nums = new List<int>();
        }

        public void Pensar()
        {
            numero = azar.Next(51);
            intentos = 5;
        }

        public String Adivinar(int n)
        {
            if(intentos==-1) { return "Ganaste!!!"; }
            if(intentos==0) { return "Lo siento se agotaron los intentos..."; }

            intentos--;

            if (n<numero) { return "Lo siento el numero es mayor a ese"; }
            if (n>numero) { return "Lo siento el numero es menor a ese"; }

            intentos = -1;
            return "Ganaste!!!";

        }

        public static int SumarEnteros {

            get {

                int ret = 0;

                for (int i=1; i<=10; i++) {

                    ret += i;
                }

                return ret;
            }
        }

        private static Boolean EsMultiplo(int n, int m)
        {
            return n % m == 0;
        }

        public static String MultiploDeCinco(int n)
        {
            if (EsMultiplo(n, 5)) { return "El numero " + n + " es multiplo de 5"; }

            return "El numero " + n + " NO es multiplo de 5"; 
        }

        public String CalcularDado()
        {
            int uno = 0;
            int dos = 0;
            int tre = 0;
            int otr = 0;

            int i = 0;
            while (i < 50)
            {
                int num = 1 + azar.Next(6);

                switch (num)
                {
                    case 1: uno++; break;
                    case 2: dos++; break;
                    case 3: tre++; break;
                    default: otr++; break;
                }

                i++;
            }

            return  "Probabilidad de tirar 1: " + uno * 2 + "%\r\n" +
                    "Probabilidad de tirar 2: " + dos * 2 + "%\r\n" +
                    "Probabilidad de tirar 3: " + tre * 2 + "%\r\n" + 
                    "Probabilidad de tirar otro: " + otr * 2 + "%";
        }

        public String EvaluarNumeros()
        {
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            foreach (int n in nums){

                if (n < 0) { negativos++; }
                else {
                    if (n > 0) { positivos++; }
                    else { ceros++; }
                }
            }

            return "Positivos: " + positivos +
                   "\r\nNegativos: " + negativos +
                   "\r\nCeros: " + ceros +
                   "\r\nSobre " + nums.Count + " numeros ingresados.";
        }

        public String DiaDeMañana()
        {
            return time.AddDays(1).ToString("D");
        }
    }
}