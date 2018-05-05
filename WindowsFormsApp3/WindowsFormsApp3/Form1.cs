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
using System.Data.SqlClient;

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
            string constr = "server=www.homeassistant.top;Uid=root;password=1d82d45c42574e03;Database=oauth2;SslMode=None";
            MySqlConnection myconn = new MySqlConnection(constr);
            try
            {
                myconn.Open();
                MessageBox.Show("连接成功");
                string strcmd = "Select * From oauth_access_tokens";
                MySqlCommand mysqlcmd = new MySqlCommand(strcmd, myconn);
                textBox1.Text = mysqlcmd.ExecuteScalar().ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
