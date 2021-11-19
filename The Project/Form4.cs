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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Students' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
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
            SqlCommand.CommandText = "insert into Students_Address values ('"  +ID+  "','" + textBox7.Text + "','" + textBox1.Text + "')";
            SqlCommand.ExecuteNonQuery();
            MessageBox.Show("Inseration Was Successfully Completed !");
            SqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=beast;Initial Catalog=master;Integrated Security=True");
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;
            SqlConnection.Open();
            SqlCommand.CommandText = "DELETE FROM Students WHERE ID = '" + textBox8.Text + "'";
            SqlCommand.ExecuteNonQuery();
            MessageBox.Show("Deletion Was Successfully Completed !");
            SqlConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=beast;Initial Catalog=master;Integrated Security=True");
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;
            SqlConnection.Open();

            if (textBox2.Text != "") { SqlCommand.CommandText = "UPDATE Students set First_Name = '" + textBox2.Text + "' where ID = '" + textBox9.Text + "'"; SqlCommand.ExecuteNonQuery(); }
            if (textBox5.Text != "") { SqlCommand.CommandText = "UPDATE Students set Last_Name = '" + textBox5.Text + "' where ID = '" + textBox9.Text + "'"; SqlCommand.ExecuteNonQuery(); }
            if (textBox3.Text != "") { SqlCommand.CommandText = "UPDATE Students set Level = '" + textBox3.Text + "' where ID = '" + textBox9.Text + "'"; SqlCommand.ExecuteNonQuery(); }
            if (textBox4.Text != "") { SqlCommand.CommandText = "UPDATE Students set Birth_Date = '" + textBox4.Text + "' where ID = '" + textBox9.Text + "'"; SqlCommand.ExecuteNonQuery(); }
            if (textBox6.Text != "") { SqlCommand.CommandText = "UPDATE Students set Gender = '" + textBox6.Text + "' where ID = '" + textBox9.Text + "'"; SqlCommand.ExecuteNonQuery(); }

            if (textBox7.Text != "") { SqlCommand.CommandText = "UPDATE Students_Address set City = '" + textBox7.Text + "' where ID = '" + textBox9.Text + "'"; SqlCommand.ExecuteNonQuery(); }
            if (textBox1.Text != "") { SqlCommand.CommandText = "UPDATE Students_Address set Street = '" + textBox1.Text + "' where ID = '" + textBox9.Text + "'"; SqlCommand.ExecuteNonQuery(); }


            MessageBox.Show("Update Was Successfully Completed !");
            SqlConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection SqlConnection = new SqlConnection("Data Source=beast;Initial Catalog=master;Integrated Security=True");
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;
            SqlConnection.Open();

            string connectionString = "Data Source=beast;Initial Catalog=master;Integrated Security=True";

            // string sql = "SELECT * FROM Students and Students_Address where Book_ID " + t1 + " intersect SELECT * FROM Books where Title " + t2 + " intersect SELECT * FROM Books where Author " + t5 + " intersect SELECT * FROM Books where Category " + t3 + " intersect SELECT * FROM Books where Publisher " + t4 + " intersect SELECT * FROM Books where Publication_Year " + t6 + " intersect SELECT * FROM Books where Book_Location " + t7 + "";
            string sql = "select * FROM Students, Students_Address WHERE Students.ID =  Students_Address.Person_ID ";
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

            //this.studentsTableAdapter.Fill(this.masterDataSet.Students);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
