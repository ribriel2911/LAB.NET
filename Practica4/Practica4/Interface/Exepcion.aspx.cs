using Practica4.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica4.Interface
{
    public partial class Exepcion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NewMethod1();
        }

        private void NewMethod1()
        {
            try
            {
                Solver.Dividir(3, 0);
            }

            catch (DivideByZeroException e)
            {
                TextBox1.Text = e.Message +" "+ e.GetType().Name;
            }
        }
    }
}