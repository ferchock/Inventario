using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventario
{
    public partial class CreaItem : System.Web.UI.Page
    {
        Connector Con = new Connector();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            txtItemCode.Text = "";
            txtDescription.Text = "";
            string item = txtItemCode.Text;
            string description = txtDescription.Text;

            if (item != "" || description != "")
            {
                try
                {
                    BDInventarioTableAdapters.ItemsTableAdapter ni = new BDInventarioTableAdapters.ItemsTableAdapter();
                    ni.insertar(item, description);
                    lblStatus.Text = "Item Insertado Correctamente!";
                    txtItemCode.Text = "";
                    txtDescription.Text = "";

                }
                catch
                {
                    lblStatus.Text = "Error al insertar!";
                }
            }
            else
            {
                lblStatus.Text = "Campos no pueden estar vacíos!";
            }



        }
    }
}