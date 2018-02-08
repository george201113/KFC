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

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gregg\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            con.Open();
            da.Fill(dt);
            con.Close();

            //DataRow r1 = dt.Rows[0];
            //DataRow r2 = dt.Rows[1];
            ////label 1-20 name
            ////label 21-40 clockin

            //foreach (DataRow row in dt.Rows)
            //{

            //    label1.Text = r1["name"].ToString();
            //    label4.Text = r1["clockin"].ToString();

            //    label2.Text = r2["name"].ToString();
            //    label5.Text = r2["clockin"].ToString();

            //}

            foreach (DataColumn col in dt.Columns)
            {
                foreach (DataRow row in dt.Rows)
                {
                    label1.Text = row["name"].ToString();
                    label2.Text = row[col.ColumnName].ToString();
                    label1.Text = row[col.ColumnName].ToString();
                    label2.Text = row[col.ColumnName].ToString();
                }
            }

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
