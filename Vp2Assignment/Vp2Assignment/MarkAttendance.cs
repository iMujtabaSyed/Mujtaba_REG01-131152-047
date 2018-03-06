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
    public partial class MarkAttendance : Form
    {
        public MarkAttendance()
        {
            InitializeComponent();
        }
        string attendanceMark;
        public void markAttendance()
        {
            StreamWriter sw = File.CreateText(@"attendance.txt");
            sw.AutoFlush = true;
            Console.WriteLine("Attendance by Roll Number");
            Console.WriteLine("Type 'p' for Present and 'a' for absent");
            Console.WriteLine("----------------");
            sw.WriteLine("----------------");
            StreamReader re1 = File.OpenText(@"file.txt");
            StreamReader re2 = File.OpenText(@"file2.txt");
            StreamReader re3 = File.OpenText(@"file3.txt");
            StreamReader re4 = File.OpenText(@"file4.txt");
            StreamReader re5 = File.OpenText(@"file5.txt");
            StreamReader re6 = File.OpenText(@"file6.txt");
            StreamReader re7 = File.OpenText(@"file7.txt");
            StreamReader re8 = File.OpenText(@"file8.txt");
            StreamReader re9 = File.OpenText(@"file9.txt");
            StreamReader re10 = File.OpenText(@"file10.txt");
            if (re1.ReadLine() != " ")
            {
                sw.WriteLine("----------------");
                sw.WriteLine("01-131152-001");
                if (radioButton1.Checked)
                {
                    attendanceMark = "present";
                    sw.WriteLine(attendanceMark);
                }
                else
                {
                    attendanceMark = "absent";
                    sw.WriteLine(attendanceMark);
                }
                re1.Close();
            }
         

            if (re2.ReadLine() != " ")
            {
                sw.WriteLine("----------------");
                sw.WriteLine("01-131152-002");
                if (radioButton4.Checked)
                {
                    attendanceMark = "present";
                    sw.WriteLine(attendanceMark);
                }
                else
                {
                    attendanceMark = "absent";
                    sw.WriteLine(attendanceMark);
                }
                re2.Close();
            }
            if (re3.ReadLine() != " ")
            {
                sw.WriteLine("----------------");
                sw.WriteLine("01-131152-003");
                if (radioButton6.Checked)
                {
                    attendanceMark = "present";
                    sw.WriteLine(attendanceMark);
                }
                else
                {
                    attendanceMark = "absent";
                    sw.WriteLine(attendanceMark);
                }
                re3.Close();
            }
            if (re4.ReadLine() != " ")
            {
                sw.WriteLine("----------------");
                sw.WriteLine("01-131152-004");
                if (radioButton8.Checked)
                {
                    attendanceMark = "present";
                    sw.WriteLine(attendanceMark);
                }
                else
                {
                    attendanceMark = "absent";
                    sw.WriteLine(attendanceMark);
                }
                re4.Close();
            }
            if (re5.ReadLine() != " ")
            {
                sw.WriteLine("----------------");
                sw.WriteLine("01-131152-005");
                if (radioButton10.Checked)
                {
                    attendanceMark = "present";
                    sw.WriteLine(attendanceMark);
                }
                else
                {
                    attendanceMark = "absent";
                    sw.WriteLine(attendanceMark);
                }
                re5.Close();
            }
            if (re6.ReadLine() != " ")
            {
                sw.WriteLine("----------------");
                sw.WriteLine("01-131152-006");
                if (radioButton12.Checked)
                {
                    attendanceMark = "present";
                    sw.WriteLine(attendanceMark);
                }
                else
                {
                    attendanceMark = "absent";
                    sw.WriteLine(attendanceMark);
                }
                re6.Close();
            }
            if (re7.ReadLine() != " ")
            {
                sw.WriteLine("----------------");
                sw.WriteLine("01-131152-007");
                if (radioButton14.Checked)
                {
                    attendanceMark = "present";
                    sw.WriteLine(attendanceMark);
                }
                else
                {
                    attendanceMark = "absent";
                    sw.WriteLine(attendanceMark);
                }
                re7.Close();
            }
            if (re8.ReadLine() != " ")
            {
                sw.WriteLine("----------------");
                sw.WriteLine("01-131152-008");
                if (radioButton16.Checked)
                {
                    attendanceMark = "present";
                    sw.WriteLine(attendanceMark);
                }
                else
                {
                    attendanceMark = "absent";
                    sw.WriteLine(attendanceMark);
                }
                re8.Close();
            }
            if (re9.ReadLine() != " ")
            {
                sw.WriteLine("----------------");
                sw.WriteLine("01-131152-009");
                if (radioButton18.Checked)
                {
                    attendanceMark = "present";
                    sw.WriteLine(attendanceMark);
                }
                else
                {
                    attendanceMark = "absent";
                    sw.WriteLine(attendanceMark);
                }
                re9.Close();
            }
            if (re10.ReadLine() != " ")
            {
                sw.WriteLine("----------------");
                sw.WriteLine("01-131152-010");
                if (radioButton20.Checked)
                {
                    attendanceMark = "present";
                    sw.WriteLine(attendanceMark);
                }
                else
                {
                    attendanceMark = "absent";
                    sw.WriteLine(attendanceMark);
                }
                re10.Close();
            }
            sw.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            markAttendance();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            StreamReader re1 = File.OpenText(@"file.txt");
            if (re1.ReadLine() != " ")
            {
                groupBox1.Visible = true;

            }
            else

                groupBox1.Visible = false;
            re1.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            markAttendance();

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {
            StreamReader re1 = File.OpenText(@"file7.txt");
            if (re1.ReadLine() != " ")
            {
                groupBox7.Visible = true;

            }
            else
                groupBox7.Visible = false;
            re1.Close();

        }

        private void MarkAttendance_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            StreamReader re1 = File.OpenText(@"file2.txt");
            if (re1.ReadLine() != " ")
            {
                groupBox2.Visible = true;

            }
            else
                groupBox2.Visible = false;
            re1.Close();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            StreamReader re1 = File.OpenText(@"file3.txt");
            if (re1.ReadLine() != " ")
            {
                groupBox3.Visible = true;

            }
            else
                groupBox3.Visible = false;
            re1.Close();

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            StreamReader re1 = File.OpenText(@"file4.txt");
            if (re1.ReadLine() != " ")
            {
                groupBox4.Visible = true;

            }
            else
                groupBox4.Visible = false;

            re1.Close();

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
            StreamReader re1 = File.OpenText(@"file5.txt");
            if (re1.ReadLine() != " ")
            {
                groupBox5.Visible = true;

            }
            else
                groupBox5.Visible = false;
            re1.Close();

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
            StreamReader re1 = File.OpenText(@"file6.txt");
            if (re1.ReadLine() != " ")
            {
                groupBox6.Visible = true;

            }
            else
                groupBox6.Visible = false;
            re1.Close();

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {
            StreamReader re1 = File.OpenText(@"file8.txt");
            if (re1.ReadLine() != " ")
            {
                groupBox8.Visible = true;

            }
            else
                groupBox8.Visible = false;
            re1.Close();

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {
            StreamReader re1 = File.OpenText(@"file9.txt");
            if (re1.ReadLine() != " ")
            {
                groupBox9.Visible = true;

            }
            else

                groupBox9.Visible = false;
            re1.Close();

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {
            StreamReader re10 = File.OpenText(@"file10.txt");
            if (re10.ReadLine() != " ")
            {
                groupBox10.Visible = true;

            }
            else
                groupBox10.Visible = false;
            re10.Close();

        }
    }
}
