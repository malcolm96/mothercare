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

public partial class boystoys : System.Web.UI.Page
{
    connect c;
    SqlDataAdapter adp = new SqlDataAdapter();
    DataSet ds = new DataSet();
    DataTable dt1 = new DataTable();
    DataTable dt2 = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {

        fillpage();


        if (CBox1.Checked)
        {

            sort1();
        }
        if (CBox2.Checked)
        {

            sort2();
        }
        if (CBox3.Checked)
        {

            sort3();
        }
        if (CheckBox1.Checked)
        {

            sort4();
        }
        if (!string.IsNullOrEmpty((string)Session["userid"]))
        {
            try
            {

                c = new connect();
                c.cmd.CommandText = "select * from cart where ClientID='" + (string)Session["userid"] + "'";
                adp.SelectCommand = c.cmd;
                adp.Fill(dt2);
                int count = dt2.Rows.Count;
                Label1.Text = count.ToString();

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

    private void sort4()
    {
        if (IsPostBack)
        {


            pnlProducts.Controls.Clear();
            try
            {
                c = new connect();
                c.cmd.CommandText = "select * from item where (Price>=2000) and (TypeID=1 and Gender='boys') ";
                adp.SelectCommand = c.cmd;
                DataTable dt = new DataTable();
                adp.Fill(dt);
                Button[] b1 = new Button[dt.Rows.Count];
                Button[] b2 = new Button[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    Panel productPanel = new Panel();

                    ImageButton imageButton = new ImageButton();
                    Label lblname = new Label();
                    Label lblprice = new Label();
                    Literal l1 = new Literal();
                    Literal l2 = new Literal();
                    Literal l3 = new Literal();
                    l3.Text = "<br/>";
                    Literal l4 = new Literal();
                    l4.Text = "&nbsp;&nbsp;";
                    b1[i] = new Button();
                    b1[i].Text = "Add to Cart";
                    b1[i].CssClass = "b1";
                    b1[i].Attributes.Add("ID", dt.Rows[i].ItemArray[0].ToString());
                    b1[i].Click += b1_Click;
                    b2[i] = new Button();
                    b2[i].CssClass = "b2";
                    b2[i].Text = "View";
                    b2[i].Attributes.Add("ID", dt.Rows[i].ItemArray[0].ToString());
                    b2[i].Click += new EventHandler(b2_Click);
                    l1.Text = "</br>";
                    l2.Text = "</br>";
                    imageButton.ImageUrl = "~/images/products/" + dt.Rows[i].ItemArray[6];
                    imageButton.CssClass = "productImage";
                    imageButton.PostBackUrl = "~/viewrecord.aspx?id=" + dt.Rows[i].ItemArray[0];
                    lblname.Text = (string)dt.Rows[i].ItemArray[2];
                    lblname.CssClass = "productName";
                    lblprice.Text = "Rs." + (string)dt.Rows[i].ItemArray[4];
                    lblprice.CssClass = "productPrice";
                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(l1);
                    productPanel.Controls.Add(lblname);
                    productPanel.Controls.Add(l2);
                    productPanel.Controls.Add(lblprice);
                    productPanel.Controls.Add(l3);
                    productPanel.Controls.Add(b1[i]);
                    productPanel.Controls.Add(l4);
                    productPanel.Controls.Add(b2[i]);
                    Panel prod = new Panel();
                    prod.CssClass = "prod";
                    prod.Controls.Add(productPanel);
                    pnlProducts.Controls.Add(prod);
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

    private void sort3()
    {
        if (IsPostBack)
        {

            pnlProducts.Controls.Clear();
            try
            {
                c = new connect();
                c.cmd.CommandText = "select * from item where (Price>=1000 and Price<=1500) and (TypeID=1 and Gender='boys') ";
                adp.SelectCommand = c.cmd;
                ds.Clear();
                adp.Fill(ds, "chk3");
                for (int i = 0; i < ds.Tables["chk3"].Rows.Count; i++)
                {

                    Panel productPanel = new Panel();
                    Button b1 = new Button();
                    Button b2 = new Button();
                    ImageButton imageButton = new ImageButton();
                    Label lblname = new Label();
                    Label lblprice = new Label();
                    Literal l1 = new Literal();
                    Literal l2 = new Literal();
                    Literal l3 = new Literal();
                    l3.Text = "<br/>";
                    Literal l4 = new Literal();
                    l4.Text = "&nbsp;&nbsp;";

                    b1.Text = "Add to Cart";
                    b1.CssClass = "b1";
                    b1.Attributes.Add("ID", ds.Tables["chk3"].Rows[i].ItemArray[0].ToString());
                    b1.Click += b1_Click;

                    b2.CssClass = "b2";
                    b2.Text = "View";
                    b2.Attributes.Add("ID", ds.Tables["chk3"].Rows[i].ItemArray[0].ToString());
                    b2.Click += b2_Click;
                    l1.Text = "</br>";
                    l2.Text = "</br>";
                    imageButton.ImageUrl = "~/images/products/" + ds.Tables["chk3"].Rows[i].ItemArray[6];
                    imageButton.CssClass = "productImage";
                    imageButton.PostBackUrl = "~/viewrecord.aspx?id=" + ds.Tables["chk3"].Rows[i].ItemArray[0];
                    lblname.Text = (string)ds.Tables["chk3"].Rows[i].ItemArray[2];
                    lblname.CssClass = "productName";
                    lblprice.Text = "Rs." + (string)ds.Tables["chk3"].Rows[i].ItemArray[4];
                    lblprice.CssClass = "productPrice";
                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(l1);
                    productPanel.Controls.Add(lblname);
                    productPanel.Controls.Add(l2);
                    productPanel.Controls.Add(lblprice);
                    productPanel.Controls.Add(l3);
                    productPanel.Controls.Add(b1);
                    productPanel.Controls.Add(l4);
                    productPanel.Controls.Add(b2);
                    Panel prod = new Panel();
                    prod.CssClass = "prod";
                    prod.Controls.Add(productPanel);
                    pnlProducts.Controls.Add(prod);
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

    private void sort2()
    {
        if (IsPostBack)
        {

            pnlProducts.Controls.Clear();

            try
            {
                c = new connect();
                c.cmd.CommandText = "select * from item where (Price>=800 and Price<=1000) and (TypeID=1 and Gender='boys') ";
                adp.SelectCommand = c.cmd;
                ds.Clear();
                adp.Fill(ds, "chk2");
                for (int i = 0; i < ds.Tables["chk2"].Rows.Count; i++)
                {

                    Panel productPanel = new Panel();
                    Button b1 = new Button();
                    Button b2 = new Button();
                    ImageButton imageButton = new ImageButton();
                    Label lblname = new Label();
                    Label lblprice = new Label();
                    Literal l1 = new Literal();
                    Literal l2 = new Literal();
                    Literal l3 = new Literal();
                    l3.Text = "<br/>";
                    Literal l4 = new Literal();
                    l4.Text = "&nbsp;&nbsp;";

                    b1.Text = "Add to Cart";
                    b1.CssClass = "b1";
                    b1.Attributes.Add("ID", ds.Tables["chk2"].Rows[i].ItemArray[0].ToString());
                    b1.Click += b1_Click;

                    b2.CssClass = "b2";
                    b2.Text = "View";
                    b2.Attributes.Add("ID", ds.Tables["chk2"].Rows[i].ItemArray[0].ToString());
                    b2.Click += b2_Click;
                    l1.Text = "</br>";
                    l2.Text = "</br>";
                    imageButton.ImageUrl = "~/images/products/" + ds.Tables["chk2"].Rows[i].ItemArray[6];
                    imageButton.CssClass = "productImage";
                    imageButton.PostBackUrl = "~/viewrecord.aspx?id=" + ds.Tables["chk2"].Rows[i].ItemArray[0];
                    lblname.Text = (string)ds.Tables["chk2"].Rows[i].ItemArray[2];
                    lblname.CssClass = "productName";
                    lblprice.Text = "Rs." + (string)ds.Tables["chk2"].Rows[i].ItemArray[4];
                    lblprice.CssClass = "productPrice";
                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(l1);
                    productPanel.Controls.Add(lblname);
                    productPanel.Controls.Add(l2);
                    productPanel.Controls.Add(lblprice);
                    productPanel.Controls.Add(l3);
                    productPanel.Controls.Add(b1);
                    productPanel.Controls.Add(l4);
                    productPanel.Controls.Add(b2);
                    Panel prod = new Panel();
                    prod.CssClass = "prod";
                    prod.Controls.Add(productPanel);
                    pnlProducts.Controls.Add(prod);
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

    private void sort1()
    {
        if (IsPostBack)
        {
            pnlProducts.Controls.Clear();

            try
            {
                c = new connect();
                c.cmd.CommandText = "select * from item where (Price>=400 and Price<=800) and (TypeID=1 and Gender='boys') ";
                adp.SelectCommand = c.cmd;
                ds.Clear();
                adp.Fill(ds, "chk1");
                for (int i = 0; i < ds.Tables["chk1"].Rows.Count; i++)
                {

                    Panel productPanel = new Panel();
                    Button b1 = new Button();
                    Button b2 = new Button();
                    ImageButton imageButton = new ImageButton();
                    Label lblname = new Label();
                    Label lblprice = new Label();
                    Literal l1 = new Literal();
                    Literal l2 = new Literal();
                    Literal l3 = new Literal();
                    l3.Text = "<br/>";
                    Literal l4 = new Literal();
                    l4.Text = "&nbsp;&nbsp;";

                    b1.Text = "Add to Cart";
                    b1.CssClass = "b1";
                    b1.Attributes.Add("ID", ds.Tables["chk1"].Rows[i].ItemArray[0].ToString());
                    b1.Click += b1_Click;

                    b2.CssClass = "b2";
                    b2.Text = "View";
                    b2.Attributes.Add("ID", ds.Tables["chk1"].Rows[i].ItemArray[0].ToString());
                    b2.Click += b2_Click;
                    l1.Text = "</br>";
                    l2.Text = "</br>";
                    imageButton.ImageUrl = "~/images/products/" + ds.Tables["chk1"].Rows[i].ItemArray[6];
                    imageButton.CssClass = "productImage";
                    imageButton.PostBackUrl = "~/viewrecord.aspx?id=" + ds.Tables["chk1"].Rows[i].ItemArray[0];
                    lblname.Text = (string)ds.Tables["chk1"].Rows[i].ItemArray[2];
                    lblname.CssClass = "productName";
                    lblprice.Text = "Rs." + (string)ds.Tables["chk1"].Rows[i].ItemArray[4];
                    lblprice.CssClass = "productPrice";
                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(l1);
                    productPanel.Controls.Add(lblname);
                    productPanel.Controls.Add(l2);
                    productPanel.Controls.Add(lblprice);
                    productPanel.Controls.Add(l3);
                    productPanel.Controls.Add(b1);
                    productPanel.Controls.Add(l4);
                    productPanel.Controls.Add(b2);
                    Panel prod = new Panel();
                    prod.CssClass = "prod";
                    prod.Controls.Add(productPanel);
                    pnlProducts.Controls.Add(prod);
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

    private void fillpage()
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "select * from item where TypeID=1 and Gender='boys'";
            adp.SelectCommand = c.cmd;
            ds.Clear();
            pnlProducts.Controls.Clear();
            adp.Fill(ds, "itm");

            if (ds.Tables["itm"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["itm"].Rows.Count; i++)
                {

                    Panel productPanel = new Panel();
                    Button b1 = new Button();
                    Button b2 = new Button();
                    ImageButton imageButton = new ImageButton();
                    Label lblname = new Label();
                    Label lblprice = new Label();
                    Literal l1 = new Literal();
                    Literal l2 = new Literal();
                    Literal l3 = new Literal();
                    l3.Text = "<br/>";
                    Literal l4 = new Literal();
                    l4.Text = "&nbsp;&nbsp;";

                    b1.Text = "Add to Cart";
                    b1.CssClass = "b1";
                    b1.Attributes.Add("ID", ds.Tables["itm"].Rows[i].ItemArray[0].ToString());
                    b1.Click += b1_Click;

                    b2.CssClass = "b2";
                    b2.Text = "View";
                    b2.Attributes.Add("ID", ds.Tables["itm"].Rows[i].ItemArray[0].ToString());
                    b2.Click += b2_Click;
                    l1.Text = "</br>";
                    l2.Text = "</br>";
                    imageButton.ImageUrl = "~/images/products/" + ds.Tables["itm"].Rows[i].ItemArray[6];
                    imageButton.CssClass = "productImage";
                    imageButton.PostBackUrl = "~/viewrecord.aspx?id=" + ds.Tables["itm"].Rows[i].ItemArray[0];
                    lblname.Text = (string)ds.Tables["itm"].Rows[i].ItemArray[2];
                    lblname.CssClass = "productName";
                    lblprice.Text = "Rs." + (string)ds.Tables["itm"].Rows[i].ItemArray[4];
                    lblprice.CssClass = "productPrice";
                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(l1);
                    productPanel.Controls.Add(lblname);
                    productPanel.Controls.Add(l2);
                    productPanel.Controls.Add(lblprice);
                    productPanel.Controls.Add(l3);
                    productPanel.Controls.Add(b1);
                    productPanel.Controls.Add(l4);
                    productPanel.Controls.Add(b2);
                    Panel prod = new Panel();
                    prod.CssClass = "prod";
                    prod.Controls.Add(productPanel);
                    pnlProducts.Controls.Add(prod);
                }

            }
            else
            {

                Response.Write("<center><h2>NO RECORDS FOUND</h2>");
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
    private void b1_Click(object sender, EventArgs e)
    {
        Button a = (Button)sender;

        try
        {
            string clientID = (string)Session["userid"];
            if (clientID != null)
            {
                c = new connect();
                c.cmd.CommandText = "select * from Cart where ClientID='" + clientID + "' and ProductID='" + a.Attributes["ID"].ToString() + "'";
                adp.SelectCommand = c.cmd;
                dt1.Clear();
                adp.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Item already exists in cart, Please update the quantity in cart')</script>");
                    Response.AddHeader("REFRESH", "0:URL=view.aspx");
                }

                else
                {

                    c = new connect();
                    c.cmd.CommandText = "insert into Cart values(@ClientID,@ProductID,@Amount,@DatePurchased,@IsInCart)";
                    c.cmd.Parameters.Add("@ClientID", SqlDbType.NVarChar).Value = (string)Session["userid"];
                    c.cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar).Value = a.Attributes["ID"].ToString();
                    c.cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = 1;
                    c.cmd.Parameters.Add("@DatePurchased", SqlDbType.DateTime).Value = DateTime.Now;
                    c.cmd.Parameters.Add("@IsInCart", SqlDbType.Bit).Value = 1;
                    c.cmd.ExecuteNonQuery();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Item added to cart')</script>");
                    Response.AddHeader("REFRESH", "0:URL=view.aspx");
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Please login to add items into your cart')</script>");
                Response.AddHeader("REFRESH", "0:URL=login.aspx");
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
    
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/login.aspx");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/trackorder.aspx");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/wishlist.aspx");
    }
    protected void imghelp_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/help.aspx");
    }
    protected void imgcart_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/cart.aspx");
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/search.aspx?search=" + TextBox1.Text);
    }
    protected void CBox1_CheckedChanged(object sender, EventArgs e)
    {
        CBox2.Checked = !CBox1.Checked;
        CBox3.Checked = !CBox1.Checked;
        CheckBox1.Checked = !CBox1.Checked;


    }
    protected void CBox2_CheckedChanged(object sender, EventArgs e)
    {
        CBox1.Checked = !CBox2.Checked;
        CBox3.Checked = !CBox2.Checked;
        CheckBox1.Checked=!CBox2.Checked;
        
        

    }
    protected void CBox3_CheckedChanged(object sender, EventArgs e)
    {
        CBox1.Checked = !CBox3.Checked;
        CBox2.Checked = !CBox3.Checked;
        CheckBox1.Checked = !CBox3.Checked;
    
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        CBox1.Checked = !CheckBox1.Checked;
        CBox2.Checked = !CheckBox1.Checked;
        CBox3.Checked = !CheckBox1.Checked;
        
    }
    protected void b2_Click(object sender, EventArgs e)
    {
       
        Button b = (Button)sender;
        Response.Redirect("~/viewrecord.aspx?id=" + b.Attributes["ID"]);
        
    }
}
