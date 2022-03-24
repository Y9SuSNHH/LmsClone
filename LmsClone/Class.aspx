<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Class.aspx.cs" Inherits="LmsClone.Class" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form>
            <p>Mã lớp</p>
            <input type="text" name="id"/>
            <p>Tên lớp</p>
            <input type="text" name="name"/>
            <p>Mô tả</p>
            <input type="text" name="description"/>
            <br />
            <asp:Button runat="server" OnClick="InsertClassClick" Text="Thêm lớp"/>
        </form>
</asp:Content>
