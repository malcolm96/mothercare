<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CancelOrder.aspx.cs" Inherits="CancelOrder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <div style="text-align: center">
       <table ><tr>
       <td style="width: 350px"><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/home.png" Width="74px" />
           &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
           &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
           &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</td>
        <td style ="width :200px"><img id="IMG1" alt="" height="54" onclick="return IMG1_onclick()" src="images/logo.png" width="190" />
         </td>
           </tr>
         </table>
        
        <hr />
    </div><div><asp:Panel ID="panel1" runat="server" Height="239px" Width="751px" ><table> <tr><td rowspan="6"><asp:ImageButton id="imgb1" runat ="server" Height="150px" Width="150px" /><br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </td></tr>
    <tr><td style="width: 87px"><b><asp:Label ID="label1" runat ="server" Font-Names="Segoe UI" ></asp:Label></b></td>
    <td rowspan ="6" style="width: 503px"><asp:Panel ID="PnlBank" runat ="Server" Visible="False" Width="300px" ><fieldset ><legend >Bank details:</legend>
        <asp:Label ID="Label11" runat="server" Text="Account Holder's Name"></asp:Label><br />
        <asp:TextBox ID="txtaccname" runat="server"></asp:TextBox><br />
        <br />
        <asp:Label ID="Label6" runat="server" Font-Names="Segoe UI" Text="Bank Name:"></asp:Label><br />
        <asp:TextBox ID="txtbnkname" runat="server"></asp:TextBox><br />
        <br />
        <asp:Label ID="Label7" runat="server" Font-Names="Segoe UI" Text="Bank Account number:"></asp:Label><br />
        <asp:TextBox ID="txtaccnum" runat="server"></asp:TextBox><br />
        <br />
        <asp:Label ID="Label8" runat="server" Font-Names="Segoe UI" Text="IFSC Code"></asp:Label><br />
        <asp:TextBox ID="txtifsc" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" /><br />
        <br />
        <br />
        <br />
     </fieldset>   
    </asp:Panel> 
        <asp:Label ID="lblbnk" runat="server"></asp:Label></td></tr>
    <tr><td style="width: 87px">
        <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Quantity:"></asp:Label>
        &nbsp;
        <asp:Label ID="label2" runat ="server" Font-Names="Segoe UI" ></asp:Label><br />
        <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Price:"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Label id="Label3" runat ="server" ></asp:Label></td></tr>
    <tr><td style="width: 87px"><b><asp:Label ID="label4" runat ="server" Text ="Why are you returning this?" Font-Names="Segoe UI" Width="234px"></asp:Label></b></td></tr>
    <tr><td style="width: 87px; height: 24px;"><asp:DropDownList ID="ddl1" runat ="server">
        <asp:ListItem Value="Performence or quality not adequate">Performence or quality not adequate</asp:ListItem>
        <asp:ListItem>Product damaged but shipping box OK..</asp:ListItem>
        <asp:ListItem>Missing parts or accessories</asp:ListItem>
        <asp:ListItem Value="Both product and shipping  box damaged">Both product and shipping </asp:ListItem>
        <asp:ListItem>Both product and shipping box damaged</asp:ListItem>
        <asp:ListItem>Wrong item was sent</asp:ListItem>
        <asp:ListItem>Item defective or doesnt work</asp:ListItem>
        <asp:ListItem></asp:ListItem>
    </asp:DropDownList></td></tr>
     </table>
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="70px" TextMode="MultiLine" Width="262px"></asp:TextBox><br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cancel Order" /><br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server"></asp:Label></asp:Panel>
        &nbsp;</div>
    </form>
</body>
</html>
