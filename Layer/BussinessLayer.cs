using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Layer
{
    public class BussinessLayer
    {
        public static DataSet SelectAll()
        {
            string cmd = "SELECT * FROM UAC";
            return DataAccessLayer.RunSelect(cmd);
        }

        public static int Insert(string uname, string pass)
        {
            string Cmd = "INSERT INTO UAC VALUES('" + uname + "','" + pass + "')";
            return DataAccessLayer.RumDML(Cmd);
        }

        public static int Update(string Oldname, string newname, string upass)
        {
            string Cmd = "UPDATE UAC SET UserName = '" + newname + "' , Password = '" + upass + "' WHERE UserName ='" + Oldname + "'";
            return DataAccessLayer.RumDML(Cmd);
        }

        public static int Delete(string uname)
        {
            string Cmd = "DELETE FROM UAC WHERE UserName = '" + uname + "'";
            return DataAccessLayer.RumDML(Cmd);
        }

       
    }
}