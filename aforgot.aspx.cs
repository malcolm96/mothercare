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
using System.Windows .Forms ;

public partial class aforgot : System.Web.UI.Page
{
    connect c;
    SqlDataAdapter adp = new SqlDataAdapter();
    DataTable dt=new DataTable ();
    string pass;
    protected void Page_Load(object sender, EventArgs e)
    {
 

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "select * from login where Username='" + txtmail.Text + "' and Phone='" + txtnum.Text + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    pass = dt.Rows[i].ItemArray[2].ToString();
                }
                MessageBox.Show("your password:" + pass);
                Server.Transfer("~/alogin.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Invalid username and email')</script>");
            }
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
