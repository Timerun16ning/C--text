using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
//引用这两个命名空间

namespace WebApplication_denglu
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //接收Ajax传入的参数
            string userName = context.Request["userName"].ToString().Trim();//不用.ToString()也可以
            string passWord = context.Request["passWord"].ToString().Trim();//Trim()函数用于去除字符串中的空格

            try
            {
            string T_userName="00";

            string connString = "Data Source =.;Initial Catalog = student ;Persist Security Info =True; User ID = sa ;  Password=19971222";
            /*MSSQLSERVER，Integrated Security =False; */

            SqlConnection conn = new SqlConnection(connString);//创建数据库链接

            conn.Open();

            

            string cmdText = String.Format("Select * From stu where 学号='{0}'",userName);//*表示全部字段 , userName是接受的数据
            SqlCommand cmd = new SqlCommand(cmdText,conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset =new DataSet();
            adapter.Fill(dataset);

            if (dataset.Tables.Count > 0 && dataset.Tables[0].Rows.Count > 0 )
            {
                DataRow row = dataset.Tables[0].Rows[0];
                string db_psw =row["学号"].ToString().Trim();//数据库里字段的名称
                string db_sex = row["性别"].ToString().Trim();
                string db_name = row["姓名"].ToString().Trim();
                if (db_psw == userName)
                {
                    context.Response.Write(db_psw + db_sex + db_name);
                }
                else
                {
                    context.Response.Write("查无此人");
                }
            }

            conn.Close();//必须关闭



            /*
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = conn;
            sqlcmd.CommandText = "Select * From stu";
            SqlDataReader dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                T_userName = dr["学号"].ToString();
            }
            dr.Close();
            */

            ////将Ajax传入的参数做出判断后传回到Ajax
            //context.Response.Write("欢迎" + T_userName + "登录成功!");

            }

            catch(Exception ex)
            {           
              context.Response.Write("密码错误登录失败!");
            }
               
  
          
           
        }















        /*
        public bool sql()
        {
            // 初始化连接对象

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "User ID=sa;Initial Catalog=DataBaseName;Data Source= (local);Password=111111";
            // 打开连接

            if (conn.State == ConnectionState.Closed)
            {

                conn.Open();

            }

            // 初始化命令

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "sql语句";

            // 用于执行数据插入、更新和删除的操作；返回被影响的行数。

            int i = cmd.ExecuteNonQuery();

            if (i > 0) { MessageBox.Show("操作成功"); }

            // 用于查询最大值等只需返回一条数据情况下的操作；返回的是首行第一列的数据。                       

            object obj = cmd.ExecuteScalar();

            // 如果想获取数据集合的话我们经常使用到的是数据适配器

            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = cmd;

            adapter.Fill(dt);
        }
        */
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}