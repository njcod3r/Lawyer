using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Layer
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            int x = BussinessLayer.Insert(txtUName.Text, txtUserPass.Text);
            if (x == 1) {
                HttpContext.Current.Response.Write("<script>alert('Record is Saved');</script>");
            }
            txtUName.Text = "" ;
            txtUserPass.Text = "";
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void btn_Del_Click(object sender, EventArgs e)
        {
           int x = BussinessLayer.Delete(txt_oldName.Text);
            if (x == 1)
            {
                HttpContext.Current.Response.Write("<script>alert('Record is Deleted');</script>");
            }


            txtUName.Text = "";
            txtUserPass.Text = "";
        }

    }
}
