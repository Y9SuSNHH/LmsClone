<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="LmsClone.Signup" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Đăng kí</title>
</head>
<body>
    <div id="all">
        <form runat="server">
            <p>Họ và tên</p>
            <input type="text" name="name" value="" />
            <p>Tài khoản</p>
            <input type="text" name="username" value="" />
            <p>Email</p>
            <input type="email" name="email" value="" />
            <p>Mật khẩu</p>
            <input type="password" name="password" value="" />
            <p>Nhập lại mật khẩu</p>
            <input type="password" name="comfirm_password" value="" />
            <br />
            <button runat="server" onserverclick="SignupClick">Đăng kí</button>
            <%--<asp:Button runat="server" OnClick="SignupClick" Text="Đăng kí"/>--%>
        </form>
    </div>
</body>
</html>
