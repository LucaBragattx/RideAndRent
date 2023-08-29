using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideYouRentST10090990.View.Inspector
{
    public partial class Inspectors : System.Web.UI.Page
    {
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowInspectors();

        }
        //add this method to solve the Error 
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowInspectors()
        {
            String Query = "select * from Inspector";
            InspectorList.DataSource = Conn.GetData(Query);
            InspectorList.DataBind();
        }


        protected void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (InspectorNumber1.Value == "" || InspectorName1.Value == "" || InspectorEmail1.Value == "" || InspectorMobile1.Value == "")
                {
                    ErrorMsg.InnerText = "Infomation Is Missing";
                }
                else
                {
                    String Inspector_no = InspectorNumber1.Value;
                    String Name = InspectorName1.Value;
                    String Email = InspectorEmail1.Value;
                    String Mobile = InspectorMobile1.Value;
                    String Query = "Insert into Inspector values('{0}','{1}','{2}','{3}')";
                    Query = String.Format(Query, Inspector_no, Name, Email, Mobile);
                    Conn.SetData(Query);
                    ShowInspectors();
                    ErrorMsg.InnerText = "Inspector Created";


                }
            }
            catch (Exception Ex)
            {

                // throw;
                ErrorMsg.InnerText = Ex.Message;
            }


        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (InspectorNumber1.Value == "")
                {
                    ErrorMsg.InnerText = "Infomation Is Missing";
                }
                else
                {
                    String Inspector_no = InspectorNumber1.Value;
                    String Query = "Delete from Inspector where Inspector_no ='{0}'";
                    Query = String.Format(Query, Inspector_no);
                    Conn.SetData(Query);
                    ShowInspectors();
                    ErrorMsg.InnerText = "Inspector Deleted";


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
                if (InspectorNumber1.Value == "" || InspectorName1.Value == "" || InspectorEmail1.Value == "" || InspectorMobile1.Value == "")
                {
                    ErrorMsg.InnerText = "Infomation Is Missing";
                }
                else
                {
                    String Inspector_no = InspectorNumber1.Value;
                    String Name = InspectorName1.Value;
                    String Email = InspectorEmail1.Value;
                    String Mobile = InspectorMobile1.Value;
                    String Query = "update Inspector set Name ='{0}', Email = '{1}', Mobile = '{2}' where Inspector_no = '{3}'";
                    Query = String.Format(Query, Name, Email, Mobile, Inspector_no);
                    Conn.SetData(Query);

                    ErrorMsg.InnerText = "Inspector Updated";
                    ShowInspectors();

                }
            }
            catch (Exception Ex)
            {

                // throw;
                ErrorMsg.InnerText = Ex.Message;
            }

    }
        
        protected void InspectorList_SelectedIndexChanged1(object sender, EventArgs e)
        {
            InspectorNumber1.Value = InspectorList.SelectedRow.Cells[1].Text;
            InspectorName1.Value = InspectorList.SelectedRow.Cells[2].Text;
            InspectorEmail1.Value = InspectorList.SelectedRow.Cells[3].Text;
            InspectorMobile1.Value = InspectorList.SelectedRow.Cells[4].Text;


        }
    }
    }

