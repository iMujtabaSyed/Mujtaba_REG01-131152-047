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
    public partial class top3 : Form
    {
        public double one, two, three;
        public top3()
        {
            InitializeComponent();
        }
        public void topGPA()
        {
            double[] maxi = new double[10];
            double maxgpa;
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
            if (file.ReadLine() != " ")
            {
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                maxgpa = double.Parse(file.ReadLine());
                file.Close();
                maxi[0] = maxgpa;
            }
            if (file2.ReadLine() != " ")
            {
                file2.ReadLine();
                file2.ReadLine();
                file2.ReadLine();
                file2.ReadLine();
                file2.ReadLine();
                file2.ReadLine();
                file2.ReadLine();
                maxgpa = double.Parse(file2.ReadLine());
                file2.Close();

                maxi[1] = maxgpa;
            }
            if (file3.ReadLine() != " ")
            {
                file3.ReadLine();
                file3.ReadLine();
                file3.ReadLine();
                file3.ReadLine();
                file3.ReadLine();
                file3.ReadLine();
                file3.ReadLine();
                maxgpa = double.Parse(file3.ReadLine());
                file3.Close();
                maxi[2] = maxgpa;
            }
            if (file4.ReadLine() != " ")
            {
                file4.ReadLine();
                file4.ReadLine();
                file4.ReadLine();
                file4.ReadLine();
                file4.ReadLine();
                file4.ReadLine();
                file4.ReadLine();
                maxgpa = double.Parse(file4.ReadLine());
                file4.Close();
                maxi[3] = maxgpa;
            }
            if (file5.ReadLine() != " ")
            {
                file5.ReadLine();
                file5.ReadLine();
                file5.ReadLine();
                file5.ReadLine();
                file5.ReadLine();
                file5.ReadLine();
                file5.ReadLine();
                maxgpa = double.Parse(file5.ReadLine());
                file5.Close();
                maxi[4] = maxgpa;
            }
            if (file6.ReadLine() != " ")
            {
                file6.ReadLine();
                file6.ReadLine();
                file6.ReadLine();
                file6.ReadLine();
                file6.ReadLine();
                file6.ReadLine();
                file6.ReadLine();
                maxgpa = double.Parse(file6.ReadLine());
                file6.Close();
                maxi[5] = maxgpa;
            }
            if (file7.ReadLine() != " ")
            {
                file7.ReadLine();
                file7.ReadLine();
                file7.ReadLine();
                file7.ReadLine();
                file7.ReadLine();
                file7.ReadLine();
                file7.ReadLine();
                maxgpa = double.Parse(file7.ReadLine());
                file7.Close();
                maxi[6] = maxgpa;
            }
            if (file8.ReadLine() != " ")
            {
                file8.ReadLine();
                file8.ReadLine();
                file8.ReadLine();
                file8.ReadLine();
                file8.ReadLine();
                file8.ReadLine();
                file8.ReadLine();
                maxgpa = double.Parse(file8.ReadLine());
                file8.Close();
                maxi[7] = maxgpa;
            }
            if (file9.ReadLine() != " ")
            {
                file9.ReadLine();
                file9.ReadLine();
                file9.ReadLine();
                file9.ReadLine();
                file9.ReadLine();
                file9.ReadLine();
                file9.ReadLine();
                maxgpa = double.Parse(file9.ReadLine());
                file9.Close();
                maxi[8] = maxgpa;
            }
            if (file10.ReadLine() != " ")
            {
                file10.ReadLine();
                file10.ReadLine();
                file10.ReadLine();
                file10.ReadLine();
                file10.ReadLine();
                file10.ReadLine();
                file10.ReadLine();
                maxgpa = double.Parse(file10.ReadLine());
                file10.Close();
                maxi[9] = maxgpa;
            }
            double first, second, third;
            first = second = third = double.MinValue;
            for (int i = 0; i < maxi.Length; i++)
            {
                if (maxi[i] > first)
                {
                    third = second;
                    second = first;
                    first = maxi[i];
                }

                /* If arr[i] is in between first and
                second then update second  */
                else if (maxi[i] > second)
                {
                    third = second;
                    second = maxi[i];
                }

                else if (maxi[i] > third)
                    third = maxi[i];
            }
            one = first;
            two = second;
            three = third;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showTop3();
        }

        void showTop3()
        {
            topGPA();
            double maxgpa;
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
            if (file.ReadLine() != " ")
            {
                
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                 maxgpa = double.Parse(file.ReadLine());
                if (maxgpa == one || maxgpa == two || maxgpa == three)
                {
                    StreamReader filex = new StreamReader(@"file.txt");
                    richTextBox1.AppendText(filex.ReadToEnd());
                    filex.Close();

                }

                file.Close();
            }
            if (file2.ReadLine() != " ")
            {
                file2.ReadLine();
                file2.ReadLine();
                file2.ReadLine();
                file2.ReadLine();
                file2.ReadLine();
                file2.ReadLine();
                file2.ReadLine();
                maxgpa = double.Parse(file2.ReadLine());
                if (maxgpa == one || maxgpa == two || maxgpa == three)
                {
                    StreamReader filex = new StreamReader(@"file2.txt");
                    richTextBox1.AppendText(filex.ReadToEnd());
                    filex.Close();

                }
                file2.Close();
            }
            if (file3.ReadLine() != " ")
            {

                file3.ReadLine();
                file3.ReadLine();
                file3.ReadLine();
                file3.ReadLine();
                file3.ReadLine();
                file3.ReadLine();
                file3.ReadLine();
                maxgpa = double.Parse(file3.ReadLine());
                if (maxgpa == one || maxgpa == two || maxgpa == three)
                {
                    StreamReader filex = new StreamReader(@"file3.txt");
                    richTextBox1.AppendText(filex.ReadToEnd());
                    filex.Close();
                }
                file3.Close();
            }

            if (file4.ReadLine() != " ")
            {
                file4.ReadLine();
                file4.ReadLine();
                file4.ReadLine();
                file4.ReadLine();
                file4.ReadLine();
                file4.ReadLine();
                file4.ReadLine();
                maxgpa = double.Parse(file4.ReadLine());
                if (maxgpa == one || maxgpa == two || maxgpa == three)
                {
                    StreamReader filex = new StreamReader(@"file4.txt");
                    richTextBox1.AppendText(filex.ReadToEnd());
                    filex.Close();
                }
                file4.Close();
            }
            if (file5.ReadLine() != " ")
            {
                file5.ReadLine();
                file5.ReadLine();
                file5.ReadLine();
                file5.ReadLine();
                file5.ReadLine();
                file5.ReadLine();
                file5.ReadLine();
                maxgpa = double.Parse(file5.ReadLine());
                if (maxgpa == one || maxgpa == two || maxgpa == three)
                {
                    StreamReader filex = new StreamReader(@"file5.txt");
                    richTextBox1.AppendText(filex.ReadToEnd());
                    filex.Close();
                }
                file5.Close();
            }
            if (file6.ReadLine() != " ")
            {
                file6.ReadLine();
                file6.ReadLine();
                file6.ReadLine();
                file6.ReadLine();
                file6.ReadLine();
                file6.ReadLine();
                file6.ReadLine();
                maxgpa = double.Parse(file6.ReadLine());
                if (maxgpa == one || maxgpa == two || maxgpa == three)
                {
                    StreamReader filex = new StreamReader(@"file6.txt");
                    richTextBox1.AppendText(filex.ReadToEnd());
                    filex.Close();
                }
                file6.Close();
            }
            if (file7.ReadLine() != " ")
            {
                file7.ReadLine();
                file7.ReadLine();
                file7.ReadLine();
                file7.ReadLine();
                file7.ReadLine();
                file7.ReadLine();
                file7.ReadLine();
                maxgpa = double.Parse(file7.ReadLine());
                if (maxgpa == one || maxgpa == two || maxgpa == three)
                {
                    StreamReader filex = new StreamReader(@"file7.txt");
                    richTextBox1.AppendText(filex.ReadToEnd());
                    filex.Close();
                }
                file7.Close();
            }
            if (file8.ReadLine() != " ")
            {
                file8.ReadLine();
                file8.ReadLine();
                file8.ReadLine();
                file8.ReadLine();
                file8.ReadLine();
                file8.ReadLine();
                file8.ReadLine();
                maxgpa = double.Parse(file8.ReadLine());
                if (maxgpa == one || maxgpa == two || maxgpa == three)
                {
                    StreamReader filex = new StreamReader(@"file8.txt");
                    richTextBox1.AppendText(filex.ReadToEnd());
                    filex.Close();
                }
                file8.Close();
            }
            if (file9.ReadLine() != " ")
            {
                file9.ReadLine();
                file9.ReadLine();
                file9.ReadLine();
                file9.ReadLine();
                file9.ReadLine();
                file9.ReadLine();
                file9.ReadLine();
                maxgpa = double.Parse(file9.ReadLine());
                if (maxgpa == one || maxgpa == two || maxgpa == three)
                {
                    StreamReader filex = new StreamReader(@"file9.txt");
                    richTextBox1.AppendText(filex.ReadToEnd());
                    filex.Close();
                }
                file9.Close();
            }
            if (file10.ReadLine() != " ")
            {
                file10.ReadLine();
                file10.ReadLine();
                file10.ReadLine();
                file10.ReadLine();
                file10.ReadLine();
                file10.ReadLine();
                file10.ReadLine();
                maxgpa = double.Parse(file10.ReadLine());
                if (maxgpa == one || maxgpa == two || maxgpa == three)
                {
                    StreamReader filex = new StreamReader(@"file10.txt");
                    richTextBox1.AppendText(filex.ReadToEnd());
                    filex.Close();
                }
                file10.Close();
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
