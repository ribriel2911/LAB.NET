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
            IEnumerable<Mamifero> mamiferos = new List<Mamifero>(3){
                new Gato("gato"),
                new Perro("perro"),
                new Humano("humano")
            };

            foreach (Mamifero m in mamiferos)
            {
                Response.Write(m.Respirar() + "<br />");
                Response.Write(m.Caminar() + "<br />");
                Response.Write(m.Hablar() + "<br />");
            }
        }
    }
}