using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideYouRentST10090990.View.Inspector
{
    public partial class Drivers : System.Web.UI.Page
    {
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowDrivers();
        }
        //add this method to solve the Error 
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowDrivers()
        {
            String Query = "select * from Driver";
            DriverList.DataSource = Conn.GetData(Query);
            DriverList.DataBind();
        }


        protected void CreateBtn_Click1(object sender, EventArgs e)
        {
            try
            {
                if (DriverName1.Value == "" || DriverAddress1.Value == "" || DriverEmail1.Value == "" || DriverMobile1.Value == "")
                {
                    ErrorMsg.InnerText = "Infomation Is Missing";
                }
                else
                {
                    String Name = DriverName1.Value;
                    String Address = DriverAddress1.Value;
                    String Email = DriverEmail1.Value;
                    String Mobile = DriverMobile1.Value;
                    String Query = "Insert into Driver values('{0}','{1}','{2}','{3}')";
                    Query = String.Format(Query, Name, Address, Email, Mobile);
                    Conn.SetData(Query);
                    ShowDrivers();
                    ErrorMsg.InnerText = "Driver Created";


                }
            }
            catch (Exception Ex)
            {

                // throw;
                ErrorMsg.InnerText = Ex.Message;
            }

        }
        int Key = 0;
        protected void DriverList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriverName1.Value = DriverList.SelectedRow.Cells[2].Text;
            DriverAddress1.Value = DriverList.SelectedRow.Cells[3].Text;
            DriverEmail1.Value = DriverList.SelectedRow.Cells[4].Text;
            DriverMobile1.Value = DriverList.SelectedRow.Cells[5].Text;
            if (DriverName1.Value == "")
            {
                Key = 0;
            } else
            {
                Key = Convert.ToInt32(DriverList.SelectedRow.Cells[1].Text);
            }

        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DriverName1.Value == "")
                {
                    ErrorMsg.InnerText = "Infomation Is Missing";
                }
                else
                {
                    String Query = "Delete from Driver where DriverID = {0}";
                    Query = String.Format(Query, DriverList.SelectedRow.Cells[1].Text);
                    Conn.SetData(Query);
                    ShowDrivers();
                    ErrorMsg.InnerText = "Driver Deleted";


                }
            }
            catch (Exception Ex)
            {

                // throw;
                ErrorMsg.InnerText = Ex.Message;
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DriverName1.Value == "" || DriverAddress1.Value == "" || DriverEmail1.Value == "" || DriverMobile1.Value == "")
                {
                    ErrorMsg.InnerText = "Infomation Is Missing";
                }
                else
                {
                    String Name = DriverName1.Value;
                    String Address = DriverAddress1.Value;
                    String Email = DriverEmail1.Value;
                    String Mobile = DriverMobile1.Value;
                    String Query = "update Driver set Name ='{0}', Address = '{1}', Email = '{2}', Mobile =  {3} where DriverID = '{4}'";
                    Query = String.Format(Query, Name, Address, Email, Mobile, Convert.ToInt32(DriverList.SelectedRow.Cells[1].Text));
                    Conn.SetData(Query);
                    ShowDrivers();
                    ErrorMsg.InnerText = "Driver Updated";
                    

                }
            }
            catch (Exception Ex)
            {

                // throw;
                ErrorMsg.InnerText = Ex.Message;
            }

        }
    } 
}
  