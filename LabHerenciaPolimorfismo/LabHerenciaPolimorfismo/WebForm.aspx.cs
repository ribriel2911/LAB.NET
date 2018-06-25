using LabHerenciaPolimorfismo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabHerenciaPolimorfismo
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<Mamifero> mamiferos = new List<Mamifero>(){
                new Gato("gato"),
                new Perro("perro"),
                new Humano("humano"),
                new Ballena("ballena")
            };

            Serpiente serpiente = new Serpiente("serpiente");

            foreach (Mamifero m in mamiferos)
            {
                Response.Write(m.Respirar + "<br />");
                Response.Write(m.Caminar + "<br />");
                Response.Write(m.Hablar + "<br />");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}