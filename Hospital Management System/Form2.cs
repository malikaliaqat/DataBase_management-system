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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 ds = new Form1();
            ds.Show();
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

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
