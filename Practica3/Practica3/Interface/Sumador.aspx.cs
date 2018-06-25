using Practica3.Mechanics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica3
{
    public partial class Sumador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sumar_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Solver.SumarEnteros.ToString();
        }

        protected void Limpiar_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }
    }
}