<%@ Page Language="C#" AutoEventWireup="true" CodeFile="administration.aspx.cs" Inherits="administration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
    .arfan
    {
    text-decoration:none;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td>
                        <img alt="" height="54" src="images\logo.png" width="190" />
                    </td>
                </tr>
            </table>
        </div>
        <hr />
        <table align="center">
            <tr>
                <td style="width: 1252px; height: 65px;">
                    <span style="font-family: Segoe UI"><span style="color: #3399ff"><span style="font-size: 24pt">
                        <strong>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Administration Board </strong>
                    </span></span></span>
                </td>
                <td style="width: 180px; height: 65px;">
                    &nbsp;<asp:LinkButton ID="LinkButton1" runat="server" CssClass="arfan" Font-Bold="True"
                        Font-Names="Segoe UI" ForeColor="Red">Logout</asp:LinkButton></td>
            </tr>
        </table>
        <hr />
        <table align="Center">
            <tr>
                <td style="height: 108px">
                    <asp:Button ID="Button1" runat="server" BackColor="#FF8000" BorderColor="Gainsboro"
                        BorderStyle="Inset" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Height="79px"
                        OnClick="Button1_Click" Text="Manage products" Width="344px" />
                    &nbsp; &nbsp;
                    <asp:Button ID="Button2" runat="server" BackColor="Chartreuse" BorderStyle="Inset"
                        Font-Bold="True" Font-Size="X-Large" ForeColor="White" Height="78px" Text="Orders"
                        Width="341px" OnClick="Button2_Click" /></td>
            </tr>
            <tr>
                <td style="height: 108px">
                    <asp:Button ID="Button3" runat="server" BackColor="#8080FF" BorderColor="WhiteSmoke"
                        BorderStyle="Inset" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Height="79px"
                        Text="Reports" Width="345px" OnClick="Button3_Click" />
                    &nbsp; &nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" BackColor="#00C0C0" BorderColor="Gainsboro"
                        BorderStyle="Inset" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Height="77px"
                        OnClick="Button4_Click" Text="Add Items" Width="335px" />
                </td>
            </tr>
        </table>
        &nbsp; &nbsp;&nbsp; &nbsp; 
        <asp:Button ID="feedback" runat="server" OnClick="feedback_Click" Text="Feedback" Height="69px" Width="346px" BackColor="#FF80FF" Font-Bold="False" Font-Names="Segoe UI" Font-Size="X-Large" ForeColor="White" />
        &nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Cancelled Orders" Font-Names="Segoe UI" Font-Size="X-Large" Height="69px" Width="343px" /><br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Returned Orders" BackColor="Gray" Font-Bold="True" Font-Names="Segoe UI" Font-Size="Large" ForeColor="White" Height="66px" Width="341px" />
        &nbsp; &nbsp; &nbsp; &nbsp;<asp:Button ID="Button7" runat="server" BackColor="#FFC0C0"
            Font-Bold="True" Font-Size="Large" ForeColor="White" Height="62px" Text="Bank"
            Width="346px" />
        &nbsp; &nbsp;&nbsp;<br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
    </form>
</body>
</html>
