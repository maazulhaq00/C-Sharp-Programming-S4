using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int num1 = int.Parse(textBox1.Text);
            //int num2 = int.Parse(textBox2.Text);

            //double res = 0;
            //switch (comboBox1.Text)
            //{
            //    case "Addition":
            //        res = num1 + num2;
            //        label3.Text = $"The result is: \n{num1} + {num2} = {res}";
            //        break;

            //    case "Subtraction":
            //        res = num1 - num2;
            //        label3.Text = $"The result is: \n{num1} - {num2} = {res}";
            //        break;

            //    case "Multiplication":
            //        res = num1 * num2;
            //        label3.Text = $"The result is: \n{num1} x {num2} = {res}";
            //        break;

            //    case "Divison":
            //        res = num1 / num2;
            //        label3.Text = $"The result is: \n{num1} / {num2} = {res}";
            //        break;

            //    default:
            //        label3.Text = "Invalid Operation";
            //        break;


            //}

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Required Field Missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int res = num1 + num2;
                MessageBox.Show($"The result is: \n{num1} + {num2} = {res}", "Result", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
