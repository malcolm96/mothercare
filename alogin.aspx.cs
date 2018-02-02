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
using System.Data .SqlClient ;

public partial class alogin : System.Web.UI.Page
{
    connect c;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "select count(*) from login where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            int obj = Convert.ToInt32(c.cmd.ExecuteScalar());
            Session["admin"] = TextBox1.Text;
            
            if (obj > 0)
            {
                Session["admin"] = "Admin"; 
                Response.Redirect("~/administration.aspx");
            }
        }
        catch (Exception )
        {
            throw;
        }
        finally
        {
            c.cnn.Close();
        }
            
            
     }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/aforgot.aspx");

    }
}
