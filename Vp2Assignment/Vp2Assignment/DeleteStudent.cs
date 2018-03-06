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
    public partial class DeleteStudent : Form
    {
        public string name;
        public DeleteStudent()
        {
            InitializeComponent();
        }
        public void Delete()
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
        file.Close();
                string stringToSearch2 = name;
        string[] lines2 = File.ReadAllLines(@"file2.txt");
        file2.Close();
                string stringToSearch3 = name;
        string[] lines3 = File.ReadAllLines(@"file3.txt");
        file3.Close();
                string stringToSearch4 = name;
        string[] lines4 = File.ReadAllLines(@"file4.txt");
        file4.Close();
                string stringToSearch5 = name;
        string[] lines5 = File.ReadAllLines(@"file5.txt");
        file5.Close();
                string stringToSearch6 = name;
        string[] lines6 = File.ReadAllLines(@"file6.txt");
        file6.Close();
                string stringToSearch7 = name;
        string[] lines7 = File.ReadAllLines(@"file7.txt");
        file7.Close();
                string stringToSearch8 = name;
        string[] lines8 = File.ReadAllLines(@"file8.txt");
        file8.Close();
                string stringToSearch9 = name;
        string[] lines9 = File.ReadAllLines(@"file9.txt");
        file9.Close();
                string stringToSearch10 = name;
        string[] lines10 = File.ReadAllLines(@"file10.txt");
        file10.Close();

                foreach (string line in lines)
                {
                    if (line.Contains(stringToSearch1))
                    {
                        StreamWriter filex = new StreamWriter(@"file.txt");
                       filex.WriteLine(" ");
                        filex.Close();

                    }

}
                foreach (string line in lines2)
                {
                    if (line.Contains(stringToSearch2))
                    {
                        StreamWriter filex = new StreamWriter(@"file2.txt");
filex.WriteLine(" ");
                        filex.Close();

                    }

                }

                foreach (string line in lines3)
                {
                    if (line.Contains(stringToSearch3))
                    {
                        StreamWriter filex = new StreamWriter(@"file3.txt");
filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
                foreach (string line in lines4)
                {
                    if (line.Contains(stringToSearch4))
                    {
                        StreamWriter filex = new StreamWriter(@"file4.txt");
filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
                foreach (string line in lines5)
                {
                    if (line.Contains(stringToSearch5))
                    {
                        StreamWriter filex = new StreamWriter(@"file5.txt");
filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
                foreach (string line in lines6)
                {
                    if (line.Contains(stringToSearch6))
                    {
                        StreamWriter filex = new StreamWriter(@"file6.txt");
filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
                foreach (string line in lines7)
                {
                    if (line.Contains(stringToSearch7))
                    {
                        StreamWriter filex = new StreamWriter(@"file7.txt");
filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
                foreach (string line in lines8)
                {
                    if (line.Contains(stringToSearch8))
                    {
                        StreamWriter filex = new StreamWriter(@"file8.txt");
filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
                foreach (string line in lines9)
                {
                    if (line.Contains(stringToSearch9))
                    {
                        StreamWriter filex = new StreamWriter(@"file9.txt");
filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
                foreach (string line in lines10)
                {
                    if (line.Contains(stringToSearch10))
                    {
                        StreamWriter filex = new StreamWriter(@"file10.txt");
filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delete();
            MessageBox.Show("Operation Performed");
        }
    }
}
