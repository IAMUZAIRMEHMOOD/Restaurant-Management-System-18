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
    public partial class Form2 : Form
    {
        public static int c_Burger1, c_Burger2, c_Burger3, c_Burger4, c_Burger5;
        public static int b_Burger1, b_Burger2, b_Burger3, b_Burger4, b_Burger5;
        public static int c_Mania1, c_Mania2, c_Mania3;
        public static int beverages1, beverages2;
        public static int extras1, extras2, extras3;

        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            label13.Text = "0";
            label14.Text = "150";
            label16.Text = "0";
            richTextBox1.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            label13.Text = "0";
            label14.Text = "150";

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;

            label18.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
            }

            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
            }

            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
            }

            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
            }

            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Enabled = true;
            }

            else
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Enabled = true;
            }

            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox7.Enabled = true;
            }

            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox8.Enabled = true;
            }

            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox9.Enabled = true;
            }

            else
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox10.Enabled = true;
            }

            else
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox11.Enabled = true;
            }

            else
            {
                textBox11.Enabled = false;
                textBox11.Text = "0";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                textBox12.Enabled = true;
            }

            else
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                textBox13.Enabled = true;
            }

            else
            {
                textBox13.Enabled = false;
                textBox13.Text = "0";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                textBox14.Enabled = true;
            }

            else
            {
                textBox14.Enabled = false;
                textBox14.Text = "0";
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                textBox15.Enabled = true;
            }

            else
            {
                textBox15.Enabled = false;
                textBox15.Text = "0";
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                textBox16.Enabled = true;
            }

            else
            {
                textBox16.Enabled = false;
                textBox16.Text = "0";
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                textBox17.Enabled = true;
            }

            else
            {
                textBox17.Enabled = false;
                textBox17.Text = "0";
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                textBox18.Enabled = true;
            }

            else
            {
                textBox18.Enabled = false;
                textBox18.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d_Chicken, f_Chicken, c_Chicken, cl_Chicken, cl_Grilled;
            int bbq_Mushroom, f_Beef, cl_Beef, h_Beef, d_Beef;
            int cf_chicken, c_Strips, f_Wings;
            int s_Drinks, m_Water;
            int Coleslaw, Cheese, Sauces;

            d_Chicken = 320; f_Chicken = 240; c_Chicken = 210; cl_Chicken = 160; cl_Grilled = 220;
            bbq_Mushroom = 240; f_Beef = 220; cl_Beef = 160; h_Beef = 240; d_Beef = 250;
            cf_chicken = 200; c_Strips = 230; f_Wings = 130;
            s_Drinks = 40; m_Water = 30;
            Coleslaw = 50; Cheese = 30; Sauces = 50;

            c_Burger1 = int.Parse(textBox1.Text);
            c_Burger2 = int.Parse(textBox2.Text);
            c_Burger3 = int.Parse(textBox3.Text);
            c_Burger4 = int.Parse(textBox4.Text);
            c_Burger5 = int.Parse(textBox5.Text);

            b_Burger1 = int.Parse(textBox6.Text);
            b_Burger2 = int.Parse(textBox7.Text);
            b_Burger3 = int.Parse(textBox8.Text);
            b_Burger4 = int.Parse(textBox9.Text);
            b_Burger5 = int.Parse(textBox10.Text);

            c_Mania1 = int.Parse(textBox11.Text);
            c_Mania2 = int.Parse(textBox12.Text);
            c_Mania3 = int.Parse(textBox13.Text);


            beverages1 = int.Parse(textBox14.Text);
            beverages2 = int.Parse(textBox15.Text);

            extras1 = int.Parse(textBox16.Text);
            extras2 = int.Parse(textBox17.Text);
            extras3 = int.Parse(textBox18.Text);

            Restaurant OUAT = new Restaurant(c_Burger1, c_Burger2, c_Burger3, c_Burger4, c_Burger5, b_Burger1, b_Burger2, b_Burger3, b_Burger4, b_Burger5, c_Mania1, c_Mania2, c_Mania3, beverages1, beverages2, extras1, extras2, extras3);

            int cost_of_burgers = (c_Burger1 * c_Chicken) + (c_Burger2 * cl_Chicken) + (c_Burger3 * f_Chicken) + (c_Burger4 * d_Chicken) + (c_Burger5 * cl_Grilled) + (b_Burger1 * bbq_Mushroom) + (b_Burger2 * cl_Beef) + (b_Burger3 * f_Beef) + (b_Burger4 * d_Beef) + (b_Burger5 * h_Beef);
            label11.Text = Convert.ToString(cost_of_burgers);

            int cost_of_mania = (c_Mania1 * cf_chicken) + (c_Mania2 * c_Strips) + (c_Mania3 * f_Wings);
            label12.Text = Convert.ToString(cost_of_mania);

            int cost_of_extras = (beverages1 * s_Drinks) + (beverages2 * m_Water) + (extras1 * Coleslaw) + (extras2 * Cheese) + (extras3 * Sauces);
            label13.Text = Convert.ToString(cost_of_extras);

            int s_Charge = int.Parse(label14.Text);

            label16.Text = Convert.ToString(cost_of_burgers + cost_of_mania + cost_of_extras + s_Charge);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("\t" + "OUAT Restaurant" + Environment.NewLine);
            richTextBox1.AppendText("---------------------------------" + Environment.NewLine);

            richTextBox1.AppendText("Crunchy Chicken (210) \t" + textBox1.Text + Environment.NewLine);
            richTextBox1.AppendText("Classic Chicken (160) \t" + textBox2.Text + Environment.NewLine);
            richTextBox1.AppendText("Flamy Chicken (240) \t" + textBox3.Text + Environment.NewLine);
            richTextBox1.AppendText("Double Chicken (320) \t" + textBox4.Text + Environment.NewLine);
            richTextBox1.AppendText("Classic Grilled (220) \t" + textBox5.Text + Environment.NewLine);
            richTextBox1.AppendText("BBQ Mushroom (240) \t" + textBox6.Text + Environment.NewLine);
            richTextBox1.AppendText("Classic Beef (160) \t\t" + textBox7.Text + Environment.NewLine);
            richTextBox1.AppendText("Flamy Beef (220) \t\t" + textBox8.Text + Environment.NewLine);
            richTextBox1.AppendText("Double Beef (250) \t\t" + textBox9.Text + Environment.NewLine);
            richTextBox1.AppendText("Hunter Beef (240) \t\t" + textBox10.Text + Environment.NewLine);
            richTextBox1.AppendText("Crunchy F Chicken (200) \t" + textBox11.Text + Environment.NewLine);
            richTextBox1.AppendText("Chicken Strips (230) \t" + textBox12.Text + Environment.NewLine);
            richTextBox1.AppendText("Flamy Wings (130) \t" + textBox13.Text + Environment.NewLine);
            richTextBox1.AppendText("Soft Drinks (40) \t\t" + textBox14.Text + Environment.NewLine);
            richTextBox1.AppendText("Mineral Water (30) \t" + textBox15.Text + Environment.NewLine);
            richTextBox1.AppendText("Coleslaw (50) \t\t" + textBox16.Text + Environment.NewLine);
            richTextBox1.AppendText("Cheese (30) \t\t\t" + textBox17.Text + Environment.NewLine);
            richTextBox1.AppendText("Sauces (50) \t\t\t" + textBox18.Text + Environment.NewLine);

            richTextBox1.AppendText("---------------------------------" + Environment.NewLine);
            richTextBox1.AppendText("Service Charge \t\t" + label14.Text + Environment.NewLine);
            richTextBox1.AppendText("Total \t\t\t\t" + label16.Text + Environment.NewLine);

            richTextBox1.AppendText("---------------------------------" + Environment.NewLine);
            richTextBox1.AppendText(label17.Text + "\n" + label18.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label17.Text = DateTime.Now.ToLongTimeString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 obj1 = new Form3();
            obj1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /**
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Customer Record";
            savefile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter SW = new System.IO.StreamWriter(savefile.FileName))
                    SW.WriteLine(richTextBox1.Text);

            }
            **/
            System.IO.File.WriteAllText(@"C:\Users\Public\test\WriteText.txt", richTextBox1.Text);
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
