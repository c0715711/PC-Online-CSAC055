using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Captcha
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public WebForm2()
        {
        }
        public string cnstring = "Data Source=HARISHHARRY267\\SQLEXPRESS;Initial Catalog=praveen;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("signup.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cnstring);
            try
            {
                string uid = TextBox1.Text;
                string pass = TextBox2.Text;
                con.Open();
                string qry = "select * from login_table where Username='" + uid + "' and Password='" + pass + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Session["Username"] = TextBox1.Text;
                    Session["Password"] = TextBox2.Text;
                    Label3.Text = "Login Sucess......!!";
                    Response.Redirect("main_page.aspx");
                }
                else
                {
                    Label3.Text = "UserId & Password Is not correct Try again..!!";

                }
                con.Close();
            }


            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }


        }
    }
}