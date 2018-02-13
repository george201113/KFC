using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KFC_01
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            label1.Hide();

            button11.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();

            Form4 frm4 = new Form4(frm3);
            frm4.ShowDialog();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            label1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button10_Click(object sender, EventArgs e)
        {
            Kod.code1 = Kod.code1 + "1";
            button11.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Kod.code1 = Kod.code1 + "2";
            button11.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Kod.code1 = Kod.code1 + "3";
            button11.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Kod.code1 = Kod.code1 + "4";
            button11.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kod.code1 = Kod.code1 + "5";
            button11.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kod.code1 = Kod.code1 + "6";
            button11.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kod.code1 = Kod.code1 + "7";
            button11.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kod.code1 = Kod.code1 + "8";
            button11.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kod.code1 = Kod.code1 + "9";
            button11.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Kod.code1 = Kod.code1 + "0";
            button11.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Kod.code1 = "";
            button11.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\gregg\Desktop\KFC\Data.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlDataReader dr;
            SqlDataReader dr2;

            string select = "SELECT password FROM Login WHERE CAST(password AS bigint)=" + Kod.code1;
            string queryif = "SELECT password FROM loggedin WHERE EXISTS (SELECT password FROM loggedin WHERE loggedin.password =" + Kod.code1 + ")";

            SqlCommand command = new SqlCommand(select, con);
            SqlCommand command2 = new SqlCommand(queryif, con);

            con.Open();
            dr2 = command2.ExecuteReader();
            if (dr2.Read())
            {
                con.Close();
                con.Open();
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    Kod.bejelcode = Kod.code1;
                    Kod.code1 = "";
                    Form2 frm2 = new Form2();
                    frm2.ShowDialog();
                    button11.Hide();

                }
                else
                {
                    Kod.code1 = "";
                    string message = "Employee not found!";
                    string caption = "Error";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    button11.Hide();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Log in first!", "ERROR");
                Kod.code1 = "";
                button11.Hide();
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
