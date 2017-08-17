using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class ViewState : System.Web.UI.Page
    {
        public int clickscount;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                sampleTxt.Text = 0.ToString();
                clickscount = 0;
                ViewState["clicks"] = clickscount;
            }
        }


             protected void sampleBtn_Click(object sender, EventArgs e)
        {
            clickscount = Convert.ToInt32(ViewState["clicks"].ToString());
            clickscount = clickscount + 1;
           ViewState["clicks"] = clickscount;
             sampleTxt.Text = ViewState["clicks"].ToString();
            //sampleTxt.Text = clickscount.ToString();
        }




    
    }
}