using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LmsClone.Model;

namespace LmsClone
{
    public partial class Detailclass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            check.Visible = false;
            if (Session["loginadmin"] == "true")
            {
                check.Visible = true;
            }
         
            // lấy ds lớp học
            String path = Server.MapPath("~/Data/Lesson.xml");
            List<LessonObject> Lesson = Model.Lesson.GetList(path);
            List<LessonObject> Lesssobfilter = new List<LessonObject>();


            foreach (Model.LessonObject each in Lesson)
            {
                if (each.Idclass.Equals(Request.QueryString["id"]))
                {
                    Lesssobfilter.Add(each);
                }
            }

            ListViewLesson.DataSource = Lesssobfilter;
            ListViewLesson.DataBind();
        }
        protected void btnInserLesson(object sender, EventArgs e)
        {
            string idclass = Request.QueryString["id"];
            string id = Request.Form["id"];
            string name = Request.Form["name"];
            string description = Request.Form["description"];
            string detail = Request.Form["detail"];

            if (id == "" && name == "" && description == "" && detail == "")
            {
                Response.Write("<script> alert('Vui lòng nhập đầy đủ thông tin!!!');</script>");
            }
            else if (id != "" && name != "" && description != "" && detail != "")
            {

                LessonObject each = new LessonObject();
                each.Idclass = idclass;
                each.Id = id;
                each.Name = name;
                each.Description = description;
                each.Detail = detail;

                string path = Server.MapPath("~/Data/Lesson.xml");
                if (Model.Lesson.Insert(each, path))
                {
                    Response.Write("<script> var result = confirm('Thêm bài giảng thành công !!!');" +
                        "if (result){window.location='Detailclass.aspx?id="+ idclass + "';}</script>");
                    //Response.Write("<script> alert('Thêm lớp thành công !!!');</script>");
                    //Response.Redirect("Index.aspx");
                }
                else
                {
                    Response.Write("<script> alert('Lỗi !!! Không thêm lớp được'); </script>");
                }
            }

        }

    }
}