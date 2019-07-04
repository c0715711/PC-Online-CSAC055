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
    public partial class products_edit : System.Web.UI.Page
    {
        public products_edit()
        {


        }
        public string cnstring = "Data Source=HARISHHARRY267\\SQLEXPRESS;Initial Catalog=praveen;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("products_add.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cnstring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string update = "update products set product_name ='" + TextBox3.Text.ToString() + "', sales_price='" + TextBox5.Text.ToString() + "' , available_quantity='" + ListBox1.Text.ToString() + "', product_id ='" + TextBox2.Text.ToString() + "' where category_name='" + DropDownList1.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                Response.Write("Data Updated");


                string myquery = "select * from products";
                SqlConnection con1 = new SqlConnection(cnstring);
                SqlCommand insertcmd = new SqlCommand(myquery, con1);
                cmd.CommandText = myquery;
                cmd.Connection = con1;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //SqlDataAdapter da = new SqlDataAdapter(cmd);//communication b/w Dataset and SQL DB
                //da.SelectCommand = cmd;

                DataSet ds = new DataSet();//it is kind of a box,use for single database tabales
                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                con.Close();
            }
            }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
}