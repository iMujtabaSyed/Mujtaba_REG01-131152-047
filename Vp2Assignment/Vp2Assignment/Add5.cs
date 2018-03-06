using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vp2Assignment
{
    public partial class Add5 : Form
    {
        public Add5()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "01-131152-005";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public void writeStudent()
        {
            TextWriter txt = new StreamWriter(@"file5.txt");
            txt.WriteLine("------------------");
            txt.WriteLine("Student ID");
            txt.WriteLine(textBox1.Text);
            txt.WriteLine("Student Name");
            txt.WriteLine(textBox2.Text);
            txt.WriteLine("Student Contact");
            txt.WriteLine(textBox3.Text);
            txt.WriteLine("Student GPA");
            txt.WriteLine(textBox4.Text);
            txt.WriteLine("Student Department");
            txt.WriteLine(textBox5.Text);
            txt.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("This field cannot be left blank.");
                textBox1.Focus();
                textBox2.Focus();
                textBox3.Focus();
                textBox4.Focus();
                textBox5.Focus();




            }
            else
            {
                writeStudent();
                MessageBox.Show("Thank you Student Added");
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
