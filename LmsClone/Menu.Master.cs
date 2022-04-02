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
            insert_class.Visible = false;
            if (String.IsNullOrEmpty((string)Session["loginstudent"]) && String.IsNullOrEmpty((string)Session["loginadmin"]))
            {
                Response.Redirect("Signin.aspx");
            }
            if(!String.IsNullOrEmpty((string)Session["loginadmin"]))
            {
                insert_class.Visible = true;
            }
        }
        protected void SignoutClick(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["name"] = "";
            Session["email"] = "";
            if (Session["loginstudent"] == "true")
            {
                Session["loginstudent"] = "";
                Session["loginadmin"] = "";
                Response.Redirect("Signin.aspx");
            }
            else if (Session["loginadmin"] == "true")
            {
                Session["loginstudent"] = "";
                Session["loginadmin"] = "";
                Response.Redirect("SigninAdmin.aspx");
            }
            else
            {
                Response.Redirect("Signin.aspx");
            }
        }
    }
}