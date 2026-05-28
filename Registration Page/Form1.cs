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

namespace Registraion_of_HMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

        }

        private void signbtn_Click(object sender, EventArgs e)
        {

                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O51B1QS\SQLEXPRESS;Initial Catalog=signin;Integrated Security=True");

                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO f VALUES (@user, @email, @pass, @con)", con);

                    cmd.Parameters.AddWithValue("@user", user.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@pass", pass.Text);
                    cmd.Parameters.AddWithValue("@con", cone.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Successfully saved.");
                }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash ds = new dash();
            ds.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void con_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }

}
