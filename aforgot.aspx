<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aforgot.aspx.cs" Inherits="aforgot" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Forgot Password</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table >
    <tr>
    <td>
    <asp:Image ID="img" Height ="54px" ImageUrl ="images/logo.png" runat ="server" />
    </td>
    </tr>
    </table>
    <hr />
        <asp:Label ID="Label1" runat="server" Text="Enter your email"></asp:Label>&nbsp;
        <asp:TextBox ID="txtmail" runat="server"></asp:TextBox><br />
        <br />
    <asp:Label ID="lbl" runat ="Server" Text ="Enter your phone" ></asp:Label>
    <asp:TextBox ID="txtnum" runat="server" ></asp:TextBox>
        <br />
        <br />
    <asp:Button ID="btn" runat ="server" Text ="Submit" OnClick="btn_Click" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
