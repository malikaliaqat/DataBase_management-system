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
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-O51B1QS\\SQLEXPRESS;Initial Catalog=inshallah;Integrated Security=True");
            
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = loginusername.Text;
            string pass = loginpassword.Text;
            if(username=="Khadija"&& pass =="230")
            {
               this.Hide();
              Dash ds = new Dash();
              ds.Show();
           

           }
           else
            { 
                MessageBox.Show("Not Run");

            }


        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label9_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 ds = new Form2();
            ds.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
    }
}
