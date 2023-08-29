using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideYouRentST10090990.View.Inspector
{
    public partial class Rentals : System.Web.UI.Page
    {
        //Driver module
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowRental();

        }
        //add this method to solve the Error 
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowRental()
        {
            String Query = "select * from Rental";
            RentList.DataSource = Conn.GetData(Query);
            RentList.DataBind();

        }
        String Carnumber;
        protected void RentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carnumber = RentList.SelectedRow.Cells[1].Text;

        }
        private void UpdateCar()
        {
            try
            {
                String Avaliable = "Yes";
                String Query = "update Car set Avaliable = '{0}' where CarNo = '{1}'";
                Query = String.Format(Query, Avaliable, RentList.SelectedRow.Cells[2].Text);
                Conn.SetData(Query);
                ShowRental();


            }
            catch (Exception Ex)
            {

                // throw;
                InfoMsg.InnerText = Ex.Message;
            }
        }

        protected void RetrieveBtn_Click(object sender, EventArgs e)
        {
            try
            {
             
                   
                    String Query = "Delete from Rental where Carno ='{0}'";
                    Query = String.Format(Query, RentList.SelectedRow.Cells[1].Text);
                    Conn.SetData(Query);
                InfoMsg.InnerText = "Car Retrieved";
               
            }
            catch (Exception Ex)
            {

                throw;
                InfoMsg.InnerText = Ex.Message;
            }
        }

        protected void CreateBtn_Click1(object sender, EventArgs e)
        {
            try
            {
                if (RentList.SelectedRow.Cells[1].Text == "")
                {
                    InfoMsg.InnerText = "Select a Rent";
                }
                else
                {

                    String Query = "insert into Returns (Carno, Inspector, Driver, Return_date, Elapsed_date, Fine) values('{0}','{1}','{2}','{3}',{4},{5})";
                    Query = String.Format(Query, RentList.SelectedRow.Cells[1].Text, RentList.SelectedRow.Cells[3].Text, RentList.SelectedRow.Cells[4].Text, System.DateTime.Today.Date.ToString(), Finetb.Value = Finetb.Value, Elapsetb.Value);
                    Conn.SetData(Query);
                    UpdateCar();
                    ShowRental();
                    InfoMsg.InnerText = "Car Rented";
                }
            }
            catch (Exception Ex)
            {

                //throw;
                InfoMsg.InnerText = Ex.Message;

            }

        }
    }
}