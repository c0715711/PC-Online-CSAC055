using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BotDetect;
using BotDetect.Web;
using BotDetect.Web.UI;



namespace Captcha


{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public WebForm1()
        {
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string cnstring = "Data Source=HARISHHARRY267\\SQLEXPRESS;Initial Catalog=praveen;Integrated Security=True";



        protected void Button1_Click1(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(cnstring);
            con.Open();
            bool correct = CaptchaBox.Validate(TextBox1.Text);
            TextBox1.Text = null;
            if (correct)
            {

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string a = "insert into login_table(First_name,Last_name,Username,Password,confirm_password)values('" + firstname.Text.ToString() + "','" + lastname.Text.ToString() + "','" + username.Text.ToString() + "','" + password.Text.ToString() + "','" + confirmpassword.Text.ToString() + "')";
                    SqlCommand bbb = new SqlCommand(a, con);
                    bbb.ExecuteNonQuery();
                    Label1.Text = "sign up complete";
                    Response.Redirect("webform2.aspx");

                }
                else
                {
                    Response.Write("Please enter all the details");
                }


            }

            else
            {
                Response.Write("Invalid captcha");
            }
        }
    }
}

