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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            this.Hide();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

     

       

       

    }
}
