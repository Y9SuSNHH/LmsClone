using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LmsClone
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            inforUserName.Text = (string)Session["username"];
            if (Session["loginadmin"] == "true")
            {
                inforName.Text = "Giáo viên " + Session["name"];
            }
            else if (Session["loginstudent"] == "true")
            {
                inforName.Text = "Sinh viên " + Session["name"];
            }
            inforEmail.Text = (string)Session["email"];
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