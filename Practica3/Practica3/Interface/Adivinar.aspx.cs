﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica3.Interface
{
    public partial class Adivinar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Main.solver.Pensar();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = Main.solver.Adivinar(int.Parse(TextBox1.Text));
            TextBox1.Text = "";
        }
    }
}