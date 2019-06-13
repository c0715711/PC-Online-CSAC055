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


    public partial class category_list : System.Web.UI.Page
    {

        public category_list()
        {

        }
        public string cnstring = "Data Source=HARISHHARRY267\\SQLEXPRESS;Initial Catalog=praveen;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cnstring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                //string a = "insert into [dbo].[category](category_id,category_name)values('" + TextBox2.Text.ToString() + "','" + TextBox1.Text.ToString() + "')";
               // SqlCommand cmd = new SqlCommand(myquery, con);
                //cmd.ExecuteNonQuery();

                // this("added successfully");

                string myquery = "select DISTINCT category_id,category_name from [dbo].[category]";
                SqlConnection con1 = new SqlConnection(cnstring);
                SqlCommand insertcmd = new SqlCommand(myquery, con1);
                insertcmd.CommandText = myquery;
                insertcmd.Connection = con;
                insertcmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(insertcmd);//communication b/w Dataset and SQL DB
                                                            //da.SelectCommand = cmd;

                DataSet ds = new DataSet();//it is kind of a box,use for single database tabales
                da.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("WebForm1.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}