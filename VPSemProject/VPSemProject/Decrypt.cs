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
namespace VPSemProject
{
    public partial class Decrypt : Form
    {
        public Decrypt()
        {
            InitializeComponent();
        }
        public string filepath;
       private void DecryptText_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(filepath);
            String text = "";
            Color pixels = img.GetPixel(img.Width - 1, img.Height - 1);
            int length = pixels.B;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (i < 1 && j < length)
                    {
                        int converted = pixel.B;
                        char characters = Convert.ToChar(converted);
                        String alphabets = Encoding.ASCII.GetString(new byte[] { Convert.ToByte(characters) });
                        {
                            text = text + alphabets;
                        }

                    }
                }
            }
            output.Text = text;
        }

        private void DecryptedText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog obj = new OpenFileDialog();
            obj.Filter = "Images(*.bmp;*.png;) | *.bmp; *.png;";
            if (obj.ShowDialog() == DialogResult.OK)
            {
                filepath = obj.FileName.ToString();
                pictureBox1.ImageLocation = filepath;
            }
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files (*.txt;) | *.txt;";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFile.FileName.ToString();
                StreamWriter write = new StreamWriter(filepath);
                write.Write(output.Text);
                write.Close();
               
            }
        }
    }
}
