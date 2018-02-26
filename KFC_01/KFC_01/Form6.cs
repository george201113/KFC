using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KFC_01
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            string query = "SELECT name, clockin FROM LoggedIn";

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= 'D:\Visual Studio Projects\KFC-master\Data.mdf' ;Integrated Security=True;Connect Timeout=30");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            con.Open();
            da.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 200;
        }
        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
