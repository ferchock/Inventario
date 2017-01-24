using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventario
{
    public partial class CreaItem : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            

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
            lblStatus.Text = "";
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            //BDInventarioTableAdapters.ItemsTableAdapter iTA = new BDInventarioTableAdapters.ItemsTableAdapter();

            //DataSet itemsDS = new DataSet();

            //DataTable itemsDT = new DataTable();

            //itemsDT = iTA.GetData();
            //grvItems.DataSource = itemsDS;
           
        }

 
    }
}