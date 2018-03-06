using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Vp2Assignment
{
    public partial class SearchName : Form
    {
        public string name;
        public SearchName()
        {
            InitializeComponent();
        }
        public void result()
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            searching();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }
        public void searching()
        {
            StreamReader file = new StreamReader(@"file.txt");
            StreamReader file2 = new StreamReader(@"file2.txt");
            StreamReader file3 = new StreamReader(@"file3.txt");
            StreamReader file4 = new StreamReader(@"file4.txt");
            StreamReader file5 = new StreamReader(@"file5.txt");
            StreamReader file6 = new StreamReader(@"file6.txt");
            StreamReader file7 = new StreamReader(@"file7.txt");
            StreamReader file8 = new StreamReader(@"file8.txt");
            StreamReader file9 = new StreamReader(@"file9.txt");
            StreamReader file10 = new StreamReader(@"file10.txt");
            string stringToSearch1 = name;
            string[] lines = File.ReadAllLines(@"file.txt");
            string stringToSearch2 = name;
            string[] lines2 = File.ReadAllLines(@"file2.txt");
            string stringToSearch3 = name;
            string[] lines3 = File.ReadAllLines(@"file3.txt");
            string stringToSearch4 = name;
            string[] lines4 = File.ReadAllLines(@"file4.txt");
            string stringToSearch5 = name;
            string[] lines5 = File.ReadAllLines(@"file5.txt");
            string stringToSearch6 = name;
            string[] lines6 = File.ReadAllLines(@"file6.txt");
            string stringToSearch7 = name;
            string[] lines7 = File.ReadAllLines(@"file7.txt");
            string stringToSearch8 = name;
            string[] lines8 = File.ReadAllLines(@"file8.txt");
            string stringToSearch9 = name;
            string[] lines9 = File.ReadAllLines(@"file9.txt");
            string stringToSearch10 = name;
            string[] lines10 = File.ReadAllLines(@"file10.txt");
            foreach (string line in lines)
            {
                if (line.Contains(stringToSearch1))
                {
                    richTextBox1.Text= file.ReadToEnd();
                    file.Close();
                }

            }
            foreach (string line in lines2)
            {
                if (line.Contains(stringToSearch1))
                {
                    richTextBox1.Text = file2.ReadToEnd();
                    file2.Close();
                }

            }
            foreach (string line in lines3)
            {
                if (line.Contains(stringToSearch1))
                {
                    richTextBox1.Text = file3.ReadToEnd();
                    file3.Close();
                }

            }
            foreach (string line in lines4)
            {
                if (line.Contains(stringToSearch1))
                {
                    richTextBox1.Text = file4.ReadToEnd();
                    file4.Close();
                }

            }
            foreach (string line in lines5)
            {
                if (line.Contains(stringToSearch1))
                {
                    richTextBox1.Text = file5.ReadToEnd();
                    file5.Close();
                }

            }
            foreach (string line in lines6)
            {
                if (line.Contains(stringToSearch1))
                {
                    richTextBox1.Text = file6.ReadToEnd();
                    file6.Close();
                }

            }
            foreach (string line in lines7)
            {
                if (line.Contains(stringToSearch1))
                {
                    richTextBox1.Text = file7.ReadToEnd();
                    file7.Close();
                }

            }
            foreach (string line in lines8)
            {
                if (line.Contains(stringToSearch1))
                {
                    richTextBox1.Text = file8.ReadToEnd();
                    file8.Close();
                }

            }
            foreach (string line in lines9)
            {
                if (line.Contains(stringToSearch1))
                {
                    richTextBox1.Text = file9.ReadToEnd();
                    file9.Close();
                }

            }
            foreach (string line in lines10)
            {
                if (line.Contains(stringToSearch1))
                {
                    richTextBox1.Text = file10.ReadToEnd();
                    file10.Close();
                }

            }
        }
    }
}
