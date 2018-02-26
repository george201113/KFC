using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KFC_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;


            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= 'D:\Visual Studio Projects\KFC-master\Data.mdf' ;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT name FROM Login WHERE password=" + Kod.bejelcode, connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                label2.Text = reader["name"].ToString();

                reader.Close();
                connection.Close();
            }

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form7 frm7 = new Form7();
            frm7.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form7 frm7 = new Form7();
            frm7.Show();
        }
    }
}
