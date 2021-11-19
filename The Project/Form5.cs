using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace The_Project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=beast;Initial Catalog=master;Integrated Security=True");
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;
            SqlConnection.Open();
            SqlCommand.CommandText = @"SELECT ID from Admins where ID = '" + textBox2.Text + "' and Password = '" + textBox3.Text + "'";
            int s;
            try
            { s = (int)SqlCommand.ExecuteScalar(); s = 1; }
            catch
            { s = -1; MessageBox.Show("Sorry,Wrong ID or Password"); }

            if (s == 1)
            {
                Form3 f3 = new Form3();
                f3.Show();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=beast;Initial Catalog=master;Integrated Security=True");
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;
            SqlConnection.Open();
            SqlCommand.CommandText = @"SELECT ID from Students where ID = '"+textBox1.Text+"' and Level = '"+ textBox4.Text + "'";
            int s;
            try
            {  s = (int)SqlCommand.ExecuteScalar(); s = 1; }
            catch
            { s = -1; MessageBox.Show("Sorry,Wrong ID or Level"); }

           if(s==1)
            {
                Form6 f6 = new Form6();
                f6.Show();
            }
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
