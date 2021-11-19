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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.masterDataSet.Students);
            // TODO: This line of code loads data into the 'masterDataSet.Books' table. You can move, or remove it, as needed.
            //this.booksTableAdapter.Fill(this.masterDataSet.Books);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //SqlConnection con = new SqlConnection();

           //var c = new SqlConnection("Data Source=beast;Initial Catalog=master;Integrated Security=True"); // Your Connection String here

            

            // this.booksTableAdapter.Fill(this.masterDataSet.Books);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t1= " <> ' '" , t2 = " <> ' '", t3 = " <> ' '", t4 = " <> ' '", t5 = " <> ' '", t6=" <> ' '", t7 = " <> ' '";
            SqlConnection SqlConnection = new SqlConnection("Data Source=beast;Initial Catalog=master;Integrated Security=True");
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;
            SqlConnection.Open();

            if (textBox1.Text != "") { t1 = " = " + "'"+textBox1.Text + "'"; }
            if (textBox2.Text != "") { t2 = " = " + "'" + textBox2.Text + "'"; }
            if (textBox3.Text != "") { t3 = " = " + "'" + textBox3.Text + "'"; }
            if (textBox4.Text != "") { t4 = " = " + "'" + textBox4.Text + "'"; }
            if (textBox5.Text != "") { t5 = " = " + "'" + textBox5.Text + "'"; }
            if (textBox6.Text != "") { t6 = " = " + "'" + textBox6.Text + "'"; }
            if (textBox7.Text != "") { t7 = " = " + "'" + textBox7.Text + "'"; }


            string connectionString = "Data Source=beast;Initial Catalog=master;Integrated Security=True";

            string sql = "SELECT * FROM Books where Book_ID " + t1 + " intersect SELECT * FROM Books where Title " + t2 + " intersect SELECT * FROM Books where Author " + t5 + " intersect SELECT * FROM Books where Category " + t3 + " intersect SELECT * FROM Books where Publisher " + t4 + " intersect SELECT * FROM Books where Publication_Year " + t6 + " intersect SELECT * FROM Books where Book_Location " + t7 + "";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
