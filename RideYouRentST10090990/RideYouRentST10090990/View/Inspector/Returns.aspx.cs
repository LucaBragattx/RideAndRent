using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideYouRentST10090990.View.Inspector
{
    public partial class Returns : System.Web.UI.Page
    {
        //Driver module
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowReturns();

        }
        //add this method to solve the Error 
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowReturns()
        {
            String Query = "select * from Returns";
            ReturnList.DataSource = Conn.GetData(Query);
            ReturnList.DataBind();

        }
        String Carnumber;
        protected void RentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carnumber = ReturnList.SelectedRow.Cells[1].Text;

        }

        protected void RetrieveBtn2_Click(object sender, EventArgs e)
        {
            try
            {


                String Query = "Delete from Returns where Carno ='{0}'";
                Query = String.Format(Query, ReturnList.SelectedRow.Cells[1].Text);
                Conn.SetData(Query);
                InfoMsg.InnerText = "Car Retrieved";

            }
            catch (Exception Ex)
            {

                throw;
                InfoMsg.InnerText = Ex.Message;
            }
        }
    }
}