<%@ Page Language="C#" AutoEventWireup="true" CodeFile="additems.aspx.cs" Inherits="additems" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Add Items</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <table align="Center"><tr><td>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/logo.png" Height="54px" Width="190px" />
        </td></tr></table>
        <hr /><br />
        <fieldset >
        <legend >Adding items</legend><br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname"
                ErrorMessage="RequiredFieldValidator" Font-Bold="True" Font-Names="Segoe UI">Enter product name</asp:RequiredFieldValidator><br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Type"></asp:Label>
            &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;<asp:DropDownList ID="ddtype" runat="server">
                <asp:ListItem Value="1">Toys</asp:ListItem>
                <asp:ListItem Value="2">Clothing</asp:ListItem>
                <asp:ListItem Value="3">Pushchairs</asp:ListItem>
                <asp:ListItem Value="4">Baby food</asp:ListItem>
                <asp:ListItem Value="5">Bathing</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList><br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label>&nbsp;&nbsp; &nbsp;
            &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;<asp:DropDownList ID="ddgen" runat="server">
                <asp:ListItem>boys</asp:ListItem>
                <asp:ListItem>girls</asp:ListItem>
                <asp:ListItem>infants</asp:ListItem>
                <asp:ListItem>general</asp:ListItem>
            </asp:DropDownList>
            &nbsp;<br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
            &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
            <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtprice"
                ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Names="Segoe UI"
                ValidationExpression="^[0-9]{10}$">Integers only</asp:RegularExpressionValidator><br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Image"></asp:Label>&nbsp;&nbsp; &nbsp;
            &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;
            <asp:DropDownList ID="ddimg" runat="server" Width="159px">
            </asp:DropDownList><br />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Description"></asp:Label>
            &nbsp; &nbsp;<asp:TextBox ID="txtdesc" runat="server" TextMode="MultiLine"></asp:TextBox><br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" Width="60px" />
            &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update" />
            &nbsp; &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete" /><br />
            <br />
            <asp:Label ID="Label6" runat="server"></asp:Label><br />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;
            &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;<br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">back to admin home</asp:LinkButton>
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp;&nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp;
            <br />
        </fieldset>
    </div>
    </form>
</body>
</html>
