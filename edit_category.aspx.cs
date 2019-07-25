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
    public partial class edit_category : System.Web.UI.Page
    {
        public edit_category()
        {

        }
        public string cnstring = "Data Source=HARISHHARRY267\\SQLEXPRESS;Initial Catalog=praveen;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
           // if (Session["Username"] == null)
            //{
               // Response.Redirect("WebForm2.aspx");
            //} 
            string myquery = "select * from [dbo].[category]";
            SqlConnection con = new SqlConnection(cnstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();//communication b/w Dataset and SQL DB
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();//it is kind of a box,use for single database tabales




                              da.Fill(ds);
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cnstring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string update = "update dbo.category set category_name ='" + TextBox1.Text.ToString() + "', numberof_products='" + TextBox3.Text.ToString() + "' where category_Id='" + TextBox2.Text.ToString()+"'";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                Response.Write("Data Updated");


                string myquery = "select * from [dbo].[category]";
                SqlConnection con1 = new SqlConnection(cnstring);
                SqlCommand insertcmd = new SqlCommand(myquery, con1);
                cmd.CommandText = myquery;
                cmd.Connection = con1;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //SqlDataAdapter da = new SqlDataAdapter(cmd);//communication b/w Dataset and SQL DB
                //da.SelectCommand = cmd;

                DataSet ds = new DataSet();//it is kind of a box,use for single database tabales
                da.Fill(ds);

                GridView1.DataBind();
                
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //Session["Username"] = null;
            //Session["Password"] = null;
            Response.Redirect("WebForm2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Response.Redirect("add_category.aspx");

        }

       
        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("edit_category.aspx");
        }
    }
}