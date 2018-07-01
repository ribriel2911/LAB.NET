using LabHerenciaPolimorfismo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabHerenciaPolimorfismo
{
    public partial class Practica1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Mamifero> mamiferos = new List<Mamifero>();

            mamiferos.Add(new Gato("Gato"));
            mamiferos.Add(new Humano("Humano"));
            mamiferos.Add(new Perro("Perro"));

            foreach(Mamifero m in mamiferos)
            {
                Response.Write(m.Respirar + "<br>" + m.Caminar + "<br>" + m.Hablar + "<br><br>");
            }
        }
    }
}