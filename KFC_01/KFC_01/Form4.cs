using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KFC_01
{
    public partial class Form4 : Form
    {
        Form3 mFrm3Ref;
        public Form4(Form3 frm)
        {
            mFrm3Ref = frm;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            button12.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= 'D:\Visual Studio Projects\KFC-master\Data.mdf' ;Integrated Security=True;Connect Timeout=30");
            SqlDataReader dr;
            SqlDataReader dr2;
            SqlDataReader dr3;

            string manager = "INSERT INTO manager (manager, password) SELECT manager,password FROM Login WHERE password =" + Kod.login1;
            string manager2 = "SELECT manager FROM manager WHERE manager = 1";
            string belepve = "INSERT INTO LoggedIn (name,password) SELECT name,password FROM Login WHERE password =" + Kod.login1;
            string bevanlepve = "SELECT password FROM Login WHERE password =" + Kod.login1;
            string delete = "DELETE FROM manager";
            string queryif = "SELECT password FROM loggedin WHERE EXISTS (SELECT password FROM loggedin WHERE loggedin.password = " + Kod.login1 + ")";
            string quelogout = "DELETE FROM loggedin WHERE UPPER(password) LIKE " + Kod.login1;

            SqlCommand command = new SqlCommand(manager, con);
            SqlCommand command2 = new SqlCommand(belepve, con);
            SqlCommand command3 = new SqlCommand(bevanlepve, con);
            SqlCommand command4 = new SqlCommand(manager2, con);
            SqlCommand command5 = new SqlCommand(delete, con);
            SqlCommand command6 = new SqlCommand(queryif, con);
            SqlCommand command7 = new SqlCommand(quelogout, con);



            con.Open();
            dr3 = command6.ExecuteReader();
            if (dr3.Read())
            {
                con.Close();

                DialogResult diares = MessageBox.Show("Do You want to Sign out?", "Logout", MessageBoxButtons.YesNo);
                if (diares == DialogResult.Yes)
                {
                    con.Open();
                    command7.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                    mFrm3Ref.Close();
                    Kod.login1 = "";
                }
                else
                {
                    Kod.login1 = "";
                    mFrm3Ref.Close();
                    this.Close();
                    button12.Hide();
                }
            }
            else
            {
                con.Close();
                con.Open();
                dr2 = command3.ExecuteReader();
                if (dr2.Read())
                {
                    con.Close();
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    dr = command4.ExecuteReader();
                    if (dr.Read())
                    {
                        con.Close();
                        con.Open();
                        command2.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        command5.ExecuteNonQuery();
                        con.Close();

                        Kod.login1 = "";
                        this.Close();
                        mFrm3Ref.Close();
                    }
                    else
                    {
                        this.Close();
                        Form5 frm5 = new Form5(mFrm3Ref);
                        frm5.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Employee not Found", "Error");
                    richTextBox1.Text = "";
                    Kod.login1 = "";
                    button12.Hide();
                }
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
                Kod.login1 = "";
            }
            else
            {
                richTextBox1.Text = "";
                Kod.login1 = "";
                button12.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login1 = Kod.login1 + "1";
            button12.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login1 = Kod.login1 + "2";
            button12.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login1 = Kod.login1 + "3";
            button12.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login1 = Kod.login1 + "4";
            button12.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login1 = Kod.login1 + "5";
            button12.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login1 = Kod.login1 + "6";
            button12.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login1 = Kod.login1 + "7";
            button12.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login1 = Kod.login1 + "8";
            button12.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login1 = Kod.login1 + "9";
            button12.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
            Kod.login1 = Kod.login1 + "0";
            button12.Show();
        }
    }
}
