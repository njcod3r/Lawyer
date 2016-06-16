using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Layer
{
    public static class DataAccessLayer
    {
        public static DataSet RunSelect(string query)
        {
            SqlConnection Con =
                new SqlConnection("Data Source=ALX-MICROSOFT\\SQLEXPRESS;Initial Catalog=AGC-ADO.NET;Persist Security Info=True;User ID=Sa;Password=123;");
            SqlCommand Com = new SqlCommand(query, Con);
            SqlDataAdapter Adapt = new SqlDataAdapter(Com);
            DataSet Ds = new DataSet();
            Adapt.Fill(Ds);
            return Ds;
        }

        public static int RumDML(string query)
        {
            SqlConnection Con = new SqlConnection("Data Source=ALX-MICROSOFT\\SQLEXPRESS;Initial Catalog=AGC-ADO.NET;Persist Security Info=True;User ID=Sa;Password=123;");
            SqlCommand Com = new SqlCommand(query, Con);
            Con.Open();
            int Aff = Com.ExecuteNonQuery();
            Con.Close();
            return Aff;
        }
    }
}