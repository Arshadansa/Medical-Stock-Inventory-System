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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            label5.Visible = true;
            textBox3.Visible = true;
            label6.Visible = true;
            textBox4.Visible = true;
            label7.Visible = true;
            textBox8.Visible = true;
            label8.Visible = true;
            textBox6.Visible = true;
            label9.Visible = true;
            textBox5.Visible = true;
            label10.Visible = true;
            textBox7.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            this.Hide();
            obj.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            label5.Visible = true;
            textBox3.Visible = true;
            label6.Visible = true;
            textBox4.Visible = true;
            label7.Visible = true;
            textBox8.Visible = true;
            label8.Visible = true;
            textBox6.Visible = true;
            label9.Visible = true;
            textBox5.Visible = true;
            label10.Visible = true;
            textBox7.Visible = true;
            button2.Visible = false;
            button3.Visible = true;
            button4.Visible = false;
            button5.Visible = false;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            label5.Visible = true;
            textBox3.Visible = true;
            label6.Visible = true;
            textBox4.Visible = true;
            label7.Visible = true;
            textBox8.Visible = true;
            label8.Visible = true;
            textBox6.Visible = true;
            label9.Visible = true;
            textBox5.Visible = true;
            label10.Visible = true;
            textBox7.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = false;
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            label5.Visible = true;
            textBox3.Visible = true;
            label6.Visible = true;
            textBox4.Visible = true;
            label7.Visible = true;
            textBox8.Visible = true;
            label8.Visible = true;
            textBox6.Visible = true;
            label9.Visible = true;
            textBox5.Visible = true;
            label10.Visible = true;
            textBox7.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
