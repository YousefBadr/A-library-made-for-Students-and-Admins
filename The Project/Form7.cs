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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.masterDataSet.Books);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=beast;Initial Catalog=master;Integrated Security=True");
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;
            SqlConnection.Open();
            SqlCommand.CommandText = "insert into Book_Reviews values ('" + textBox3.Text + "','" + textBox2.Text + "','" + richTextBox1.Text + "')";
            SqlCommand.ExecuteNonQuery();
            MessageBox.Show("Thanks For submiting your review !");
            SqlConnection.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
