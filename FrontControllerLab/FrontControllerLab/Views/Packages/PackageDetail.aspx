<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PackageDetail.aspx.cs" Inherits="FrontControllerLab.Views.Packages.PackageDetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <a href="Home.action">Home</a>
    <h1>Details of selected package</h1>
    <div>
    Name: <asp:Label ID="LabelName" runat="server" Text=""></asp:Label><br/>
    Description: <asp:Label ID="LabelDescription" runat="server" Text=""></asp:Label><br/>
    Price: £<asp:Label ID="LabelPrice" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
