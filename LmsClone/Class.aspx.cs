﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LmsClone.Model;

namespace LmsClone
{
    public partial class Class : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void InsertClassClick(object sender, EventArgs e)
        {

            string id= Request.Form["id"];
            string name= Request.Form["name"];
            string nameadmin = (string)Session["name"];
            string description = Request.Form["description"];

            if (id == "" && name == "" && description == "")
            {
                Response.Write("<script> alert('Vui lòng nhập đầy đủ thông tin!!!');</script>");
            }
            else if (id != "" && name != "" && description != "")
            {

                ClassObject each = new ClassObject();
                each.Id = id;
                each.Name = name;
                each.Nameadmin = nameadmin;
                each.Description = description;

                string path = Server.MapPath("~/Data/Class.xml");
                if (Model.Class.InsertClass(each, path))
                {
                    //Response.Write("<script> var result = confirm('Đăng kí thành công vui lòng đăng nhập lại !!!');if (result){window.location='Dangnhap.aspx';}else{alert('ok!');} </script>");
                    Response.Write("<script> alert('Thêm lớp thành công !!!');</script>");
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    Response.Write("<script> alert('Lỗi !!! Không thêm lớp được'); </script>");
                }
            }

        }
    }
}