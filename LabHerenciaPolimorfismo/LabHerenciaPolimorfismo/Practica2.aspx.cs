using LabHerenciaPolimorfismo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabHerenciaPolimorfismo
{
    public partial class Practica2 : System.Web.UI.Page
    {

        DataTable table;

        protected void Page_Load(object sender, EventArgs e)
        {
            String[] nombres = { "Gato", "Humano", "Perro", "Serpiente", "Ballena" };

            IEnumerable<Animal> animales = new List<Animal>() {
                new Gato(nombres[0]),
                new Humano(nombres[1]),
                new Perro(nombres[2]),
                new Serpiente(nombres[3]),
                new Ballena(nombres[4])
            };

            String[][] ars = new String[5][];
            int i = 0;

            table = new DataTable("Animales");
            DataColumn nombre = new DataColumn("Nombre", typeof(String));
            DataColumn hablar = new DataColumn("Hablar", typeof(String));
            DataColumn caminar = new DataColumn("Caminar", typeof(String));
            DataColumn respirar = new DataColumn("Respirar", typeof(String));
            table.Columns.Add(nombre);
            table.Columns.Add(hablar);
            table.Columns.Add(caminar);
            table.Columns.Add(respirar);

            foreach (Animal a in animales)
            {

                DataRow row = table.NewRow();
                row[nombre] = nombres[i];
                row[hablar] = a.Hablar;
                row[respirar] = a.Respirar;
                row[caminar] = a.Caminar;
                table.Rows.Add(row);
                i++;
            }

            Grid1.DataSource = nombres;
            Grid1.DataBind();
        }

        protected void CustomersGridView_RowCommand(Object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow selectedRow = Grid1.Rows[index];

            if (e.CommandName == "Hablar")
            {
                txtAction.Text = table.Rows[selectedRow.DataItemIndex]["Hablar"].ToString();
            }

            if (e.CommandName == "Caminar")
            {
                txtAction.Text = table.Rows[selectedRow.DataItemIndex]["Caminar"].ToString();
            }

            if (e.CommandName == "Respirar")
            {
                txtAction.Text = table.Rows[selectedRow.DataItemIndex]["Respirar"].ToString();
            }
        }
    }
}