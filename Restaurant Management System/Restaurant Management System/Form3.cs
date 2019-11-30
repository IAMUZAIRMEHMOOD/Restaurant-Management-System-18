using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class Form3 : Form
    {
        public static string name, address;
        public static long mob_no, altmob_no;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            address = textBox2.Text;
            mob_no = long.Parse(textBox3.Text);
            altmob_no = long.Parse(textBox4.Text);

            Form5 obj4 = new Form5();
            obj4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 obj2 = new Form2();
            obj2.Show();
        }

    }
}
