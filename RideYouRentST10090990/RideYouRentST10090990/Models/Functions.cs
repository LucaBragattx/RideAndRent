using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RideYouRentST10090990.Models
{
    public class Functions
    {
        private SqlConnection Conn;
        private SqlCommand cmd;
        private DataTable dt;
        private string ConnStr;
        private SqlDataAdapter sda;

        public Functions()
        {
            ConnStr = @"Server=tcp:lucabragatto.database.windows.net,1433;Initial Catalog=BragattoLuca;Persist Security Info=False;User ID=LucaBragatto;Password=Ilsanto7!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            Conn = new SqlConnection(ConnStr);
            cmd = new SqlCommand();
            cmd.Connection = Conn;

        }
        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, ConnStr);
            sda.Fill(dt);
            return dt;
        }
        public int SetData(String Query)
        {
            int rent = 0;
            if(Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
            cmd.CommandText = Query;
            rent = cmd.ExecuteNonQuery();
            Conn.Close();
            return rent;

        }
    }
}