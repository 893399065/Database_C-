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
            string connStr = "server=www.homeassistant;user=root;database=oauth2;port=3306;password=1d82d45c42574e03;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                textbox_log.Text += "Connecting to MySQL...\r\n";
                conn.Open();
                FileInfo file = new FileInfo("D:/endb.sql");  //filename是sql脚本文件路径。  
                string sql = file.OpenText().ReadToEnd();
                MySqlScript script = new MySqlScript(conn);
                script.Query = sql;
                int count = script.Execute();
                textbox_log.Text += "Executed " + count + " statement(s)\r\n";
                textbox_log.Text += "Delimiter: " + script.Delimiter + "\r\n";
                //textbox_log.Text += "Query: " + script.Query + "\r\n";  
            }
            catch (Exception ex)
            {
                textbox_log.Text += ex.ToString();
            }
            conn.Close();
            textbox_log.Text += "Execute Successfully.";
        }
}
