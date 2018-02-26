using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace KFC_01
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void qurrito_Click(object sender, EventArgs e)
        {
            itemAdd("   Qurrito");
        }

        //
        //Declarations
        //

        public void itemAdd(string x)
        {
            ListBox lb = new ListBox();
            listbox1.Items.Add(x);
        }

        public static Regex regex = new Regex("(\\s+(Menü)\\s*)$");
        public void itemAddMenu(string x)
        {
            

            ListBox lb = new ListBox();
            listbox1.Items.Add(x);
            x = regex.Replace(" "+ x, "");
            listbox1.Items.Add("    " + x);
            listbox1.Items.Add("        Normálburgonya");
            listbox1.Items.Add("        Refill");
        }

        // Classic

        public void classic1()
        {
            ListBox lb = new ListBox();
            listbox1.Items.Add("1 Classic");
        }
        public void classic2()
        {
            ListBox lb = new ListBox();
            listbox1.Items.Add("2 Classic");
        }
        public void classic3()
        {
            ListBox lb = new ListBox();
            listbox1.Items.Add("3 Classic");
        }

        // Hotwings

        public void hotWings3()
        {
            ListBox lb = new ListBox();
            listbox1.Items.Add("3 Hotwings");
        }
        public void hotWings5()
        {
            ListBox lb = new ListBox();
            listbox1.Items.Add("5 Hotwings");
        }
        public void hotWings8()
        {
            ListBox lb = new ListBox();
            listbox1.Items.Add("8 Hotwings");
        }
        //
        //END
        //
        private void Zinger_Click(object sender, EventArgs e)
        {
            itemAdd("   Zinger");
        }

        private void Grander_Click(object sender, EventArgs e)
        {
            itemAdd("   Grander");
        }

        private void twisterExtra_Click(object sender, EventArgs e)
        {
            itemAdd("   Twister S&B");
        }

        private void twister_Click(object sender, EventArgs e)
        {
            itemAdd("   Twister");
        }

        private void bSmart_Click(object sender, EventArgs e)
        {

        }

        private void filler_Click(object sender, EventArgs e)
        {
            itemAdd("   Filler");
        }

        private void longer_Click(object sender, EventArgs e)
        {
            itemAdd("   Longer");
        }

        private void itwist_Click(object sender, EventArgs e)
        {
            itemAdd("   iTwist");
        }

        private void twisterGrill_Click(object sender, EventArgs e)
        {
            itemAdd("   Grill Twister");
        }

        private void classicGrill_Click(object sender, EventArgs e)
        {
            itemAdd("   Classic Grill Szendvics");
        }

        private void granderM_Click(object sender, EventArgs e)
        {
            itemAddMenu("   Grander Menü");
        }

        private void zingerM_Click(object sender, EventArgs e)
        {
            itemAddMenu("   Zinger Menü");
        }

        private void qurritoM_Click(object sender, EventArgs e)
        {
            itemAddMenu("   Qurrito Menü");
        }

        private void classicM_Click(object sender, EventArgs e)
        {
            itemAdd("   Classic Menü");
            itemAdd("       2 Classic");
            itemAdd("       Normálburgonya");
            itemAdd("       Refill");
        }

        private void hotwingsM_Click(object sender, EventArgs e)
        {
            itemAdd("   HotWings Menü");
            itemAdd("       5 HotWings");
            itemAdd("       Normálburgonya");
            itemAdd("       Refill");
        }

        private void longerM_Click(object sender, EventArgs e)
        {
            itemAdd("   Longer Menü");
            itemAdd("       2 longer");
            itemAdd("       Normálburgonya");
            itemAdd("       Refill");
        }

        private void stripsM_Click(object sender, EventArgs e)
        {
            itemAdd("   Strips Menü");
            itemAdd("       3 Strips");
            itemAdd("       Normálburgonya");
            itemAdd("       Refill");
            itemAdd("       Ketchup");
        }

        private void classicGrillM_Click(object sender, EventArgs e)
        {
            itemAddMenu("   Classic Grill Szendvics Menü");
        }

        private void gyerekM_Click(object sender, EventArgs e)
        {
            itemAdd("   Gyerek Menü");
            itemAdd("       itwist grill");
            itemAdd("       Normálburgonya");
            itemAdd("       Refill");
        }
    }
}
