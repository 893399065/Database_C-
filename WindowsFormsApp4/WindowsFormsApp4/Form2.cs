using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string connStr = @"server=www.homeassistant.top;user=mysql;password=654321;database=LittleBMS;SslMode=none";
            string cmdStr = "select * from UserInform where user='{textBoxUser.Text}'";
            MySqlConnection sqlConn = new MySqlConnection(connStr);
            try
            {
                sqlConn.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdStr, sqlConn);
                MySqlDataReader rec = myCmd.ExecuteReader();
                if (rec.Read())
                {
                    MessageBox.Show("用户名已存在！");

                }
                else
                {
                    rec.Close();
                    if (textBoxUser.Text == "" || textBoxPassword.Text == "")
                    {
                        MessageBox.Show("信息不能为空");
                        sqlConn.Close();
                        return;
                    }
                    cmdStr = $"insert into UserInform values('{textBoxUser.Text}','{textBoxPassword.Text}')";
                    myCmd.CommandText = cmdStr;
                    int n = myCmd.ExecuteNonQuery();
                    if (n == 1)
                    {
                        MessageBox.Show("注册成功！");
                        this.Close();
                        Form1 form1 = new Form1();
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("注册失败！");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            sqlConn.Close();
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                this.buttonConfirm_Click(sender, e);
            }
        }
    }
}
