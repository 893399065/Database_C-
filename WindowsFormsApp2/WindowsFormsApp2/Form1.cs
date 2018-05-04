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
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection myconn = new SqlConnection();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string mystr = "Data Source=.;Initial Catalog=studentDB;Integrated Security=true";
            myconn.ConnectionString = mystr;
            myconn.Open();
        }

        private void button_delect_Click(object sender, EventArgs e)
        {
            SqlCommand mycmd = new SqlCommand();
            string mysql = $"delete from StudentInform where No={textBoxNo.Text}";
            mycmd.CommandText = mysql;
            mycmd.Connection = myconn;
            int n = mycmd.ExecuteNonQuery();
            MessageBox.Show($"删除成功{n}记录！");

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string mysql = $"insert into PersonInform values('{textBoxNo.Text}', '{textBoxName.Text}', {textBoxGrade.Text})";
            SqlCommand mycmd = new SqlCommand(mysql, myconn);
            MessageBox.Show($"影响行数{mycmd.ExecuteNonQuery()}");
        }
    }
}
