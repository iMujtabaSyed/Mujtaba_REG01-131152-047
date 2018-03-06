using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vp2Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void available001ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add n = new Add();
            n.MdiParent = this;
            n.Show();
              

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAll n = new ViewAll();
            n.MdiParent = this;
            n.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchName n = new SearchName();
            n.MdiParent = this;
            n.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent n = new DeleteStudent();
            n.MdiParent = this;
            n.Show();
        }

        private void markToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkAttendance n = new MarkAttendance();
            n.MdiParent = this;
            n.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewAttendance n = new ViewAttendance();
            n.MdiParent = this;
            n.Show();
        }

        private void topStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            top3 n = new top3();
            n.MdiParent = this;
            n.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Add2 n = new Add2();
            n.MdiParent = this;
            n.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Add3 n = new Add3();
            n.MdiParent = this;
            n.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Add4 n = new Add4();
            n.MdiParent = this;
            n.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Add5 n = new Add5();
            n.MdiParent = this;
            n.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Add6 n = new Add6();
            n.MdiParent = this;
            n.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Add7 n = new Add7();
            n.MdiParent = this;
            n.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Add8 n = new Add8();
            n.MdiParent = this;
            n.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Add9 n = new Add9();
            n.MdiParent = this;
            n.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Add10 n = new Add10();
            n.MdiParent = this;
            n.Show();
        }
    }
}
