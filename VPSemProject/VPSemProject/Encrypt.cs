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
    public partial class Encrypt : Form
    {
        public Encrypt()
        {
            InitializeComponent();
        }
        public string filepath;

        private void Encrypt_MdiChildActivate(object sender, EventArgs e)
        {

        }

        private void AddImage_Click(object sender, EventArgs e)
        {

           
           OpenFileDialog obj = new OpenFileDialog();
            obj.Filter= "Image files(*.bmp) | *.bmp";
           // obj.InitialDirectory = @"C:\";
            if(obj.ShowDialog()==DialogResult.OK)
            {
                filepath = obj.FileName.ToString();
                pictureBox1.ImageLocation = filepath;
            }
        }
        private void EncryptMessage()
        {
            Bitmap img = new Bitmap(filepath);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (i < 1 && j <textBox1.TextLength)
                    {
                        char text = Convert.ToChar(textBox1.Text.Substring(j, 1));
                        int converted = Convert.ToInt32(text);
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, pixel.B,converted));
                    }
                    if (i == img.Width - 1 && j == img.Height - 1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, textBox1.TextLength));
                    }

                }
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image files(*.bmp) | *.bmp";
           // saveFile.InitialDirectory = @"C:\";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFile.FileName.ToString();
                pictureBox1.ImageLocation = filepath;

                img.Save(filepath);
            }
        
            }
        
        private void button1_Click(object sender, EventArgs e)
        {
            EncryptMessage();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Encrypt_Load(object sender, EventArgs e)
        {

        }
    }

}
