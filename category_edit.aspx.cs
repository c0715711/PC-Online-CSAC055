﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication10
{
    public partial class category_edit : System.Web.UI.Page
    {
        public category_edit()
        {

        }
        public string cnstring = "Data Source=HARISHHARRY267\\SQLEXPRESS;Initial Catalog=praveen;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cnstring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string update = "update dbo.category set category_name ='" + TextBox1.Text.ToString() + "', category_id='" + TextBox2.Text.ToString() + "';";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();








                string myquery = "select DISTINCT category_id,category_name from [dbo].[category]";
                SqlConnection con1 = new SqlConnection(cnstring);
                SqlCommand insertcmd = new SqlCommand(myquery, con1);
                cmd.CommandText = myquery;
                cmd.Connection = con;

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);//communication b/w Dataset and SQL DB
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
    }
}