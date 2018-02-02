<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bathing.aspx.cs" Inherits="bathing" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Bathing</title>
       <style type ="text/css">
    #nav ul
{
list-style:none;
}     
#nav
   {
   position:absolute;
width:100%;
height:auto;
margin-left:auto;
margin-right:auto;
   }
#nav ul li
{
float:left;
width:130px;
heigh:60px;
background-color:#37707A;

line-height:60px;
;
text-align:center;
opacity=0.7;
filter:alpha(opacity=70);
}
#nav ul li a
{

color:white;
font-family:segoe UI;
font-weight:bold;
text-decoration:none;
}
#nav ul li:hover
{
background-color:red;
transition:all 0.45s;
opacity:0.9;
filter:alpha(opacity=90);
}
#nav ul li ul li
{

display:none;
}
#nav ul li:hover ul li
{
text-transform:uppercase;
display:block;
z-index:99;
position:100%;


margin-left:-40px;

}
 #pnlProducts div{
    float:left;
    width:250px;
    height:250px;
    text-align:center;
    }
    .productImage{
    width:150px;
    height:150px;
    vertical-align:central;
    padding:10px;
    border-radius:50px;
    -moz-border-radius:50px;
    -website-border-radius:50px;
    }
    .productName{
    font-size:18px;
    font-style:Segoue UI;
    }
    .productPrice{
    font-family:Segoue UI;
    color:red;
    }
    .b1{
    background-color:#FF6501;
    color:white;
  
    font-family:Segoe UI;
    border-radius:4px;
-moz-border-radius:4px;
-webkit-border-radius:4px;
clear:both;
    }
    .b2{
    background-color:green;
    color:white;
   
    font-family:Segoe UI;
    border-radius:4px;
-moz-border-radius:4px;
-webkit-border-radius:4px;
clear:both;
    }
    .prod:hover
    {
    backgroud-color:#003B4D;
    opacity:0.7;
    filer:alpha(opacity=70);
    transition: all 0.45s;
    }
    
    .productName{
    font-size:15px;
    font-family:Segoe UI;
    }
    .productPrice
    {
    font-family:Segoe UI;
    color:red;
    }

    </style>
<script language="javascript" type="text/javascript">
// <!CDATA[

function IMG1_onclick() {

}

// ]]>
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" ><tr><td style ="width:150px">
        <asp:ImageButton ID="ImageButton1" runat="server" Height="39px" ImageUrl="~/images/signup.png"
            Width="39px" OnClick="ImageButton1_Click" /></td>
       <td style ="width:150px"><asp:ImageButton ID="ImageButton2" runat="server"
              Height="45px" ImageUrl="~/images/truck.png" Width="63px" OnClick="ImageButton2_Click" /></td>
          <td style ="width:150px"><asp:ImageButton ID="ImageButton3"
              runat="server" Height="46px" ImageUrl="~/images/wishlist.png" Width="63px" OnClick="ImageButton3_Click" /></td>
              <td style ="width:150px">
              <asp:ImageButton ID="imghelp" runat ="server" ImageUrl ="~/images/questionmarkbutton.png" Height="46px" OnClick="imghelp_Click1" />
              </td>
              <td style="width:12px"><asp:ImageButton ID="imgcart" runat ="server" ImageUrl ="~/images/cartimg.jpg" Height="48px" OnClick="imgcart_Click2" /></td>
           <td>
               <asp:Label ID="Label1" runat="server" BackColor="#FFFFFF" Font-Bold="True" Font-Names="Segoe UI" ForeColor="#336699"></asp:Label></td>
        </tr>
        </table>
        <hr />
          <table align="center" >
        <tr>
        <td>
        <img src="images\logo.png" alt ="" width="190" height ="54" id="IMG1" onclick="return IMG1_onclick()" />
        </td></tr>
        </table>
        <table align="center" ><tr><td>
           <span style="font-size: 14pt; font-family: Candara"></span><asp:TextBox ID="TextBox1" placeholder="Search Items" runat="server" Width="468px" Height="28px"></asp:TextBox></td>
        <td><asp:ImageButton ID="ImageButton4" runat="server" Height="28px" ImageUrl="~/images/search.png"
            Width="28px" OnClick="ImageButton4_Click"/></td></tr></table>
            <hr />
            <div id="nav">
        <ul>
        <li><a href ="home.aspx"><span style="font-family: Segoe UI">HOME</span></a></li>
        <li><a href ="newin.aspx"><span style="font-family: Segoe UI">NEW IN</span></a><span style="font-family: Segoe UI">
        </span></li>
        <li><a href ="clothing.aspx"><span style="font-family: Segoe UI">CLOTHING</span></a><span style="font-family: Segoe UI">
        </span>
        <ul>
        <li><a href ="boysclothing.aspx"><span style="font-family: Segoe UI">Boys</span></a><span style="font-family: Segoe UI">
        </span></li>
        <li><a href ="girlsclothing.aspx"><span style="font-family: Segoe UI">girls</span></a><span style="font-family: Segoe UI">
        </span></li>
        <li><a href ="infantsclothing.aspx"><span style="font-family: Segoe UI">infants</span></a><span style="font-family: Segoe UI">
        </span></li>
        </ul>
        </li> 
        <li><a href ="toys.aspx"><span style="font-family: Segoe UI">TOYS</span></a><span style="font-family: Segoe UI">
        </span>
        <ul>
        <li><a href ="boystoys.aspx"><span style="font-family: Segoe UI">Boys</span></a><span style="font-family: Segoe UI">
        </span></li>
        <li><a href ="girlstoys.aspx"><span style="font-family: Segoe UI">girls</span></a><span style="font-family: Segoe UI">
        </span></li>
        <li><a href ="infantstoys.aspx"><span style="font-family: Segoe UI">infants</span></a><span style="font-family: Segoe UI">
        </span></li>
        </ul>
        </li> 
        <li><a href ="pushchairs.aspx"><span style="font-family: Segoe UI">PUSHCHAIRS</span></a><span style="font-family: Segoe UI">
        </span></li>
        <li><a href ="babyfood.aspx"><span style="font-family: Segoe UI">BABY FOOD</span></a><span style="font-family: Segoe UI">
        </span></li>
        <li><a href ="bathing.aspx"><span style="font-family: Segoe UI">BATHING</span></a><span style="font-family: Segoe UI">
        </span></li>
        </ul> 
     </div>
     <br />
     <br />
     <br />
     <br />
     <hr />
     <span style="font-family: Segoe UI">Sort by price:&nbsp;</span>
            &nbsp;<asp:CheckBox
                ID="CBox1" runat="server" Font-Bold="True" Text="400-800" BorderStyle="None" CssClass="inputs" Width="113px" AutoPostBack ="true" OnCheckedChanged="CBox1_CheckedChanged"  />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp;
            <asp:CheckBox ID="CBox2" runat="server" Font-Bold="True" Text="800-1000" CssClass="inputs" Width="98px"  AutoPostBack="true" OnCheckedChanged="CBox2_CheckedChanged" />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;<asp:CheckBox
                ID="CBox3" runat="server" Font-Bold="True" Text="1000-1500" Width="102px" CssClass="inputs"  AutoPostBack="true" OnCheckedChanged="CBox3_CheckedChanged"  />
            &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox1" runat="server" Font-Bold="True" Text="1500-3000" CssClass="inputs" Width="103px"  AutoPostBack ="true" OnCheckedChanged="CheckBox1_CheckedChanged"  />
            <hr />
     <asp:Panel ID="pnlProducts" Width="1050px" runat="server" ></asp:Panel>
    </div>
    </form>
</body>
</html>