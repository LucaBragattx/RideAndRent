using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideYouRentST10090990.View.Inspector
{
    public partial class Cars : System.Web.UI.Page
    {
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
            String Query = "select * from Car";
            CarList.DataSource = Conn.GetData(Query);
            CarList.DataBind();
        }
        protected void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CarNo1.Value == "" || CarMake1.Value == "" || CarModel1.Value == "" || CarBodyType1.Value == "" || KilometresTravelled1.Value == "" || ServiceKilometres1.Value == "")
                {
                    ErrorMsg.InnerText = "Infomation Is Missing";
                }
                else
                {
                    String CarNo = CarNo1.Value;
                    String CarMake = CarMake1.Value;
                    String Model = CarModel1.Value;
                    String BodyType = CarBodyType1.Value;
                    int Kilometres_Travelled = Convert.ToInt32(KilometresTravelled1.Value.ToString());
                    int Service_Kilometres = Convert.ToInt32(ServiceKilometres1.Value.ToString());
                    String Available = Avaliable1.SelectedValue;
                    String Query = "Insert into Car values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
                    Query = String.Format(Query, CarNo, CarMake, Model, BodyType, Kilometres_Travelled, Service_Kilometres, Available);
                    Conn.SetData(Query);

                    ErrorMsg.InnerText = "Car Created";


                }
            }
            catch (Exception Ex)
            {

                // throw;
                ErrorMsg.InnerText = Ex.Message;
            }
        }
        
        protected void CarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarNo1.Value = CarList.SelectedRow.Cells[1].Text;
            CarMake1.Value = CarList.SelectedRow.Cells[2].Text;
            CarModel1.Value = CarList.SelectedRow.Cells[3].Text;
            CarBodyType1.Value = CarList.SelectedRow.Cells[4].Text;
            KilometresTravelled1.Value = CarList.SelectedRow.Cells[5].Text;
            ServiceKilometres1.Value = CarList.SelectedRow.Cells[6].Text;
            Avaliable1.SelectedValue = CarList.SelectedRow.Cells[7].Text;

        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CarNo1.Value == "")
                {
                    ErrorMsg.InnerText = "Infomation Is Missing";
                }
                else
                {
                    String CarNo = CarNo1.Value;
                    String Query = "Delete from Car where CarNo='{0}'";
                    Query = String.Format(Query, CarNo);
                    Conn.SetData(Query);
                    ShowCars();
                    ErrorMsg.InnerText = "Car Deleted";


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
                if (CarNo1.Value == "" || CarMake1.Value == "" || CarModel1.Value == "" || CarBodyType1.Value == "" || KilometresTravelled1.Value == "" || ServiceKilometres1.Value == "")
                {
                    ErrorMsg.InnerText = "Infomation Is Missing";
                }
                else
                {
                    String CarNo = CarNo1.Value;
                    String CarMake = CarMake1.Value;
                    String Model = CarModel1.Value;
                    String BodyType = CarBodyType1.Value;
                    int Kilometres_Travelled = Convert.ToInt32(KilometresTravelled1.Value.ToString());
                    int Service_Kilometres = Convert.ToInt32(ServiceKilometres1.Value.ToString());
                    String Avaliable = Avaliable1.SelectedValue;
                    String Query = "update Car set CarMake ='{0}', Model= '{1}', BodyType = '{2}', Kilometres_Travelled = {3}, Service_Kilometres = {4}, Available ='{5}' where CarNo = '{6}'";
                    Query = String.Format(Query, CarMake, Model, BodyType, Kilometres_Travelled, Service_Kilometres, Avaliable, CarNo);
                    Conn.SetData(Query);

                    ErrorMsg.InnerText = "Car Updated";
                    ShowCars();

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
        
        
    
