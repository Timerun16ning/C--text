using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_denglu
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            int n = ran.Next(1000);
            string str = Convert.ToString(n);
            TextBox4.Text = str;
        }

        protected void Button_ok_Click(object sender, EventArgs e)
        {
            string user_name;
            user_name = TextBox1.Text;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "myscript", "<script>confirm('登陆成功')</script>");
       }

        protected void Button_re_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}