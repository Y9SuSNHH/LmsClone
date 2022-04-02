<%@ Page Title="Trang chủ" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="LmsClone.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .index {
            background: #009FE1;
            color: #fff;
        }
            
        #bot > .top {
            width: 100%;
            height: 20%;
        }

        #bot_admin {
            width: 80%;
            height: 70%;
            margin: 0 auto;
            margin-top: 2%;
            padding: 20px;
            border-top: solid 1px #e5e5e5;
            background-color: rgba(214,228,215,0.2);
            box-shadow: 0px 0px 15px 1px #d1d1d1;
            border-radius: 10px;
        }

        #bot_student {
            width: 80%;
            height: 70%;
            margin: 0 auto;
            margin-top: 2%;
            padding: 20px;
            border-top: solid 1px #e5e5e5;
            background-color: rgba(214,228,215,0.2);
            box-shadow: 0px 0px 15px 1px #d1d1d1;
            border-radius: 10px;
        }

        a {
            text-decoration: none;
            color: black;
        }
        h1{
            margin: 2% 2%;
        }

        * {
            margin: 0;
            padding: 0;
        }

        .each-class {
            width: 30%;
            height: 50%;
            display: inline;
            float: left;
            text-align: center;
            margin-right: 2%;
            margin-bottom: 2%;
            border: solid 1px #e5e5e5;
            background-color: rgba(214,228,215,0.2);
            box-shadow: 0px 0px 15px 1px #d1d1d1;
            border-radius: 10px;
        }

        .class-img {
            width: 100%;
            height: 60%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="bot_admin" runat="server">
        <div style="width: 100%; text-align: center; height: 10%;">
            <h1>Lớp học của bạn</h1>
            <p>Danh sách lớp học do bạn quản lý.</p>
        </div>
        <div style="width: 100%; height: 90%; margin-left: 3%;">
            <asp:ListView ID="ListViewClass1" runat="server">
                <ItemTemplate>
                    <div class="each-class">
                        <a href="DetailClass.aspx?id=<%# Eval("Id")%>">
                            <img src="./img/book.jpg" class="class-img" alt="" />
                            <h5>Lớp:  <%# Eval("Name") %></h5>
                            <h5>GV: <%# Eval("Usernameadmin") %></h5>
                            <h5>Mô tả: <%# Eval("Description") %></h5>
                        </a>
                    </div>
                </ItemTemplate>
            </asp:ListView>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server"></asp:XmlDataSource>
        </div>
    </div>
    <div id="bot_student" runat="server">
        <div style="width: 100%; text-align: center; height: 10%;">
            <h1>Danh sách lớp học</h1>
        </div>
        <div style="width: 100%; height: 90%; margin-left: 3%;">
            <asp:ListView ID="ListViewClass2" runat="server">
                <ItemTemplate>
                    <div class="each-class">
                        <a href="DetailClass.aspx?id=<%# Eval("Id")%>">
                            <img src="./img/book.jpg" class="class-img" alt="" />
                            <h5>Lớp:  <%# Eval("Name") %></h5>
                            <h5>GV: <%# Eval("Usernameadmin") %></h5>
                            <h5>Mô tả: <%# Eval("Description") %></h5>
                        </a>
                    </div>
                </ItemTemplate>
            </asp:ListView>
            <asp:XmlDataSource ID="XmlDataSource2" runat="server"></asp:XmlDataSource>
        </div>
    </div>
</asp:Content>
