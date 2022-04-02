using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LmsClone.Model;

namespace LmsClone
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bot_admin.Visible = false;
            bot_student.Visible = false;
            if (Session["loginadmin"] == "true")
            {
                bot_admin.Visible = true;
                // lấy ds lớp học
                String path = Server.MapPath("~/Data/Class.xml");
                List<ClassObject> Class = Model.Class.GetList(path);
                List<ClassObject> Classfilter = new List<ClassObject>();


                foreach (Model.ClassObject each in Class)
                {
                    if (each.Usernameadmin.Equals(Session["username"]))
                    {
                        Classfilter.Add(each);
                    }
                }

                ListViewClass1.DataSource = Classfilter;
                ListViewClass1.DataBind();
            }
            else if (Session["loginstudent"] == "true")
            {
                bot_student.Visible = true;
                String path = Server.MapPath("~/Data/Class.xml");
                List<ClassObject> Class = Model.Class.GetList(path);
                List<ClassObject> Classfilter = new List<ClassObject>();


                foreach (Model.ClassObject each in Class)
                {
                    Classfilter.Add(each);
                }

                ListViewClass2.DataSource = Classfilter;
                ListViewClass2.DataBind();
            }
        }

    }
}