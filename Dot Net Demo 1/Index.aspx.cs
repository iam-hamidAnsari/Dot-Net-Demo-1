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
            //if (!IsPostBack)
            //{
            //    BindEmployeeData();
            //}

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEmp.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            FetchDataIntoLabel(TextBox1.Text);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
            EmpLbl.Visible = false;
            err.Visible = false;
        }


        public void BindEmployeeData()
        {
            try
            {
                conn.Open(); //open connection 
                SqlCommand cmd = new SqlCommand("Usp_GetEmpDeta", conn); //preparing command
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // passing command type
                SqlDataReader rdr = cmd.ExecuteReader(); // Reading All table data 
                //GridView1.DataSource = rdr; 
                //GridView1.DataBind();
            }
            catch (Exception ex) { 
            
            }
        }


        public void FetchDataIntoLabel(string EmpName)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Fetch_Emp_By_Name", conn);
                // cmd.Parameters.AddWithValue("@Name", EmpName);
                cmd.Parameters.Add(new SqlParameter("Name", EmpName));
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader(); // use for DQL Opreations
                if (rdr.HasRows)
                {
                    EmpLbl.Visible = true;
                    err.Visible = false;
                    rdr.Read(); // reader is open
                    Label1.Text = Convert.ToString(rdr["cname"]);
                    Label2.Text = Convert.ToString(rdr["nage"]);
                    Label3.Text = Convert.ToString(rdr["dsalary"]);
                    rdr.Close(); // reader is closed
                }
                else {
                    err.Visible = true;
                }
                    conn.Close();
            }
            catch (Exception ex) { 
            
            }
        
        }
    }
}