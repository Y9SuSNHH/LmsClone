<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SigninAdmin.aspx.cs" Inherits="LmsClone.SigninAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập giáo viên</title>
</head>
<body>
<div id="all">
        <form runat="server">
            <p>Admin</p>
            <p>Tài khoản</p>
            <input type="text" name="username"/>
            <p>Mật khẩu</p>
            <input type="password" name="password" value="" />
            <br />
            <button runat="server" onserverclick="SigninClick">Đăng nhập</button>
            <%--<asp:Button runat="server" OnClick="SigninClick" Text="Đăng nhập"/>--%>
        </form>
    </div>
</body>
</html>
