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
    public partial class allpatient : Form
    {
        public allpatient()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void allpatient_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-O51B1QS\\SQLEXPRESS;Initial Catalog=inshallah;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from kt inner join addmore on kt.id = addmore.pid";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            
         dataGridView1.DataSource = DS.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            history ds = new history();
            ds.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you EXIT PROJECT");
            this.Close();

        }
    }
}
