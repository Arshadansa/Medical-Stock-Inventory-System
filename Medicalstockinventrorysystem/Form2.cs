using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medicalstockinventrorysystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            Form3 obj = new Form3();
             this.Hide();
             obj.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter User Name", "Warning");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter Password", "Warning");
                textBox2.Focus();
            }
            else if (textBox1.Text == "user1" && textBox2.Text == "123")
            {
                Form4 obj = new Form4();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials", "Warning");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want Close the Program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Close();
            }
            else if (dialog == DialogResult.No)
            {
                this.Show();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 obj = new Form6();
            this.Hide();
            obj.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
