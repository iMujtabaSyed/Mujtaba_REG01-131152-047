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
    public partial class ViewAttendance : Form
    {
        public ViewAttendance()
        {
            InitializeComponent();
        }
        public void view()
        {
            StreamReader file = new StreamReader(@"attendance.txt");
            richTextBox1.Text = file.ReadToEnd();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            view();
        }
    }
}
