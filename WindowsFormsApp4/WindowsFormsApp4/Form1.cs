using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       


        private void buttonLogin_Click(object sender, EventArgs e)
        {
           
            string connStr = @"server=www.homeassistant.top;user=mysql;password=654321;database=LittleBMS;SslMode=none";
            string cmdStr = $"select * from UserInform where user='{textBoxUser.Text}'";
            MySqlConnection sqlConn = new MySqlConnection(connStr);
            try
            {
                sqlConn.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdStr, sqlConn);
                MySqlDataReader rec = myCmd.ExecuteReader();
                if (rec.Read())
                {
                    if (textBoxPassword.Text == rec.GetString(rec.GetOrdinal("password")))
                    {
                        MessageBox.Show("登录成功！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("密码输入有误！");
                        textBoxPassword.Text = "";
                        
                    }
                }
                else
                {
                    MessageBox.Show("用户名输入有误！");
                    textBoxUser.Text = "";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }
    }
}
