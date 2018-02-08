using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Upload
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gregg\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Login (password, name, manager) VALUES (@password1,@name1,@manager)", con);

            string caption = "ERROR";
            string notNumber = "Password box has to contain only numbers without spaces.";
            int parsedValue;

            if (!int.TryParse(textBox2.Text, out parsedValue))
            {
                MessageBox.Show(notNumber, caption);
                textBox2.Text = "";
            }
            else
            {

                SqlCommand checkUser = new SqlCommand("SELECT COUNT(*) FROM Login WHERE ([password] = @password1)", con);
                checkUser.Parameters.AddWithValue("@password1", textBox2.Text);
                int PasswordExist = (int)checkUser.ExecuteScalar();



                SqlCommand checkPassword = new SqlCommand("SELECT COUNT(*) FROM Login WHERE ([name] = @name1)", con);
                checkPassword.Parameters.AddWithValue("@name1", textBox1.Text);
                int UserExist = (int)checkPassword.ExecuteScalar();



                string userMessage = "This User Already Exists!";
                string passwordMessage = "This Password is Already Used!";
                string emptyBox = "Can't let textbox be empty!";


                if (PasswordExist > 0)
                {
                    MessageBox.Show(passwordMessage, caption);
                    textBox2.Text = "";
                }
                else
                {
                    if (UserExist > 0)
                    {
                        MessageBox.Show(userMessage, caption);
                        textBox1.Text = "";
                    }
                    else if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show(emptyBox, caption);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@name1", textBox1.Text);
                        cmd.Parameters.AddWithValue("@password1", textBox2.Text);
                        if (radioButton1.Checked)
                        {
                            cmd.Parameters.AddWithValue("@manager", "1");
                            cmd.ExecuteNonQuery();
                            label5.Text = "User has been added!";
                            textBox1.Text = "";
                            textBox2.Text = "";
                            var t = new Timer();
                            t.Interval = 5000;
                            label5.Show();
                            t.Tick += (s, p) =>
                            {
                                label5.Hide();
                                t.Stop();
                            };
                            t.Start();
                        }
                        else if (radioButton2.Checked)
                        {
                            cmd.Parameters.AddWithValue("@manager", "0");
                            cmd.ExecuteNonQuery();
                            label5.Text = "User has been added!";
                            textBox1.Text = "";
                            textBox2.Text = "";
                            label5.Show();
                            var t = new Timer();
                            t.Interval = 5000;
                            t.Tick += (s, p) =>
                            {
                                label5.Hide();
                                t.Stop();
                            };
                            t.Start();
                        }
                        else
                        {
                            MessageBox.Show("Please choose yes or no", "ERROR");
                        }

                    }
                }


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gregg\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();


            Random random = new Random();
            int szam = random.Next(10000000, 99999999);

            SqlDataReader dr4;
            SqlCommand cmd2 = new SqlCommand("SELECT password FROM login WHERE login.password =" + szam, con);
            for (int i = 0; i < 10; i++)
            {
                dr4 = cmd2.ExecuteReader();
                if (!dr4.Read())
                {
                    textBox2.Text = szam.ToString();
                    i = 10;
                }
            }


        }
    }
}
