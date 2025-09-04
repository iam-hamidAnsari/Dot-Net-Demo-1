using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Data.SqlClient;

namespace Dot_Net_Demo_1
{
    public partial class Index : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString.ToString();
            conn = new SqlConnection(cs);
            if (!IsPostBack)
            {
                BindEmployeeData();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEmp.aspx");
        }


        public void BindEmployeeData()
        {
            try
            {
                conn.Open(); //open connection 
                SqlCommand cmd = new SqlCommand("Usp_GetEmpDeta", conn); //preparing command
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // passing command type
                SqlDataReader rdr = cmd.ExecuteReader(); // Reading All table data 
                GridView1.DataSource = rdr; 
                GridView1.DataBind();
            }
            catch (Exception ex) { 
            
            }
        }
    }
}