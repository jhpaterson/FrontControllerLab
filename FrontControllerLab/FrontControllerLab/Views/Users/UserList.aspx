<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="FrontControllerLab.Views.Users.UserList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List of users</title>
</head>
<body>
    <form id="form1" runat="server">   
    <a href="Home.action">Home</a>
    <h1>List of users</h1>
    <div>
    <asp:gridview ID="Gridview1" runat="server"></asp:gridview>
    </div>
    </form>
</body>
</html>
