using Practica3.Mechanics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica3.Interface
{
    public partial class Multiplo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = Solver.MultiploDeCinco(int.Parse(TextBox1.Text));
        }
    }
}