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
    public partial class product_list : System.Web.UI.Page
    {
        public product_list()
        {

        }
        public string cnstring = "Data Source=DESKTOP-5PSVBQE\\SQLEXPRESS;Initial Catalog = rupesh; Integrated Security = True";



        protected void Page_Load(object sender, EventArgs e)
        {
            string myquery = "select * from [dbo].[products]";
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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
    }
