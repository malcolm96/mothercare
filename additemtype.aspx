<%@ Page Language="C#" AutoEventWireup="true" CodeFile="additemtype.aspx.cs" Inherits="additemtype" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="Center"><tr><td>
    <asp:Image AlternateText ="" ImageUrl ="~/images/logo.png" runat ="server" ID="imglogo" Height="54px" Width="190px"/>
    </td></tr></table><hr />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" /><br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label></div>
    </form>
</body>
</html>
