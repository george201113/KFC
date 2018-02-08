using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KFC_01
{
    public partial class Form5 : Form
    {
        Form3 mFrm3Ref;
        public Form5(Form3 frm)
        {
            mFrm3Ref = frm;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            button12.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string goodtime = currentTime.Hour + ":" + currentTime.Minute;


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gregg\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataReader dr;
            string delete = "DELETE FROM manager";
            string manager = "INSERT INTO manager (manager, password) SELECT manager,password FROM Login WHERE password =" + Kod.login22;
            string manager2 = "SELECT manager FROM manager WHERE manager = 1";
            string belepve = "INSERT INTO LoggedIn (name,password,clockin) SELECT name,password,clockin FROM Login WHERE password =@Password";
            string loginbaRak = "UPDATE Login SET clockin = @MyDate WHERE password =@Password2";
            string deleteLoginClokin = "UPDATE Login SET clockin = Null WHERE password =@Password2";

            SqlCommand command = new SqlCommand(delete, con);
            SqlCommand command2 = new SqlCommand(manager, con);
            SqlCommand command3 = new SqlCommand(manager2, con);
            SqlCommand command4 = new SqlCommand(belepve, con);
            SqlCommand command5 = new SqlCommand(loginbaRak, con);
            SqlCommand command6 = new SqlCommand(deleteLoginClokin, con);


            command5.Parameters.AddWithValue("@MyDate", goodtime);
            command5.Parameters.AddWithValue("@Password2", Kod.login1);
            command4.Parameters.AddWithValue("@Password", Kod.login1);
            command6.Parameters.AddWithValue("@Password2", Kod.login1);



            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            con.Open();
            command2.ExecuteNonQuery();
            con.Close();
            con.Open();
            dr = command3.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                this.Close();
                mFrm3Ref.Close();
                richTextBox1.Text = "";
                Kod.login22 = "";

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                con.Open();
                command5.ExecuteNonQuery();
                con.Close();

                con.Open();
                command4.ExecuteNonQuery();
                con.Close();


                con.Open();
                command6.ExecuteNonQuery();
                con.Close();
                Kod.login1 = "";
            }
            else
            {
                con.Close();
                MessageBox.Show("Not Manager Code", "ERROR");
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                Kod.login22 = "";
                richTextBox1.Text = "";
                button12.Hide();
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string caption = "Please Choose";
            string message = "Do you want to close login screen?";
            DialogResult dr = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                mFrm3Ref.Close();
                richTextBox1.Text = "";
                Kod.login22 = "";
                Kod.login1 = "";
                button12.Hide();
            }
            else
            {
                richTextBox1.Text = "";
                Kod.login22 = "";
                button12.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login22 = Kod.login22 + "1";
            button12.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login22 = Kod.login22 + "2";
            button12.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login22 = Kod.login22 + "3";
            button12.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login22 = Kod.login22 + "4";
            button12.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login22 = Kod.login22 + "5";
            button12.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login22 = Kod.login22 + "6";
            button12.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login22 = Kod.login22 + "7";
            button12.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login22 = Kod.login22 + "8";
            button12.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login22 = Kod.login22 + "9";
            button12.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login22 = Kod.login22 + "0";
            button12.Show();
        }
    }
}
