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
    }
}