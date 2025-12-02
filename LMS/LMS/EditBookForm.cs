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
    public partial class EditBookForm : Form
    {
        public int bid;
        public string bookname;
        public int price;
        public string authorname;
        public EditBookForm(int bid, string bookname, int price, string authorname)
        {
            InitializeComponent();

            this.bid = bid;
            this.bookname = bookname;
            this.price = price;
            this.authorname = authorname;
        }

        SqlConnection conn = new SqlConnection("Data Source=LAB10-8; User ID=sa; Password=aptech; Initial Catalog=lms_db");
        private void button1_Click(object sender, EventArgs e)
        {
            string bookname = textBox1.Text;
            int price = int.Parse(textBox2.Text);
            string authorname = textBox3.Text;

            conn.Open();
            string sql = $"UPDATE Books SET bookname='{bookname}', price={price}, authorname='{authorname}' WHERE bid={this.bid}";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            this.Hide();
            ViewBooksForm viewBookForm = new ViewBooksForm();
            viewBookForm.ShowDialog();
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.bookname;
            textBox2.Text = $"{this.price}";
            textBox3.Text = this.authorname;
        }
    }
}
