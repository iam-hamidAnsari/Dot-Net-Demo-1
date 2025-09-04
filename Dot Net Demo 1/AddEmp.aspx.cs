using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dot_Net_Demo_1
{
    public partial class AddEmp : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString.ToString();
            conn = new SqlConnection(cs);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text; // fatching name from name textbox
            int age = int.Parse(TextBox2.Text); // fatching name from age textbox
            double salary = double.Parse(TextBox3.Text); // fatching salary from name textbox
            try
            {
                conn.Open(); //step 1 : open the connection
                SqlCommand cmd = new SqlCommand("Usp_AddEmp", conn); // step 2 : preparing command
                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@age", age));
                cmd.Parameters.Add(new SqlParameter("@salary", salary));
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // step 3: telling to command that i have passed sp
                int n = cmd.ExecuteNonQuery(); // step 4: Executing DML Command
                if (n > 0)
                {
                    Response.Write("<script>alert('Employee Added SuccessFully..')</script>");
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Employee Not Added..')</script>");
                }
            }
            catch (Exception ex) {
                Response.Write("<script>alert('Employee Not Added..')</script>");
            }
        }
    }
}