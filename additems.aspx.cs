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
using System.Windows .Forms ;
using System.IO;

public partial class additems : System.Web.UI.Page
{
    connect c;
    SqlDataAdapter adp = new SqlDataAdapter();
    DataSet ds;
    string key;
    DataTable type=new DataTable ();
    private void GetImages()
    {
        try
        {
            string[] images = Directory.GetFiles(Server.MapPath("~/images/products/"));
            ArrayList imageList = new ArrayList();
            foreach (string image in images)
            {
                string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                imageList.Add(imageName);
            }
            ddimg.DataSource = imageList;
            ddimg.AppendDataBoundItems = true;
            ddimg.DataBind();
        }
        catch (Exception e)
        {
            Label6.Text = e.ToString();
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                try
                {
                    c = new connect();
                    c.cmd.CommandText = "select * from item where ID='0" + Request.QueryString["id"] + "'";
                    adp.SelectCommand = c.cmd;
                    ds = new DataSet();
                    adp.Fill(ds, "ads");
                    for (int i = 0; i < ds.Tables["ads"].Rows.Count; i++)
                    {
                        txtname.Text = (string)ds.Tables["ads"].Rows[i].ItemArray[2];
                        txtprice.Text = (string)ds.Tables["ads"].Rows[i].ItemArray[4];
                        txtdesc.Text = (string)ds.Tables["ads"].Rows[i].ItemArray[5];
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
                Button2.Enabled = false;

            }


            GetImages();
            GetItemType();
        }
        
    }

    private void GetItemType()
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "select Name from itemType where 1=1";
            adp.SelectCommand = c.cmd;
            adp.Fill(type);
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

           
    
    


    protected void Button2_Click(object sender, EventArgs e)
    {
        
        try
        {
            c = new connect();
            c.cmd.CommandText = "insert into item values(@TypeID,@Name,@Gender,@Price,@Descr,@Image,@Keyword)";
            c.cmd.Parameters.Add("@TypeID", SqlDbType.Int).Value = ddtype.SelectedValue;
            c.cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtname .Text;
            c.cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = ddgen.SelectedItem.Text;
            c.cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value = txtprice.Text;
            c.cmd.Parameters.Add("@Descr", SqlDbType.Text).Value = txtdesc.Text;
            c.cmd.Parameters.Add("@Image", SqlDbType.NVarChar).Value = ddimg.SelectedItem.Text;
            key = txtname.Text + txtdesc.Text + ddtype.SelectedItem.Text + ddgen.SelectedItem.Text;
            c.cmd.Parameters.Add("@Keyword", SqlDbType.NVarChar).Value = key;
            c.cmd.ExecuteNonQuery();
            Label6.Text = "Record Inserted"; 
          
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

     protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            c = new connect();
            c.cmd.CommandText = "delete item where ID='" + Request.QueryString["id"] + "'";
            c.cmd.ExecuteNonQuery();
            Label6.Text = "Record deleted";
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
    protected void Button3_Click(object sender, EventArgs e)
    {
       
       
            try
            {
                c = new connect();
                c.cmd.Parameters.Clear();
                long identity = Convert.ToInt32(Request.QueryString["id"]);             
                c.cmd.CommandText = "Update item set TypeID=@TypeID,Name=@Name,Gender=@Gender,Price=@Price,Descr=@Descr,Image=@Image,Keyword=@Keyword where ID=" + identity;
                c.cmd.Parameters.Add("@TypeID", SqlDbType.Int).Value = ddtype.SelectedValue;
                c.cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtname.Text;
                c.cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = ddgen.SelectedItem.Text;
                c.cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value =txtprice.Text;
                c.cmd.Parameters.Add("@Descr", SqlDbType.Text).Value =txtdesc.Text;
                c.cmd.Parameters.Add("@Image", SqlDbType.NVarChar).Value = ddimg.SelectedItem.Text;
                key = txtname.Text + txtdesc.Text + ddtype.SelectedItem.Text + ddgen.SelectedItem.Text; 
                c.cmd.Parameters.Add("@Keyword", SqlDbType.NVarChar).Value = key;
                c.cmd.ExecuteNonQuery();
                Label6.Text = "Records Updated";

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
    protected void txtname_TextChanged(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/manage.aspx");
    }
}