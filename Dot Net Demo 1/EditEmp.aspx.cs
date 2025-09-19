using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace Dot_Net_Demo_1
{
    public partial class EditEmp : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString.ToString();
            conn = new SqlConnection(cs);
            if (!Request.QueryString["id"].IsNullOrEmpty())
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                FetchEmpById(id);
            }


        }
        private void FetchEmpById(int id)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Usp_GetEmpById", conn);
                cmd.Parameters.Add(new SqlParameter("Id", id));
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    TextBox1.Text = Convert.ToString(rdr["cname"]);
                    TextBox2.Text = Convert.ToString(rdr["nage"]);
                    TextBox3.Text = Convert.ToString(rdr["dsalary"]);
                    rdr.Close();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('{ex.Message}')</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        { }
    }
}