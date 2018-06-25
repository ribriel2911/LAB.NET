using Practica3.Interface;
using Practica3.Mechanics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica3
{
    public partial class Positivos : System.Web.UI.Page
    {

        Solver solver = Main.solver;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            solver.Clear();

            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            solver.Add(int.Parse(TextBox1.Text));
            TextBox2.Text = "Se ingreso: " + int.Parse(TextBox1.Text);
            TextBox1.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox2.Text = solver.EvaluarNumeros();
        }
    }
}