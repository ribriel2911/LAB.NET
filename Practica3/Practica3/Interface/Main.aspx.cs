using Practica3.Mechanics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica3.Interface
{
    public partial class Main : System.Web.UI.Page
    {
        public static Solver solver;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            solver = new Solver();
            Server.Execute("Sumador.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            solver = new Solver();
            Server.Execute("Positivos.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            solver = new Solver();
            Server.Execute("Adivinar.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            solver = new Solver();
            Server.Execute("Probabilidad.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            solver = new Solver();
            Server.Execute("Multiplo.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            solver = new Solver();
            Server.Execute("Mañana.aspx");
        }
    }
}