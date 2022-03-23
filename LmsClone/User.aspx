<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="LmsClone.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Thông tin cá nhân ...
    <br />
    <asp:Label ID="inforName" runat="server" Text=""></asp:Label>
    <br />
    Tài khoản: 
    <asp:Label ID="inforUserName" runat="server" Text=""></asp:Label>
    <br />
    Email:    
    <asp:Label ID="inforEmail" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btnSignout" CssClas="btnMenu"  runat="server" Text="Đăng xuất" OnClick="SignoutClick"/>
</asp:Content>
