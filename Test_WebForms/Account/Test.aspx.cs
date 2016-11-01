using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace Test_WebForms.Account
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string conStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlConnection db = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand("SELECT * FROM AspNetUsers", db);
                cmd.Connection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                string temp = "";
                DropDownList cmb_users = new DropDownList();
                while (rdr.Read())
                {
                    temp = rdr["Email"].ToString();
                    cmb_users.ID= rdr["Email"].ToString();
                    cmb_users.Items.Add(rdr["Email"].ToString());
                }
                form1.Controls.Add(cmb_users);
                Label1.Text = "Text from GIT";
                Label1.Text = temp;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Label2.Visible)
                Label2.Visible = false;
            else
                Label2.Visible = true;
           
        }
    }
}
