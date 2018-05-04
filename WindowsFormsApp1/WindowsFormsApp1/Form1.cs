using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mystr = "Data Source=.;Initial Catalog=studentDB;Integrated security=SSPI";
            SqlConnection conn = new SqlConnection(mystr);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("成功连接到数据库");
                SqlCommand mycmd = new SqlCommand("SELECT  [Name] FROM StudentInform", conn);
                textBox1.Text = mycmd.ExecuteScalar().ToString();
    
            }
                
            else
                MessageBox.Show("不能连接到数据库");
            conn.Close();
        }
    }
}
