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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           




        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=beast;Initial Catalog=master;Integrated Security=True");
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;
            SqlConnection.Open();
            SqlCommand.CommandText = "DELETE FROM Books WHERE Book_ID = '" + textBox1.Text + "'";
            SqlCommand.ExecuteNonQuery();
            MessageBox.Show("Deletion Was Successfully Completed !");
            SqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=beast;Initial Catalog=master;Integrated Security=True");
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;
            SqlConnection.Open();
            SqlCommand.CommandText = "insert into Books values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            SqlCommand.ExecuteNonQuery();
            MessageBox.Show("Inseration Was Successfully Completed !");
            SqlConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.booksTableAdapter1.Fill(this.masterDataSet.Books);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            SqlConnection SqlConnection = new SqlConnection("Data Source=beast;Initial Catalog=master;Integrated Security=True");
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;
            SqlConnection.Open();

            if(textBox6.Text != "") { SqlCommand.CommandText = "UPDATE Books set Publication_Year = '" + textBox6.Text + "' where Book_ID = '" + textBox1.Text + "'"; SqlCommand.ExecuteNonQuery(); }
            if (textBox4.Text != "") { SqlCommand.CommandText = "UPDATE Books set Publisher = '" + textBox4.Text + "' where Book_ID = '" + textBox1.Text + "'"; SqlCommand.ExecuteNonQuery(); }
            if (textBox3.Text != "") { SqlCommand.CommandText = "UPDATE Books set Category = '" + textBox3.Text + "' where Book_ID = '" + textBox1.Text + "'"; SqlCommand.ExecuteNonQuery(); }
            if (textBox5.Text != "") { SqlCommand.CommandText = "UPDATE Books set Author = '" + textBox5.Text + "' where Book_ID = '" + textBox1.Text + "'"; SqlCommand.ExecuteNonQuery(); }
            if (textBox2.Text != "") { SqlCommand.CommandText = "UPDATE Books set Title = '" + textBox2.Text + "' where Book_ID = '" + textBox1.Text + "'"; SqlCommand.ExecuteNonQuery(); }
            
            MessageBox.Show("Update Was Successfully Completed !");
            SqlConnection.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
