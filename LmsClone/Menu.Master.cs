using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LmsClone
{
    public partial class Menu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((string)Session["loginstudent"]) && String.IsNullOrEmpty((string)Session["loginadmin"]))
            {
                Response.Redirect("Signin.aspx");
            }
        }
        protected void UserClick(object sender, EventArgs e)
        {
            Response.Redirect("User.aspx");
        }
    }
}