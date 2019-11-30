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
    public partial class Form1 : Form
    {
        public string uname = "Admin", pass = "admin123";
        public string username, password;
        public int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                username = textBox1.Text;
                password = textBox2.Text;

                string[] usernames = new string[4];
                usernames[0] = "Ahsan Mustafa";
                usernames[1] = "Shoaib Aamir";
                usernames[2] = "Hassam Arif";
                usernames[3] = "Gul Hameed";

                string[] passwords = new string[4];
                passwords[0] = "ahsan123";
                passwords[1] = "shoaib123";
                passwords[2] = "hassam123";
                passwords[3] = "gul123";

                if (username.Equals(usernames[i]) && password.Equals(passwords[i]) || username.Equals(usernames[i + 1]) && password.Equals(passwords[i + 1]) || username.Equals(usernames[i + 2]) && password.Equals(passwords[i + 2]) || username.Equals(usernames[i + 3]) && password.Equals(passwords[i + 3]))
                {
                    Form2 obj = new Form2();
                    obj.Show();
                }
                else if (username == uname && password == pass)
                {
                    Form5 x = new Form5();
                    x.Show();
                }

                else
                {
                    MessageBox.Show(" User Access Denied");
                }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }

    }
