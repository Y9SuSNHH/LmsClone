<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signin.aspx.cs" Inherits="LmsClone.Signin" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title></title>
</head>
<body>
    <div id="all">
        <form runat="server">
            <p>Tài khoản</p>
            <input type="text" name="username"/>
            <p>Mật khẩu</p>
            <input type="password" name="password" value="" />
            <br />
            <asp:Button runat="server" OnClick="SigninClick" Text="Đăng nhập"/>
            <a href="Signup.aspx">Đăng kí</a>
        </form>
    </div>
</body>
</html>
