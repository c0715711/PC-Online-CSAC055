using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication10
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        public WebForm1()
        {

        }
        public string cnstring = "Data Source=HARISHHARRY267\\SQLEXPRESS;Initial Catalog=praveen;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Visible = false;
            Label3.Visible = false;
        }

   

        protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
        {
            Label1.Visible = false;
            Label2.Visible = true;
            Label3.Visible = true;
            
            string myquery = "select DISTINCT category_name,[numberof_ products] from [dbo].[inventory_category]";
            SqlConnection con = new SqlConnection(cnstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();//communication b/w Dataset and SQL DB
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();//it is kind of a box,use for single database tabales
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

            string abcd = "select category_name,product_name,available_quantity from [dbo].[inventory_products]";
            SqlConnection con1 = new SqlConnection(cnstring);
            SqlCommand cmd1 = new SqlCommand();
            cmd.CommandText = abcd;
            cmd.Connection = con;

            SqlDataAdapter da1 = new SqlDataAdapter();//communication b/w Dataset and SQL DB
            da.SelectCommand = cmd;

            DataSet ds1 = new DataSet();//it is kind of a box,use for single database tabales
            da.Fill(ds1);
            GridView2.DataSource = ds1;
            GridView2.DataBind();

            con.Close();

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        
            {
                Session.Abandon();
                Session.Clear();
                Response.Redirect("login.aspx");
            }
        
    }
}