<%@ Page Language="C#" AutoEventWireup="true" CodeFile="alogin.aspx.cs" Inherits="alogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Administration login</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    <table align="center" ><tr><td><asp:Image ID="imglogo" runat ="server" ImageUrl ="~/images/logo.png" Height="54px" ImageAlign="AbsMiddle" Width="190px" /></td></tr>
    </table>
    <hr />
        <span style="font-size: 32pt; font-family: Segoe UI"><strong>
    ADMINISTRATOR LOGIN PAGE
            <br />
            <br />
            <span style="font-size: 11pt">&nbsp; &nbsp;&nbsp; Admin email &nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                <br />
                &nbsp; &nbsp; &nbsp; &nbsp;
                Password &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; 
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox><br />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Forgot Password?</asp:LinkButton><br />
                <br />
                <br />
                &nbsp; &nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" BackColor="#FF6501" Font-Names="Segoe UI"
                    ForeColor="White" OnClick="Button1_Click" Text="signin" Width="77px" /></span></strong></span></div>
    </form>
</body>
</html>
