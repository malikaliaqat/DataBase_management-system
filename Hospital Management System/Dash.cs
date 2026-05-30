using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inshallah_Do_it
{
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }

        private void Dash_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.ForeColor = System.Drawing.Color.Red;
            label1.ForeColor = System.Drawing.Color.Black;
            label2.ForeColor = System.Drawing.Color.Black;
            label3.ForeColor = System.Drawing.Color.Black;
            this.Hide();
            history ds = new history();
            ds.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Red;
            label2.ForeColor = System.Drawing.Color.Black;
            label3.ForeColor = System.Drawing.Color.Black;
            label4.ForeColor = System.Drawing.Color.Black;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.Color.Red;
            label1.ForeColor = System.Drawing.Color.Black;
            label4.ForeColor = System.Drawing.Color.Black;
            label3.ForeColor = System.Drawing.Color.Black;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            allpatient ds = new allpatient();
            ds.Show();

            label3.ForeColor = System.Drawing.Color.Red;
            label1.ForeColor = System.Drawing.Color.Black;
            label2.ForeColor = System.Drawing.Color.Black;
            label4.ForeColor = System.Drawing.Color.Black;
            panel4.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-O51B1QS\\SQLEXPRESS;Initial Catalog=inshallah;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from kt inner join addmore on kt.id = addmore.pid";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView2.DataSource = DS.Tables[0];

        }

        private void button5_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are you EXIT PROJECT");
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtid_Click(object sender, EventArgs e)
        {

        }

        private void gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void txtgender_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O51B1QS\SQLEXPRESS;Initial Catalog=inshallah;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO kt VALUES (@name, @address, @contact, @age, @gender, @blood, @major, @id)", con);

            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@contact", int.Parse(txtcontact.Text));

            cmd.Parameters.AddWithValue("@age", double.Parse(txtage.Text));
            cmd.Parameters.AddWithValue("@gender", txtgender.Text);
            cmd.Parameters.AddWithValue("@blood", txtblood.Text);
            cmd.Parameters.AddWithValue("@major", txtmajor.Text);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtid.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully saved.");
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textid_TextChanged(object sender, EventArgs e)
        {
            if(textid.Text !="")
            {
                int id = Convert.ToInt32(textid.Text);

                SqlConnection con = new SqlConnection();
             
                con.ConnectionString = "Data Source=DESKTOP-O51B1QS\\SQLEXPRESS;Initial Catalog=inshallah;Integrated Security=True";
           SqlCommand cmd = new SqlCommand();
                cmd.Connection =con;
                cmd.CommandText = "Select*from kt where id = " + id + "";
        SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS =new DataSet();
                DA.Fill(DS);
               dataGridView1.DataSource = DS.Tables[0];

            }
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O51B1QS\SQLEXPRESS;Initial Catalog=inshallah;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO addmore VALUES (@pid , @sym, @dia, @med, @ward, @ward_type)", con);
            cmd.Parameters.AddWithValue("@pid", textid.Text);
            cmd.Parameters.AddWithValue("@sym", txtsym.Text);
            cmd.Parameters.AddWithValue("@dia", txtdia.Text);
            cmd.Parameters.AddWithValue("@med", txtmed.Text);
            cmd.Parameters.AddWithValue("@ward",comboward.Text);
            cmd.Parameters.AddWithValue("@ward_type", combotype.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully saved.");
            textid.Clear();
            txtsym.Clear();
            txtdia.Clear();
            txtmed.Clear();
            comboward.ResetText();
            combotype.ResetText();
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 

        }
    }
}
