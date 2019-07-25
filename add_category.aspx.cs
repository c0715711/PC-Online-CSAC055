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
    public partial class add_category : System.Web.UI.Page
    {

        public add_category()
        {

        }
        public string cnstring = "Data Source=HARISHHARRY267\\SQLEXPRESS;Initial Catalog=praveen;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)

        {
           // if (Session["Username"] == null)
            //{
              //  Response.Redirect("WebForm2.aspx");
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //Session["Username"] = null;
            //Session["Password"] = null;
            Response.Redirect("WebForm2.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cnstring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string a = "insert into [dbo].[category](category_Id,category_name,numberof_products) values('" + TextBox2.Text.ToString() + "','" + TextBox1.Text.ToString() + "','" + TextBox3.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(a, con);
                cmd.ExecuteNonQuery();

                // this("added successfully");

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







    }

}
