using Practica4.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica4.Interface
{
    public partial class Exepcion2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NewMethod2();
        }

        private void NewMethod2()
        {
            try
            {
                Solver.LanzaExcepcion();
            }

            catch (Models.UltraExcepcion e)
            {
                TextBox1.Text = e.Message;
            }
        }
    }
}