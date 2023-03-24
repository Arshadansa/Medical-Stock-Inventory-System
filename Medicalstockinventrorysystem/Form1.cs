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
    public partial class Form1 : Form
    {  
       
        public Form1()
        {
            InitializeComponent();

        }
       private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
            int count = 0;
            this.timer1.Start();
            progressBar1.Visible = true;
            this.progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                count++;
            }

            if (count == 1)
            {
                timer1.Enabled = false;
                progressBar1.Visible = false;
                Form2 obj = new Form2();
                this.Hide();
                obj.Show();
            }

        }

       

       

      
    }
}
