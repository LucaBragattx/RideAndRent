using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideYouRentST10090990.View.Driver
{
    public partial class Pending : System.Web.UI.Page
    {
        //Driver module
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowCars();

        }
        //add this method to solve the Error 
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowCars()
        {
            String Query = "select * from Rental where DriverID =" + Login.DriverID + "";
            CarList.DataSource = Conn.GetData(Query);
            CarList.DataBind();

        }
    }
}