using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Captcha
{
    public partial class main_page : System.Web.UI.Page
    {
        public main_page()
        {

        }
        public string cnstring = "Data Source=HARISHHARRY267\\SQLEXPRESS;Initial Catalog=praveen;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {


            string myquery = "select * from [dbo].[category]";
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
                da1.SelectCommand = cmd;
            DataSet ds1 = new DataSet();//it is kind of a box,use for single database tabales

            

                da.Fill(ds1);
                GridView2.DataSource = ds1;
                GridView2.DataBind();
            

            


                con.Close();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_category");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}