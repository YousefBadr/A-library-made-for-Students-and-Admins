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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=beast;Initial Catalog=master;Integrated Security=True");
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;
            SqlConnection.Open();
            SqlCommand.CommandText = "insert into Admins values ('" + textBox14.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox10.Text + "','" + textBox15.Text + "')";
            SqlCommand.ExecuteNonQuery();
            SqlCommand.CommandText = @"SELECT IDENT_CURRENT('Admins')";
            decimal NumberOfStudents = (decimal)SqlCommand.ExecuteScalar();
            string ID = NumberOfStudents.ToString();
            SqlCommand.CommandText = "insert into Admins_Address values ('" + ID + "','" + textBox9.Text + "','" + textBox8.Text + "')";
            SqlCommand.ExecuteNonQuery();
            SqlCommand.CommandText = "insert into Students_Mobile values ('" + ID + "','" + textBox13.Text + "')";
            SqlCommand.ExecuteNonQuery();

            MessageBox.Show("Singed up  Successfully !");
            SqlConnection.Close();

            Form3 f3 = new Form3();
            f3.Show();
            //this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=beast;Initial Catalog=master;Integrated Security=True");
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;
            SqlConnection.Open();
            SqlCommand.CommandText = "insert into Students values ('" + textBox2.Text + "','" + textBox5.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "')";
            SqlCommand.ExecuteNonQuery();
            SqlCommand.CommandText = @"SELECT IDENT_CURRENT('Students')";
            decimal NumberOfStudents = (decimal)SqlCommand.ExecuteScalar();
            string ID = NumberOfStudents.ToString();
            SqlCommand.CommandText = "insert into Students_Address values ('" + ID + "','" + textBox7.Text + "','" + textBox1.Text + "')";
            SqlCommand.ExecuteNonQuery();
            MessageBox.Show("Singed up  Successfully !");
            SqlConnection.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
