using Practica4.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica4.Interface
{
    public partial class Division : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Solver solver = new Solver();

            solver.StringDivision(TextBox1.Text, TextBox2.Text);

            TextBox3.Text = solver.Resultado;
            TextBox4.Text = solver.Exepcion;
        }
    }
}