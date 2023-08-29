using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideYouRentST10090990.View.Driver
{
    public partial class Cars : System.Web.UI.Page
    {
        //Driver module
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowCars();
            DriverName.InnerText = Login.DName;
            Inspector = Login.Inspector_no;

        }
        //add this method to solve the Error 
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowCars()
        {
            String St = "yes";
            String Query = "select * from Car where Available = '"+St+"'";
            CarList.DataSource = Conn.GetData(Query);
       
            CarList.DataBind();
            
        }
       
        private void UpdateCar()
        {
            try
            {
                    String Available = "Booked";
                    String Query = "update Car set Available = '{0}' where CarNo = '{1}'";
                    Query = String.Format(Query, Available, CarList.SelectedRow.Cells[1].Text);
                    Conn.SetData(Query);
                    ShowCars();

                
            }
            catch (Exception Ex)
            {

                // throw;
               InfoMsg.InnerText = Ex.Message;
            }
}

        protected void Bookbtn_Click(object sender, EventArgs e)
        {
            TimeSpan DDays = Convert.ToDateTime(ReturnDate.Value) - DateTime.Today.Date;
            int Days = DDays.Days;
            int DPrice;
            DPrice = Convert.ToInt32(CarList.SelectedRow.Cells[5].Text);
            int RentalFee = DPrice * Days;
             try
             {
                 if (CarList.SelectedRow.Cells[1].Text == "")
                 {
                     InfoMsg.InnerText = "Infomation Is Missing";
                 }
                 else
                 {
                    
                    String Query = "insert into Rental (Carno, DriverID, Inspector, Driver, Rental_Fee, Start_date, End_date) values('{0}',{1},{2},'{3}','{4}','{5}','{6}')";
                     Query = String.Format(Query, CarList.SelectedRow.Cells[1].Text, Login.DriverID, RentalFee, "Bud Barnes", DriverName,System.DateTime.Today.Date.ToString(), ReturnDate.Value);
                     Conn.SetData(Query);
                    UpdateCar();
                    ShowCars();
                     InfoMsg.InnerText = "Car Rented";
                 }
             }
             catch (Exception Ex)
             {

                  //throw;
                  InfoMsg.InnerText = Ex.Message;
                 
            } 
        }
        String CarNo, Inspector, StartDate, EndDate;
        int DPrice,Driver;
       
        protected void CarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarNo = CarList.SelectedRow.Cells[1].Text;
           
            StartDate = System.DateTime.Today.Date.ToString();
            EndDate = ReturnDate.Value;
            DPrice = Convert.ToInt32(CarList.SelectedRow.Cells[5].Text);

        }
    }
}