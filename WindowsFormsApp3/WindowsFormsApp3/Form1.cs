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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("String to Connecting database...\n");
            string connStr = "server=www.homeassistant.top;user=mysql;database=HRM;password=654321;SslMode=none";
            MySqlConnection sqlConn = new MySqlConnection(connStr);
            try
            {
                
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandText = "select * from StudentInform";
                sqlConn.Open();
                MySqlDataReader rec = sqlCmd.ExecuteReader();
                textBox1.AppendText("数据库连接成功！\n");
                textBox1.AppendText("No\tName\tClass\n");
                while (rec.Read())
                {
                    textBox1.AppendText($"{rec.GetString(0)}\t{rec.GetString(1)}\t{rec.GetString(2)}\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
        }

       
    }
}
