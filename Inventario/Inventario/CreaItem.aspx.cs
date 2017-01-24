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
            //if (!IsPostBack)
            //{
            //    txtItemCode.Text = "";
            //    txtDescription.Text = "";
            //}
            
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtItemCode.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {

                lblStatus.Text = "Campos no pueden estar vacíos!";


            }
            else
            {

                string item = txtItemCode.Text;
                string description = txtDescription.Text;
                BDInventarioTableAdapters.ItemsTableAdapter ni = new BDInventarioTableAdapters.ItemsTableAdapter();
                ni.insertar(item, description);
                lblStatus.Text = "Item Insertado Correctamente!";
                
            }

            txtItemCode.Text = "";
            txtDescription.Text = "";
        }
    }
}