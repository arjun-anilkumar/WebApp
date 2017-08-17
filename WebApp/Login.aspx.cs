using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
           // Label3.Visible = false;

            if (TextBox1.Text == "admin")
            {
                if (TextBox2.Text == "admin")
                {
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Label3.Text = "Invalid Credintials";
                    Label3.Visible = true;
                }
            }
        }
    }
}