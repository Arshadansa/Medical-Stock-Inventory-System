using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicalstockinventrorysystem
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            this.Hide();
            obj.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox1.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            label4.Visible = true;
            textBox3.Visible = true;
            label5.Visible = true;
            textBox4.Visible = true;
            label6.Visible = true;
            textBox5.Visible = true;
            label7.Visible = true;
            textBox6.Visible = true;
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox1.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            label4.Visible = true;
            textBox3.Visible = true;
            label5.Visible = true;
            textBox4.Visible = true;
            label6.Visible = true;
            textBox5.Visible = true;
            label7.Visible = true;
            textBox6.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = false;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox1.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            label4.Visible = true;
            textBox3.Visible = true;
            label5.Visible = true;
            textBox4.Visible = true;
            label6.Visible = true;
            textBox5.Visible = true;
            label7.Visible = true;
            textBox6.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
