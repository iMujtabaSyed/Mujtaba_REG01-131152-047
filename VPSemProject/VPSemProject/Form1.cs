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

namespace VPSemProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void GetUsername()
        {
            StreamReader s = new StreamReader(@"username.txt");
            StreamReader s2 = new StreamReader(@"password.txt");
            
            textBox2.PasswordChar = '*';

            if (s.ReadLine()==textBox1.Text && s2.ReadLine()==textBox2.Text)
            {
                MainMenu n = new MainMenu();
                n.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Invalid Login Credentials");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            GetUsername();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
