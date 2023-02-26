using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorWorkstation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                              //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DoctorWorkstation;Integrated Security=sspi";             //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = new SqlCommand();                                       //声明并实例化SQL命令；
            sqlCommand.Connection = sqlConnection;                                          //将SQL命令的属性Connection指向SQL连接；
            sqlCommand.CommandText =                                                        //指定SQL命令的命令文本；命令文本由字符串拼接而成；
                $"SELECT COUNT(1) FROM tb_User" +
                $" WHERE No='{this.txtBox_Account.Text.Trim()}'" +								//将文本框的文本清除首尾的空格后，拼接至命令文本中；
                $" AND Password=HASHBYTES('MD5','{this.txtBox_Password.Text.Trim()}');";
            sqlConnection.Open();                                                           //打开SQL连接；
            int rowCount = (int)sqlCommand.ExecuteScalar();                                 //调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）；
                                                                                            //执行标量的返回结果类型为object，可通过强制类型转换，转为整型；
            sqlConnection.Close();                                                          //关闭SQL连接；
            if (rowCount == 1)                                                              //若查得所输用户号相应的1行记录；
            {
                MessageBox.Show("登录成功。");												//给出正确提示；
            }
            else                                                                            //否则；
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");								//给出错误提示；
                this.txtBox_Password.Focus();                                                  //密码文本框获得焦点；
                this.txtBox_Password.SelectAll();                                              //密码文本框内所有文本被选中；
            }
        }
    }
}
