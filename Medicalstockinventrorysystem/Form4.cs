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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 obj = new Form5();
            this.Hide();
            obj.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form7 obj = new Form7();
            this.Hide();
            obj.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Form8 obj = new Form8();
            this.Hide();
            obj.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Form9 obj = new Form9();
            this.Hide();
            obj.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form2 obj = new Form2();
            this.Hide();
            obj.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

       
       
    }
}
