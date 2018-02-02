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
using System.Data.SqlClient;

public partial class additemtype : System.Web.UI.Page
{
    connect c;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            //if(( TextBox1.Text = ""))
            //{
            //    Label2.Text = "enter the Item type";
            //}
            //else
            //{
                c = new connect();
                c.cmd.CommandText = "insert into itemType values(@Name)";
                c.cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = TextBox1.Text;
                c.cmd.ExecuteNonQuery();
                Label2.Text = TextBox1.Text + " added into the table";
                Response.Redirect("~/additems.aspx");
            //}
        }
        catch (Exception ex)
        {
            Label2.Text = ex.ToString();
        }
        finally
        {
            c.cnn.Close();
        }


    }
   
}
