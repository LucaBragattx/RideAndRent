using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideYouRentST10090990.View
{
    public partial class Login : System.Web.UI.Page
    {
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
        }
        public static string DName = "";
        public static int DriverID;
        public static String Inspector_no;
        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            if(InspectorRd.Checked)
            {
                string sql = "select Name, Mobile from Inspector where Name = '{0}' and Mobile = '{1}'";
                sql = string.Format(sql, UserNameTb.Value, MobileTb.Value);
                DataTable dt = Conn.GetData(sql);
                if (dt.Rows.Count == 0)
                {
                    InfoMsg.InnerText = "Invalid Inspector!";
                }else
                {
                    DName = "Inspector";
                    Response.Redirect("Inspector/Home.aspx");
                }

            }else
            {
                string sql = "select Name, Mobile, DriverID from Driver where Name = '{0}' and Mobile = '{1}'";
                sql = string.Format(sql, UserNameTb.Value, MobileTb.Value);
                DataTable dt = Conn.GetData(sql);
                if (dt.Rows.Count == 0)
                {
                    InfoMsg.InnerText = "Invalid Driver!";
                }else
                {
                    DName = dt.Rows[0][0].ToString();
                    DriverID = Convert.ToInt32(dt.Rows[0][2].ToString());
                    Response.Redirect("Driver/Cars.aspx");
                }

            }
        }
    }
}