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

    public partial class Home : System.Web.UI.Page
    {

       conclass conn = new conclass();

        //private void BindRecord()
        //{
        //    SqlConnection conn;
        //    SqlCommand cmd;
        //    SqlDataAdapter sda;
        //    DataTable dt;

        //    conn = new SqlConnection("Data Source=SUYPC223;Initial Catalog=DbDatabase;Integrated Security=True");
        //    cmd = new SqlCommand("select * from formdata", conn);
        //    cmd.CommandType = CommandType.Text;
        //    dt = new DataTable();
        //    sda = new SqlDataAdapter();
        //    sda.SelectCommand = cmd;
        //    sda.Fill(dt);
        //    GridView1.DataSource = dt.DefaultView;
        //    GridView1.DataBind();

        //    sda.Dispose();
        //    cmd.Dispose();
        //    conn.Dispose();
        //}
        private void DeleteRecordFromDB(int ID)
        {
            SqlConnection conn;
            SqlCommand cmd;

            conn = new SqlConnection("Data Source=SUYPC223;Initial Catalog=DbDatabase;Integrated Security=True");


            cmd = new SqlCommand("DELETE FROM formdata WHERE id = @ID", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", ID);

            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
            cmd.Dispose();
           // BindRecord();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
           
                int ID = (int)GridView1.DataKeys[e.RowIndex].Value;
                DeleteRecordFromDB(ID);
                Response.Redirect("Home.aspx");
            

            }
            
            //string id = GridName.DataKeys[Convert.ToInt32(e.CommandArgument)].Value.ToString();
        }
    }
