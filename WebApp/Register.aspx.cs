using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{         
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string status;
            if (RadioButton1.Checked == true)
            {
                status = "trainer";
            }
            else
            {
                status = "trainee";
            }

            SqlConnection con = new SqlConnection("Data Source=SUYPC223;Initial Catalog=DbDatabase;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("insert into formdata(Name,Age,UserName,Password,Utype) values('" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "', '" + status + "')", con);

            cmd.CommandType = CommandType.Text;

            try

            {

                con.Open();

                cmd.ExecuteNonQuery();

                Label5.Text = "Data inserted successfully";

                Label5.Visible = true;

                con.Close();


            }

            catch (Exception ex)

            {
                Label5.Text = "Not successfull";
                Label5.Visible = true;
            }

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox4.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }
    }
}