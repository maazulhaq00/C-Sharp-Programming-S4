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

namespace LMS
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAB10-8; User ID=sa; " +
            "Password=aptech; Initial Catalog=lms_db");

        private void button1_Click(object sender, EventArgs e)
        {
            string bookname = textBox1.Text;
            int price = int.Parse(textBox2.Text);
            string authorname = textBox3.Text;

            conn.Open();
            string sql = $"INSERT INTO Books VALUES ('{bookname}', {price}, '{authorname}')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            //MessageBox.Show($"Book {bookname} inserted successfully");

            //textBox1.Text = "";
            //textBox2.Text = "";
            //textBox3.Text = "";


            this.Hide();
            ViewBooksForm viewBookForm = new ViewBooksForm();
            viewBookForm.ShowDialog();

        }
    }
}
