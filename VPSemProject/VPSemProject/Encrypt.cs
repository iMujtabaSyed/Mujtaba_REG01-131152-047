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
            obj.Filter= "Images(*.bmp;*.png;) | *.bmp; *.png;";
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
                    if (i < 1 && j <input.TextLength)
                    {
                        char text = Convert.ToChar(input.Text.Substring(j, 1));
                        int converted = Convert.ToInt32(text);
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, pixel.B,converted));
                    }
                    if (i == img.Width - 1 && j == img.Height - 1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, input.TextLength));
                    }

                }
            }
          
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Images(*.bmp;*.png;) | *.bmp; *.png;";
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

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenTextFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog obj = new OpenFileDialog();
            obj.Filter = "Text Files (*.txt;) | *.txt;";
            if (obj.ShowDialog() == DialogResult.OK)
            {
               string Textfilepath = obj.FileName.ToString();
               StreamReader read = new StreamReader(Textfilepath);
                input.Text=read.ReadToEnd();
                read.Close();
            }
        }
    }

}