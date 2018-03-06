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
    public partial class ViewAll : Form
    {
        public ViewAll()
        {
            InitializeComponent();
        }
        public void view()
        {
            TextReader txt = new StreamReader(@"file.txt");
            TextReader txt2 = new StreamReader(@"file2.txt");
            TextReader txt3 = new StreamReader(@"file3.txt");
            TextReader txt4 = new StreamReader(@"file4.txt");
            TextReader txt5 = new StreamReader(@"file5.txt");
            TextReader txt6 = new StreamReader(@"file6.txt");
            TextReader txt7 = new StreamReader(@"file7.txt");
            TextReader txt8 = new StreamReader(@"file8.txt");
            TextReader txt9 = new StreamReader(@"file9.txt");
            TextReader txt10 = new StreamReader(@"file10.txt");

            richTextBox1.Text= txt.ReadToEnd();
            richTextBox1.AppendText(txt2.ReadToEnd());
            richTextBox1.AppendText(txt3.ReadToEnd());
            richTextBox1.AppendText(txt4.ReadToEnd());
            richTextBox1.AppendText(txt5.ReadToEnd());
            richTextBox1.AppendText(txt6.ReadToEnd());
            richTextBox1.AppendText(txt7.ReadToEnd());
            richTextBox1.AppendText(txt8.ReadToEnd());
            richTextBox1.AppendText(txt9.ReadToEnd());
            richTextBox1.AppendText(txt10.ReadToEnd());

            txt.Close();
            txt2.Close();
            txt3.Close();
            txt4.Close();
            txt5.Close();
            txt6.Close();
            txt7.Close();
            txt8.Close();
            txt9.Close();
            txt10.Close();


        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            view();
        }
    }
}
