using Practica4.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica4.Interface
{
    public partial class Exepcion3 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Solver.CeroDivision();

            TextBox1.Text = "Se guardo una nueva excepcion en: "+ WebConfigurationManager.AppSettings["Exeptions"];
        }
    }
}