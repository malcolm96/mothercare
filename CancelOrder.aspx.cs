using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data .SqlClient;

public partial class CancelOrder : System.Web.UI.Page
{
    connect c;
    SqlDataAdapter adp=new SqlDataAdapter ();
    string comments = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        imgb1.ImageUrl = "~/images/Products/" + (string)Session["PIMAGE"];
        label1.Text = (string)Session["PRODUCT"];
        label2 .Text =(string)Session ["QUANTITY"];
        Label3 .Text =(string)Session ["PRICE"];
        if ((string)Session["PAY"] == "Credit Card" || (string)Session["PAY"] == "Debit Card")
        {
            PnlBank.Visible = true;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "insert into cancel values(@Username,@Billno,@Pname,@Quantity,@Reason,@Additional,@Acknowledged,@DatePurchased)";
            c.cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = (string)Session["userid"];
            c.cmd.Parameters.Add("@Billno", SqlDbType.NVarChar).Value = (string)Session["BILL"];
            c.cmd.Parameters.Add("@Pname", SqlDbType.NVarChar).Value = (string)Session["PRODUCT"];
            c.cmd.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = (string)Session["Quantity"];
            c.cmd.Parameters.Add("@Reason", SqlDbType.NVarChar).Value = ddl1.SelectedItem.Text;
            comments = TextBox1.Text;
            c.cmd.Parameters.Add("@Additional", SqlDbType.NVarChar).Value = comments;
            c.cmd.Parameters.Add("@Acknowledged", SqlDbType.NVarChar).Value = "No";
            c.cmd.Parameters.Add("@DatePurchased", SqlDbType.DateTime).Value = DateTime.Now;
            c.cmd.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            c.cnn.Close();
        }
        Label5.Text = "Your Order cancel request has been recieved";

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "insert into bank values(@Username,@Pname,@Billno,@AccountName,@BankName,@IFSC,@AccountNumber,@RefundAmount,@Acknowledged)";
            c.cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = (string)Session["userid"];
            c.cmd.Parameters.Add("@Pname", SqlDbType.NVarChar).Value = (string)Session["PRODUCT"];
            c.cmd.Parameters.Add("@Billno", SqlDbType.NVarChar).Value = (string)Session["BILL"];
            c.cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar).Value = txtaccname.Text;
            c.cmd.Parameters.Add("@BankName", SqlDbType.NVarChar).Value = txtbnkname.Text;
            c.cmd.Parameters.Add("@IFSC", SqlDbType.NVarChar).Value = txtifsc.Text;
            c.cmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = txtaccnum.Text;
            c.cmd.Parameters.Add("@RefundAmount", SqlDbType.NVarChar).Value = (string)Session["PRICE"];
            c.cmd.Parameters.Add("@Acknowledged", SqlDbType.NChar).Value = "No";
            c.cmd.ExecuteNonQuery();
            lblbnk.Text = "Bank Details recieved. Please wait for atleast 7 days for the same to process";
            PnlBank.Visible = false;
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            c.cnn.Close();
        }
    }
}
