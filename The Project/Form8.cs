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


namespace The_Project
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Book_Reviews' table. You can move, or remove it, as needed.
            this.book_ReviewsTableAdapter.Fill(this.masterDataSet.Book_Reviews);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=beast;Initial Catalog=master;Integrated Security=True");
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;
            SqlConnection.Open();

            string connectionString = "Data Source=beast;Initial Catalog=master;Integrated Security=True";
            string t7 = " <> ' ' ";
            if (textBox7.Text != "") { t7 = " = " + "'" + textBox7.Text + "'"; }
            string sql =" SELECT * FROM Book_Reviews where Book_ID " + t7 + "";
            //MessageBox.Show(sql);
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                var myTable = new DataTable();
                adapter.Fill(myTable);
                dataGridView1.DataSource = myTable;
            }

        }
    }
}
