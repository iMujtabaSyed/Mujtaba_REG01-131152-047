using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPSemProject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
       

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Encrypt n = new Encrypt();
            n.MdiParent = this;
            n.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decrypt n = new Decrypt();
            n.MdiParent = this;
            n.Show();
        }
    }
}
