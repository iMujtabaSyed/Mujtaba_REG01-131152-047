using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*Syed Mujtaba Haider
   01-131152-047
   BSE 6A
   */

namespace VP_Assignment_1
{
    
        class Program
        {

            private static int choice;
            private string name;
            private string department;
            private string semester;
            private float gpa;
            private string id;
            private double one, two, three;
            string attendanceMark;

            public void WriteStudent1()
            {

                StreamWriter sw = File.CreateText(@"F:\file.txt");
                sw.AutoFlush = true;

                Console.WriteLine("Please Enter Student Details");
                sw.WriteLine("--------------------");
                Console.WriteLine("Student ID :");
                sw.WriteLine("Student ID :");
                id = "01-131152-001";
                Console.WriteLine(id);
                sw.WriteLine(id);
                Console.WriteLine("Please Enter Name");
                name = Console.ReadLine();
                sw.WriteLine("Student Name :");
                sw.WriteLine(name);
                Console.WriteLine("Student Semester");
                semester = Console.ReadLine();
                sw.WriteLine("Student Contact No :");
                sw.WriteLine(semester);
                Console.WriteLine("Please Student GPA");
                gpa = float.Parse(Console.ReadLine());
                sw.WriteLine("Student GPA :");
                sw.WriteLine(gpa);
                Console.WriteLine("Please enter department");
                department = Console.ReadLine();
                sw.WriteLine("Student department :");
                sw.WriteLine(department);
                sw.Close();


            }
            public void WriteStudent2()
            {
                StreamWriter sw = File.CreateText(@"F:\file2.txt");
                sw.AutoFlush = true;

                Console.WriteLine("Please Enter Student Details");
                sw.WriteLine("--------------------");
                Console.WriteLine("Student ID :");
                sw.WriteLine("Student ID :");
                id = "01-131152-002";
                Console.WriteLine(id);
                sw.WriteLine(id);
                Console.WriteLine("Please Enter Name");
                name = Console.ReadLine();
                sw.WriteLine("Student Name :");
                sw.WriteLine(name);
                Console.WriteLine("Student Semester");
                semester = Console.ReadLine();
                sw.WriteLine("Student Contact No :");
                sw.WriteLine(semester);
                Console.WriteLine("Please Student GPA");
                gpa = float.Parse(Console.ReadLine());
                sw.WriteLine("Student GPA :");
                sw.WriteLine(gpa);
                Console.WriteLine("Please enter department");
                department = Console.ReadLine();
                sw.WriteLine("Student department :");
                sw.WriteLine(department);
                sw.Close();

            }
            public void WriteStudent3()
            {
                StreamWriter sw = File.CreateText(@"F:\file3.txt");
                sw.AutoFlush = true;

                Console.WriteLine("Please Enter Student Details");
                sw.WriteLine("--------------------");
                Console.WriteLine("Student ID :");
                sw.WriteLine("Student ID :");
                id = "01-131152-003";
                Console.WriteLine(id);
                sw.WriteLine(id);
                Console.WriteLine("Please Enter Name");
                name = Console.ReadLine();
                sw.WriteLine("Student Name :");
                sw.WriteLine(name);
                Console.WriteLine("Student Semester");
                semester = Console.ReadLine();
                sw.WriteLine("Student Contact No :");
                sw.WriteLine(semester);
                Console.WriteLine("Please Student GPA");
                gpa = float.Parse(Console.ReadLine());
                sw.WriteLine("Student GPA :");
                sw.WriteLine(gpa);
                Console.WriteLine("Please enter department");
                department = Console.ReadLine();
                sw.WriteLine("Student department :");
                sw.WriteLine(department);
                sw.Close();

            }
            public void WriteStudent4()
            {
                StreamWriter sw = File.CreateText(@"F:\file4.txt");
                sw.AutoFlush = true;

                Console.WriteLine("Please Enter Student Details");
                sw.WriteLine("--------------------");
                Console.WriteLine("Student ID :");
                sw.WriteLine("Student ID :");
                id = "01-131152-004";
                Console.WriteLine(id);
                sw.WriteLine(id);
                Console.WriteLine("Please Enter Name");
                name = Console.ReadLine();
                sw.WriteLine("Student Name :");
                sw.WriteLine(name);
                Console.WriteLine("Student Semester");
                semester = Console.ReadLine();
                sw.WriteLine("Student Contact No :");
                sw.WriteLine(semester);
                Console.WriteLine("Please Student GPA");
                gpa = float.Parse(Console.ReadLine());
                sw.WriteLine("Student GPA :");
                sw.WriteLine(gpa);
                Console.WriteLine("Please enter department");
                department = Console.ReadLine();
                sw.WriteLine("Student department :");
                sw.WriteLine(department);
                sw.Close();

            }
            public void WriteStudent5()
            {
                StreamWriter sw = File.CreateText(@"F:\file5.txt");
                sw.AutoFlush = true;

                Console.WriteLine("Please Enter Student Details");
                sw.WriteLine("--------------------");
                Console.WriteLine("Student ID :");
                sw.WriteLine("Student ID :");
                id = "01-131152-005";
                Console.WriteLine(id);
                sw.WriteLine(id);
                Console.WriteLine("Please Enter Name");
                name = Console.ReadLine();
                sw.WriteLine("Student Name :");
                sw.WriteLine(name);
                Console.WriteLine("Student Semester");
                semester = Console.ReadLine();
                sw.WriteLine("Student Contact No :");
                sw.WriteLine(semester);
                Console.WriteLine("Please Student GPA");
                gpa = float.Parse(Console.ReadLine());
                sw.WriteLine("Student GPA :");
                sw.WriteLine(gpa);
                Console.WriteLine("Please enter department");
                department = Console.ReadLine();
                sw.WriteLine("Student department :");
                sw.WriteLine(department);
                sw.Close();

            }
            public void WriteStudent6()
            {
                StreamWriter sw = File.CreateText(@"F:\file6.txt");
                sw.AutoFlush = true;

                Console.WriteLine("Please Enter Student Details");
                sw.WriteLine("--------------------");
                Console.WriteLine("Student ID :");
                sw.WriteLine("Student ID :");
                id = "01-131152-006";
                Console.WriteLine(id);
                sw.WriteLine(id);
                Console.WriteLine("Please Enter Name");
                name = Console.ReadLine();
                sw.WriteLine("Student Name :");
                sw.WriteLine(name);
                Console.WriteLine("Student Semester");
                semester = Console.ReadLine();
                sw.WriteLine("Student Contact No :");
                sw.WriteLine(semester);
                Console.WriteLine("Please Student GPA");
                gpa = float.Parse(Console.ReadLine());
                sw.WriteLine("Student GPA :");
                sw.WriteLine(gpa);
                Console.WriteLine("Please enter department");
                department = Console.ReadLine();
                sw.WriteLine("Student department :");
                sw.WriteLine(department);
                sw.Close();

            }
            public void WriteStudent7()
            {
                StreamWriter sw = File.CreateText(@"F:\file7.txt");
                sw.AutoFlush = true;

                Console.WriteLine("Please Enter Student Details");
                sw.WriteLine("--------------------");
                Console.WriteLine("Student ID :");
                sw.WriteLine("Student ID :");
                id = "01-131152-007";
                Console.WriteLine(id);
                sw.WriteLine(id);
                Console.WriteLine("Please Enter Name");
                name = Console.ReadLine();
                sw.WriteLine("Student Name :");
                sw.WriteLine(name);
                Console.WriteLine("Student Semester");
                semester = Console.ReadLine();
                sw.WriteLine("Student Contact No :");
                sw.WriteLine(semester);
                Console.WriteLine("Please Student GPA");
                gpa = float.Parse(Console.ReadLine());
                sw.WriteLine("Student GPA :");
                sw.WriteLine(gpa);
                Console.WriteLine("Please enter department");
                department = Console.ReadLine();
                sw.WriteLine("Student department :");
                sw.WriteLine(department);
                sw.Close();

            }
            public void WriteStudent8()
            {
                StreamWriter sw = File.CreateText(@"F:\file8.txt");
                sw.AutoFlush = true;

                Console.WriteLine("Please Enter Student Details");
                sw.WriteLine("--------------------");
                Console.WriteLine("Student ID :");
                sw.WriteLine("Student ID :");
                id = "01-131152-008";
                Console.WriteLine(id);
                sw.WriteLine(id);
                Console.WriteLine("Please Enter Name");
                name = Console.ReadLine();
                sw.WriteLine("Student Name :");
                sw.WriteLine(name);
                Console.WriteLine("Student Semester");
                semester = Console.ReadLine();
                sw.WriteLine("Student Contact No :");
                sw.WriteLine(semester);
                Console.WriteLine("Please Student GPA");
                gpa = float.Parse(Console.ReadLine());
                sw.WriteLine("Student GPA :");
                sw.WriteLine(gpa);
                Console.WriteLine("Please enter department");
                department = Console.ReadLine();
                sw.WriteLine("Student department :");
                sw.WriteLine(department);
                sw.Close();

            }
            public void WriteStudent9()
            {
                StreamWriter sw = File.CreateText(@"F:\file9.txt");
                sw.AutoFlush = true;

                Console.WriteLine("Please Enter Student Details");
                sw.WriteLine("--------------------");
                Console.WriteLine("Student ID :");
                sw.WriteLine("Student ID :");
                id = "01-131152-009";
                Console.WriteLine(id);
                sw.WriteLine(id);
                Console.WriteLine("Please Enter Name");
                name = Console.ReadLine();
                sw.WriteLine("Student Name :");
                sw.WriteLine(name);
                Console.WriteLine("Student Semester");
                semester = Console.ReadLine();
                sw.WriteLine("Student Contact No :");
                sw.WriteLine(semester);
                Console.WriteLine("Please Student GPA");
                gpa = float.Parse(Console.ReadLine());
                sw.WriteLine("Student GPA :");
                sw.WriteLine(gpa);
                Console.WriteLine("Please enter department");
                department = Console.ReadLine();
                sw.WriteLine("Student department :");
                sw.WriteLine(department);
                sw.Close();

            }
            public void WriteStudent10()
            {
                StreamWriter sw = File.CreateText(@"F:\file10.txt");
                sw.AutoFlush = true;

                Console.WriteLine("Please Enter Student Details");
                sw.WriteLine("--------------------");
                Console.WriteLine("Student ID :");
                sw.WriteLine("Student ID :");
                id = "01-131152-010";
                Console.WriteLine(id);
                sw.WriteLine(id);
                Console.WriteLine("Please Enter Name");
                name = Console.ReadLine();
                sw.WriteLine("Student Name :");
                sw.WriteLine(name);
                Console.WriteLine("Student Semester");
                semester = Console.ReadLine();
                sw.WriteLine("Student Contact No :");
                sw.WriteLine(semester);
                Console.WriteLine("Please Student GPA");
                gpa = float.Parse(Console.ReadLine());
                sw.WriteLine("Student GPA :");
                sw.WriteLine(gpa);
                Console.WriteLine("Please enter department");
                department = Console.ReadLine();
                sw.WriteLine("Student department :");
                sw.WriteLine(department);
                sw.Close();

            }
            public void readStudentID(string id)
            {
                if (id == "01-131152-001")
                {
                    StreamReader re = File.OpenText(@"F:\file.txt");
                    Console.Write(re.ReadToEnd());
                    re.Close();
                }
                if (id == "01-131152-002")
                {
                    StreamReader re = File.OpenText(@"F:\file2.txt");
                    Console.Write(re.ReadToEnd());
                    re.Close();

                }
                if (id == "01-131152-003")
                {
                    StreamReader re = File.OpenText(@"F:\file3.txt");
                    Console.Write(re.ReadToEnd());
                    re.Close();
                }
                if (id == "01-131152-004")
                {
                    StreamReader re = File.OpenText(@"F:\file4.txt");
                    Console.Write(re.ReadToEnd());
                    re.Close();
                }
                if (id == "01-131152-005")
                {
                    StreamReader re = File.OpenText(@"F:\file5.txt");
                    Console.Write(re.ReadToEnd());
                    re.Close();
                }
                if (id == "01-131152-006")
                {
                    StreamReader re = File.OpenText(@"F:\file6.txt");
                    Console.Write(re.ReadToEnd());
                    re.Close();
                }
                if (id == "01-131152-007")
                {
                    StreamReader re = File.OpenText(@"F:\file7.txt");
                    Console.Write(re.ReadToEnd());
                    re.Close();
                }
                if (id == "01-131152-008")
                {
                    StreamReader re = File.OpenText(@"F:\file8.txt");
                    Console.Write(re.ReadToEnd());
                    re.Close();
                }
                if (id == "01-131152-009")
                {
                    StreamReader re = File.OpenText(@"F:\file9.txt");
                    Console.Write(re.ReadToEnd());
                    re.Close();
                }
                if (id == "01-131152-010")
                {
                    StreamReader re = File.OpenText(@"F:\file10.txt");
                    Console.Write(re.ReadToEnd());
                    re.Close();
                }
                else
                    Console.WriteLine("Wrong Enrollment");
            }
            public void topGPA()
            {
                double[] maxi = new double[10];
                StreamReader file = new StreamReader(@"F:\file.txt");
                StreamReader file2 = new StreamReader(@"F:\file2.txt");
                StreamReader file3 = new StreamReader(@"F:\file3.txt");
                StreamReader file4 = new StreamReader(@"F:\file4.txt");
                StreamReader file5 = new StreamReader(@"F:\file5.txt");
                StreamReader file6 = new StreamReader(@"F:\file6.txt");
                StreamReader file7 = new StreamReader(@"F:\file7.txt");
                StreamReader file8 = new StreamReader(@"F:\file8.txt");
                StreamReader file9 = new StreamReader(@"F:\file9.txt");
                StreamReader file10 = new StreamReader(@"F:\file10.txt");
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                double maxgpa = double.Parse(file.ReadLine());
                file.Close();
                maxi[0] = maxgpa;
                file2.ReadLine();
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
                file3.ReadLine();
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
                file4.ReadLine();
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
                file5.ReadLine();
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
                file6.ReadLine();
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
                file7.ReadLine();
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
                file8.ReadLine();
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
                file9.ReadLine();
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
                file10.ReadLine();
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
            void showTop3()
            {
                topGPA();
                StreamReader file = new StreamReader(@"F:\file.txt");
                StreamReader file2 = new StreamReader(@"F:\file2.txt");
                StreamReader file3 = new StreamReader(@"F:\file3.txt");
                StreamReader file4 = new StreamReader(@"F:\file4.txt");
                StreamReader file5 = new StreamReader(@"F:\file5.txt");
                StreamReader file6 = new StreamReader(@"F:\file6.txt");
                StreamReader file7 = new StreamReader(@"F:\file7.txt");
                StreamReader file8 = new StreamReader(@"F:\file8.txt");
                StreamReader file9 = new StreamReader(@"F:\file9.txt");
                StreamReader file10 = new StreamReader(@"F:\file10.txt");
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                file.ReadLine();
                double maxgpa = double.Parse(file.ReadLine());
                if (maxgpa == one || maxgpa == two || maxgpa == three)
                {
                    StreamReader filex = new StreamReader(@"F:\file.txt");
                    Console.WriteLine(filex.ReadToEnd());
                    filex.Close();

                }
                file.Close();
                file2.ReadLine();
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
                    StreamReader filex = new StreamReader(@"F:\file2.txt");
                    Console.WriteLine(filex.ReadToEnd());
                    filex.Close();

                }
                file2.Close();
                file3.ReadLine();
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
                    StreamReader filex = new StreamReader(@"F:\file3.txt");
                    Console.WriteLine(filex.ReadToEnd());
                    filex.Close();
                }
                file3.Close();
                file4.ReadLine();
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
                    StreamReader filex = new StreamReader(@"F:\file4.txt");
                    Console.WriteLine(filex.ReadToEnd());
                    filex.Close();
                }
                file4.Close();
                file5.ReadLine();
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
                    StreamReader filex = new StreamReader(@"F:\file5.txt");
                    Console.WriteLine(filex.ReadToEnd());
                    filex.Close();
                }
                file5.Close();
                file6.ReadLine();
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
                    StreamReader filex = new StreamReader(@"F:\file6.txt");
                    Console.WriteLine(filex.ReadToEnd());
                    filex.Close();
                }
                file6.Close();
                file7.ReadLine();
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
                    StreamReader filex = new StreamReader(@"F:\file7.txt");
                    Console.WriteLine(filex.ReadToEnd());
                    filex.Close();
                }
                file7.Close();
                file8.ReadLine();
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
                    StreamReader filex = new StreamReader(@"F:\file8.txt");
                    Console.WriteLine(filex.ReadToEnd());
                    filex.Close();
                }
                file8.Close();
                file9.ReadLine();
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
                    StreamReader filex = new StreamReader(@"F:\file9.txt");
                    Console.WriteLine(filex.ReadToEnd());
                    filex.Close();
                }
                file9.Close();
                file10.ReadLine();
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
                    StreamReader filex = new StreamReader(@"F:\file10.txt");
                    Console.WriteLine(filex.ReadToEnd());
                    filex.Close();
                }
                file10.Close();
            }
            public void showAll()
            {
                StreamReader re1 = File.OpenText(@"F:\file.txt");
                Console.WriteLine(re1.ReadToEnd());
                re1.Close();
                StreamReader re2 = File.OpenText(@"F:\file2.txt");
                Console.WriteLine(re2.ReadToEnd());
                re2.Close();
                StreamReader re3 = File.OpenText(@"F:\file3.txt");
                Console.WriteLine(re3.ReadToEnd());
                re3.Close();
                StreamReader re4 = File.OpenText(@"F:\file4.txt");
                Console.WriteLine(re4.ReadToEnd());
                re4.Close();
                StreamReader re5 = File.OpenText(@"F:\file5.txt");
                Console.WriteLine(re5.ReadToEnd());
                re5.Close();
                StreamReader re6 = File.OpenText(@"F:\file6.txt");
                Console.WriteLine(re6.ReadToEnd());
                re6.Close();
                StreamReader re7 = File.OpenText(@"F:\file7.txt");
                Console.WriteLine(re7.ReadToEnd());
                re7.Close();
                StreamReader re8 = File.OpenText(@"F:\file8.txt");
                Console.WriteLine(re8.ReadToEnd());
                re8.Close();
                StreamReader re9 = File.OpenText(@"F:\file9.txt");
                Console.WriteLine(re9.ReadToEnd());
                re9.Close();
                StreamReader re10 = File.OpenText(@"F:\file10.txt");
                Console.WriteLine(re10.ReadToEnd());
                re10.Close();
            }
            public void deleteStudent(string name)
            {
                StreamReader file = new StreamReader(@"F:\file.txt");
                StreamReader file2 = new StreamReader(@"F:\file2.txt");
                StreamReader file3 = new StreamReader(@"F:\file3.txt");
                StreamReader file4 = new StreamReader(@"F:\file4.txt");
                StreamReader file5 = new StreamReader(@"F:\file5.txt");
                StreamReader file6 = new StreamReader(@"F:\file6.txt");
                StreamReader file7 = new StreamReader(@"F:\file7.txt");
                StreamReader file8 = new StreamReader(@"F:\file8.txt");
                StreamReader file9 = new StreamReader(@"F:\file9.txt");
                StreamReader file10 = new StreamReader(@"F:\file10.txt");
                string stringToSearch1 = name;
                string[] lines = File.ReadAllLines(@"F:\file.txt");
                file.Close();
                string stringToSearch2 = name;
                string[] lines2 = File.ReadAllLines(@"F:\file2.txt");
                file2.Close();
                string stringToSearch3 = name;
                string[] lines3 = File.ReadAllLines(@"F:\file3.txt");
                file3.Close();
                string stringToSearch4 = name;
                string[] lines4 = File.ReadAllLines(@"F:\file4.txt");
                file4.Close();
                string stringToSearch5 = name;
                string[] lines5 = File.ReadAllLines(@"F:\file5.txt");
                file5.Close();
                string stringToSearch6 = name;
                string[] lines6 = File.ReadAllLines(@"F:\file6.txt");
                file6.Close();
                string stringToSearch7 = name;
                string[] lines7 = File.ReadAllLines(@"F:\file7.txt");
                file7.Close();
                string stringToSearch8 = name;
                string[] lines8 = File.ReadAllLines(@"F:\file8.txt");
                file8.Close();
                string stringToSearch9 = name;
                string[] lines9 = File.ReadAllLines(@"F:\file9.txt");
                file9.Close();
                string stringToSearch10 = name;
                string[] lines10 = File.ReadAllLines(@"F:\file10.txt");
                file10.Close();

                foreach (string line in lines)
                {
                    if (line.Contains(stringToSearch1))
                    {
                        StreamWriter filex = new StreamWriter(@"F:\file.txt");
                        filex.WriteLine(" ");
                        filex.Close();

                    }

                }
                foreach (string line in lines2)
                {
                    if (line.Contains(stringToSearch2))
                    {
                        StreamWriter filex = new StreamWriter(@"F:\file2.txt");
                        filex.WriteLine(" ");
                        filex.Close();

                    }

                }

                foreach (string line in lines3)
                {
                    if (line.Contains(stringToSearch3))
                    {
                        StreamWriter filex = new StreamWriter(@"F:\file3.txt");
                        filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
                foreach (string line in lines4)
                {
                    if (line.Contains(stringToSearch4))
                    {
                        StreamWriter filex = new StreamWriter(@"F:\file4.txt");
                        filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
                foreach (string line in lines5)
                {
                    if (line.Contains(stringToSearch5))
                    {
                        StreamWriter filex = new StreamWriter(@"F:\file5.txt");
                        filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
                foreach (string line in lines6)
                {
                    if (line.Contains(stringToSearch6))
                    {
                        StreamWriter filex = new StreamWriter(@"F:\file6.txt");
                        filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
                foreach (string line in lines7)
                {
                    if (line.Contains(stringToSearch7))
                    {
                        StreamWriter filex = new StreamWriter(@"F:\file7.txt");
                        filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
                foreach (string line in lines8)
                {
                    if (line.Contains(stringToSearch8))
                    {
                        StreamWriter filex = new StreamWriter(@"F:\file8.txt");
                        filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
                foreach (string line in lines9)
                {
                    if (line.Contains(stringToSearch9))
                    {
                        StreamWriter filex = new StreamWriter(@"F:\file9.txt");
                        filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
                foreach (string line in lines10)
                {
                    if (line.Contains(stringToSearch10))
                    {
                        StreamWriter filex = new StreamWriter(@"F:\file10.txt");
                        filex.WriteLine(" "); ;
                        filex.Close();

                    }

                }
            }
            public void markAttendance()
            {
                StreamWriter sw = File.CreateText(@"F:\attendance.txt");
                sw.AutoFlush = true;
                Console.WriteLine("Attendance by Roll Number");
                Console.WriteLine("Type 'p' for Present and 'a' for absent");
                Console.WriteLine("----------------");
                sw.WriteLine("----------------");
                StreamReader re1 = File.OpenText(@"F:\file.txt");
                StreamReader re2 = File.OpenText(@"F:\file2.txt");
                StreamReader re3 = File.OpenText(@"F:\file3.txt");
                StreamReader re4 = File.OpenText(@"F:\file4.txt");
                StreamReader re5 = File.OpenText(@"F:\file5.txt");
                StreamReader re6 = File.OpenText(@"F:\file6.txt");
                StreamReader re7 = File.OpenText(@"F:\file7.txt");
                StreamReader re8 = File.OpenText(@"F:\file8.txt");
                StreamReader re9 = File.OpenText(@"F:\file9.txt");
                StreamReader re10 = File.OpenText(@"F:\file10.txt");
                if (re1.ReadLine() != " ")
                {
                    sw.WriteLine("----------------");
                    Console.WriteLine("01-131152-001");
                    sw.WriteLine("01-131152-001");
                    attendanceMark = Console.ReadLine();
                    sw.WriteLine(attendanceMark);
                    re1.Close();
                }
                if (re2.ReadLine() != " ")
                {
                    Console.WriteLine("----------------");
                    sw.WriteLine("----------------");
                    Console.WriteLine("01-131152-002");
                    sw.WriteLine("01-131152-002");
                    attendanceMark = Console.ReadLine();
                    sw.WriteLine(attendanceMark);
                    re2.Close();
                }

                if (re3.ReadLine() != " ")
                {
                    Console.WriteLine("----------------");
                    sw.WriteLine("----------------");
                    Console.WriteLine("01-131152-003");
                    sw.WriteLine("01-131152-003");
                    attendanceMark = Console.ReadLine();
                    sw.WriteLine(attendanceMark);
                    re3.Close();
                }

                if (re4.ReadLine() != " ")

                {
                    Console.WriteLine("----------------");
                    sw.WriteLine("----------------");
                    Console.WriteLine("01-131152-004");
                    sw.WriteLine("01-131152-004");
                    attendanceMark = Console.ReadLine();
                    sw.WriteLine(attendanceMark);
                    re4.Close();
                }
                if (re5.ReadLine() != " ")
                {
                    Console.WriteLine("----------------");
                    sw.WriteLine("----------------");
                    Console.WriteLine("01-131152-005");
                    sw.WriteLine("01-131152-005");
                    attendanceMark = Console.ReadLine();
                    sw.WriteLine(attendanceMark);
                    re5.Close();
                }
                if (re6.ReadLine() != " ")
                {
                    Console.WriteLine("----------------");
                    sw.WriteLine("----------------");
                    Console.WriteLine("01-131152-006");
                    sw.WriteLine("01-131152-006");
                    attendanceMark = Console.ReadLine();
                    sw.WriteLine(attendanceMark);
                    re6.Close();
                }
                if (re7.ReadLine() != " ")
                {
                    Console.WriteLine("----------------");
                    sw.WriteLine("----------------");
                    Console.WriteLine("01-131152-007");
                    sw.WriteLine("01-131152-007");
                    attendanceMark = Console.ReadLine();
                    sw.WriteLine(attendanceMark);
                    re7.Close();
                }
                if (re8.ReadLine() != " ")
                {
                    Console.WriteLine("----------------");
                    sw.WriteLine("----------------");
                    Console.WriteLine("01-131152-008");
                    sw.WriteLine("01-131152-008");
                    attendanceMark = Console.ReadLine();
                    sw.WriteLine(attendanceMark);
                    re8.Close();
                }
                if (re9.ReadLine() != " ")
                {
                    Console.WriteLine("----------------");
                    sw.WriteLine("----------------");
                    Console.WriteLine("01-131152-009");
                    sw.WriteLine("01-131152-009");
                    attendanceMark = Console.ReadLine();
                    sw.WriteLine(attendanceMark);
                    re9.Close();
                }
                if (re10.ReadLine() != " ")
                {
                    Console.WriteLine("----------------");
                    sw.WriteLine("----------------");
                    Console.WriteLine("01-131152-010");
                    sw.WriteLine("01-131152-010");
                    attendanceMark = Console.ReadLine();
                    sw.WriteLine(attendanceMark);
                    re9.Close();
                }
                sw.Close();
            }
            public void readStudentName(string name)
            {
                StreamReader file = new StreamReader(@"F:\file.txt");
                StreamReader file2 = new StreamReader(@"F:\file2.txt");
                StreamReader file3 = new StreamReader(@"F:\file3.txt");
                StreamReader file4 = new StreamReader(@"F:\file4.txt");
                StreamReader file5 = new StreamReader(@"F:\file5.txt");
                StreamReader file6 = new StreamReader(@"F:\file6.txt");
                StreamReader file7 = new StreamReader(@"F:\file7.txt");
                StreamReader file8 = new StreamReader(@"F:\file8.txt");
                StreamReader file9 = new StreamReader(@"F:\file9.txt");
                StreamReader file10 = new StreamReader(@"F:\file10.txt");
                string stringToSearch1 = name;
                string[] lines = File.ReadAllLines(@"F:\file.txt");
                string stringToSearch2 = name;
                string[] lines2 = File.ReadAllLines(@"F:\file2.txt");
                string stringToSearch3 = name;
                string[] lines3 = File.ReadAllLines(@"F:\file3.txt");
                string stringToSearch4 = name;
                string[] lines4 = File.ReadAllLines(@"F:\file4.txt");
                string stringToSearch5 = name;
                string[] lines5 = File.ReadAllLines(@"F:\file5.txt");
                string stringToSearch6 = name;
                string[] lines6 = File.ReadAllLines(@"F:\file6.txt");
                string stringToSearch7 = name;
                string[] lines7 = File.ReadAllLines(@"F:\file7.txt");
                string stringToSearch8 = name;
                string[] lines8 = File.ReadAllLines(@"F:\file8.txt");
                string stringToSearch9 = name;
                string[] lines9 = File.ReadAllLines(@"F:\file9.txt");
                string stringToSearch10 = name;
                string[] lines10 = File.ReadAllLines(@"F:\file10.txt");
                foreach (string line in lines)
                {
                    if (line.Contains(stringToSearch1))
                    {
                        Console.WriteLine(file.ReadToEnd());
                        file.Close();
                    }

                }
                foreach (string line in lines2)
                {
                    if (line.Contains(stringToSearch2))
                    {
                        Console.WriteLine(file2.ReadToEnd());
                        file2.Close();

                    }

                }

                foreach (string line in lines3)
                {
                    if (line.Contains(stringToSearch3))
                    {
                        Console.WriteLine(file3.ReadToEnd());
                        file3.Close();

                    }

                }

                foreach (string line in lines4)
                {
                    if (line.Contains(stringToSearch4))
                    {
                        Console.WriteLine(file4.ReadToEnd());
                        file4.Close();

                    }

                }

                foreach (string line in lines5)
                {
                    if (line.Contains(stringToSearch5))
                    {
                        Console.WriteLine(file5.ReadToEnd());
                        file5.Close();

                    }

                }

                foreach (string line in lines6)
                {
                    if (line.Contains(stringToSearch6))
                    {
                        Console.WriteLine(file6.ReadToEnd());
                        file6.Close();

                    }

                }

                foreach (string line in lines7)
                {
                    if (line.Contains(stringToSearch7))
                    {
                        Console.WriteLine(file7.ReadToEnd());
                        file7.Close();

                    }

                }


                foreach (string line in lines8)
                {
                    if (line.Contains(stringToSearch8))
                    {
                        Console.WriteLine(file8.ReadToEnd());
                        file8.Close();

                    }

                }

                foreach (string line in lines9)
                {
                    if (line.Contains(stringToSearch9))
                    {
                        Console.WriteLine(file9.ReadToEnd());
                        file9.Close();

                    }

                }

                foreach (string line in lines10)
                {
                    if (line.Contains(stringToSearch10))
                    {
                        Console.WriteLine(file10.ReadToEnd());
                        file10.Close();

                    }

                }

            }
            public void viewAttendance()
            {
                StreamReader re1 = File.OpenText(@"F:\attendance.txt");
                Console.WriteLine("Here's the Attendance List");
                Console.WriteLine(re1.ReadToEnd());
                re1.Close();
            }
            static void Main(string[] args)
            {

                Program obj = new Program();
                string searchName;
                Console.WriteLine("_____________________________");
                Console.WriteLine("Welcome to Student portal");
                Console.WriteLine("Please type in small caps");
                Console.WriteLine("_____________________________");

                do
                {
                    Console.WriteLine("Please Select from our Menu");
                    Console.WriteLine("Press 1 to Add New Students");
                    Console.WriteLine("Press 2 to Search Students by Name");
                    Console.WriteLine("Press 3 to Search By ID Students");
                    Console.WriteLine("Press 4 to View All Students");
                    Console.WriteLine("Press 5 to Delete Student by Name");
                    Console.WriteLine("Press 6 to Mark Attendance");
                    Console.WriteLine("Press 7 to View Attendance");
                    Console.WriteLine("Press 8 to show top 3 Students");
                    Console.WriteLine("Type '0' to exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        obj.WriteStudent1();
                        obj.WriteStudent2();
                        obj.WriteStudent3();
                        obj.WriteStudent4();
                        obj.WriteStudent5();
                        obj.WriteStudent6();
                        obj.WriteStudent7();
                        obj.WriteStudent8();
                        obj.WriteStudent9();
                        obj.WriteStudent10();
                    }
                    if (choice == 2)
                    {
                        Console.WriteLine("Pls enter the name of student");
                        searchName = Console.ReadLine();
                        obj.readStudentName(searchName);
                    }
                    if (choice == 3)
                    {
                        Console.WriteLine("Pls enter the enrollment no student");
                        searchName = Console.ReadLine();
                        obj.readStudentID(searchName);
                    }
                    if (choice == 4)
                    {
                        obj.showAll();
                    }
                    if (choice == 5)
                    {
                        Console.WriteLine("Pls enter the student Name to Delete his record");
                        searchName = Console.ReadLine();
                        obj.deleteStudent(searchName);
                        Console.WriteLine("We performed your operation");
                    }
                    if (choice == 6)
                    {
                        obj.markAttendance();
                    }
                    if (choice == 7)
                    {
                        obj.viewAttendance();
                    }
                    if (choice == 8)
                    {
                        Console.WriteLine("List of Top 3 Students Are:");
                        obj.showTop3();
                    }
                } while (choice != 0);

            }
        }
    }

