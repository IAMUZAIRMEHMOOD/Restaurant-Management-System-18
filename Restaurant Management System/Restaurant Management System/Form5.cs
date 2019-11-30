using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class Form5 : Form
    {
        string path = @"C:\Users\Public\test\WriteText.txt";
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox19.Text = Form3.name.ToString();
            textBox20.Text = Form3.address.ToString();
            textBox21.Text = Form3.mob_no.ToString();
            textBox22.Text = Form3.altmob_no.ToString();
            richTextBox1.Text = File.ReadAllText(path);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
