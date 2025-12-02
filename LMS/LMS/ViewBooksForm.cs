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
    public partial class ViewBooksForm : Form
    {
        public ViewBooksForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAB10-8; User ID=sa; " +
            "Password=aptech; Initial Catalog=lms_db");

        private void ViewBooksForm_Load(object sender, EventArgs e)
        {
            conn.Open();
            
            string sql = "SELECT * FROM Books";
            
            SqlDataAdapter bookDA = new SqlDataAdapter(sql, conn);

            conn.Close();

            DataTable bookDT = new DataTable();

            bookDA.Fill(bookDT);

            dataGridView1.DataSource = bookDT;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["bid"].Value);
            string bookname = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["bookname"].Value);
            int price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["price"].Value);
            string authorname = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["authorname"].Value);

            //MessageBox.Show($"tHE ID IS {id} ");

            this.Hide();
            EditBookForm editBookForm1 = new EditBookForm(id, bookname, price, authorname);
            editBookForm1.ShowDialog();
        }
    }
}
