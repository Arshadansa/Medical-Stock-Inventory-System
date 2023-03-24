using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Medicalstockinventrorysystem
{

    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=medicine;Integrated Security=True");

        public Form5()
        {

            InitializeComponent();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into medicine3 values('" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "')";
            textBox8.Text = ""; textBox9.Text = "";
            textBox10.Text = ""; textBox11.Text = ""; textBox12.Text = "";
            textBox13.Text = ""; textBox14.Text = "";
            int v = cmd.ExecuteNonQuery();
            con.Close();
            display_data();
            MessageBox.Show("Record inserted successfully");
        }
        public void display_data()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from medicine3", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            label10.Visible = true;
            textBox8.Visible = true;
            label11.Visible = true;
            textBox9.Visible = true;
            label12.Visible = true;
            textBox10.Visible = true;
            label13.Visible = true;
            textBox11.Visible = true;
            label15.Visible = true;
            textBox12.Visible = true;
            label16.Visible = true;
            textBox13.Visible = true;
            label17.Visible = true;
            textBox14.Visible = true;
            //dateTimePicker2.Visible = true;
            button7.Visible = true;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            this.Hide();
            obj.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            label10.Visible = true;
            textBox8.Visible = true;
            label11.Visible = true;
            textBox9.Visible = true;
            label12.Visible = true;
            textBox10.Visible = true;
            label13.Visible = true;
            textBox11.Visible = true;
            label15.Visible = true;
            textBox12.Visible = true;
            label16.Visible = true;
            textBox13.Visible = true;
            label17.Visible = true;
            textBox14.Visible = true;
            //dateTimePicker2.Visible = true;
            button7.Visible = false;
            button8.Visible = true;
            button9.Visible = false;
            button10.Visible = false;

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            label10.Visible = true;
            textBox8.Visible = true;
            label11.Visible = true;
            textBox9.Visible = true;
            label12.Visible = true;
            textBox10.Visible = true;
            label13.Visible = true;
            textBox11.Visible = true;
            label15.Visible = true;
            textBox12.Visible = true;
            label16.Visible = true;
            textBox13.Visible = true;
            label17.Visible = true;
            textBox14.Visible = true;
            //dateTimePicker2.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = true;
            button10.Visible = false;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

            label10.Visible = true;
            textBox8.Visible = true;
            label11.Visible = true;
            textBox9.Visible = true;
            label12.Visible = true;
            textBox10.Visible = true;
            label13.Visible = true;
            textBox11.Visible = true;
            label15.Visible = true;
            textBox12.Visible = true;
            label16.Visible = true;
            textBox13.Visible = true;
            label17.Visible = true;
            textBox14.Visible = true;
            //dateTimePicker2.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = true;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e) => this.Close();

        private void Form5_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int cost=Convert.ToInt32(textBox10.Text);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update medicine3 set [Medicine Name]= '"+ textBox9.Text + "',[Cost Price]="+cost+" where [Medicine Id]='" + textBox8.Text + "'";
            textBox8.Text = "";textBox9.Text = ""; textBox10.Text = "";textBox11.Text = "";textBox12.Text = "";
            textBox13.Text = "";textBox14.Text = "";
            cmd.ExecuteNonQuery();
            con.Close();
            display_data();
            MessageBox.Show("Record updated successfully");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"delete from medicine3 where [Medicine Id]='" + textBox8.Text + "'";
            textBox8.Text = "";
            cmd.ExecuteNonQuery();
            con.Close();
            display_data();
            MessageBox.Show("Record Deleted successfully");
        }

        private void button10_Click(object sender, EventArgs e)
        {
           // 
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from medicine3 where [Medicine Id]='" + textBox8.Text + "'";
            textBox8.Text = "";
            cmd.ExecuteNonQuery();
            con.Close();
            display_data();
            MessageBox.Show("Record Executed successfully");
        }
    }
}