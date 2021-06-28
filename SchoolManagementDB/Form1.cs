using SchoolManagementDB.Data;
using SchoolManagementDB.Data.Entities;
using SchoolManagementDB.Data.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SchoolManagementDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            SetupData();
        }

        BackgroundWorker bw;

        private void SetupData()
        {
            label2.Text = "Setting up data please wait...";

            bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;

            bw.RunWorkerAsync();
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var initializer = new MigrateDatabaseToLatestVersion<SchoolContext, Configuration>();
                Database.SetInitializer(initializer);

                using (var ctx = new SchoolContext())
                {
                    if (!ctx.Classes.Any())
                    {
                        var classes = new List<Class>()
                        {
                            new Class(){Class_Name="First",Section_Name ="A"},
                            new Class(){Class_Name="First",Section_Name ="B"},
                            new Class(){Class_Name="Second",Section_Name ="A"},
                            new Class(){Class_Name="Third",Section_Name ="A"}

                        };
                        classes.First().Subjects.Add(new Subject() { Subject_Name = "English" });
                        classes.First().Subjects.Add(new Subject() { Subject_Name = "Science" });
                        classes.First().Teachers.Add(new Teacher() { Name = "Fiona", Gender = "Female", Age = 27 });
                        ctx.Classes.AddRange(classes);
                    }

                    if (!ctx.Students.Any())
                    {
                        var students = new List<Student>()
                        {
                            new Student()
                            {
                                Name = "Chloe",
                                Gender = "Female",
                                Age = 6,
                                DOB = new DateTime(2015,04,30),

                                Student_Classes = new List<Student_Class>()
                                {
                                    new Student_Class(){ClassId = 1, date_from = new DateTime(2006,06,03), Academic_Fee = 28000}

                                }
                            },

                            new Student()
                            {
                                Name = "Daniel",
                                Gender = "Male",
                                Age = 8,
                                DOB = new DateTime(2013,02,12),
                                Parents =  new Parents(){Father_Name = "George", Mother_Name = "Ellen"},

                                Student_Classes = new List<Student_Class>()
                                {
                                    new Student_Class(){ClassId = 5, date_from = new DateTime(2020,06,01), date_to = new DateTime(2021,03,27), Academic_Fee = 30000},
                                    new Student_Class(){ClassId = 6, date_from = new DateTime(2021,06,03), Academic_Fee = 32000}

                                }
                            },

                        };
                        ctx.Students.AddRange(students);
                    }

                    if (!ctx.Teachers.Any())
                    {
                        var teachers = new List<Teacher>()
                        {
                            new Teacher()
                            {
                                Name="Bronson",
                                Gender ="Male",
                                Age = 32,
                                DOJ = new DateTime(2010,08,04),
                                Classes = new List<Class>
                                {
                                    new Class(){Class_Name = "Sixth", Section_Name = "B"},
                                    new Class(){Class_Name = "Seventh", Section_Name = "B"}
                                },
                                Qualifications = new List<Qualification>()
                                {
                                    new Qualification(){Qualification_Name = "M.Sc", Institution_Name = "Manasa Gangotri"},
                                    new Qualification(){Qualification_Name = "B.Ed", Institution_Name = "Kuvempu University"},
                                }


                            },


                        };
                        ctx.Teachers.AddRange(teachers);
                    }



                    ctx.SaveChanges();
                    e.Result = "Ready!";
                }
            }
            catch (Exception ex)
            {
                e.Result = ex.Message;
            }
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label2.Text = e.Result.ToString();
        }
       

        private void query1_Click(object sender, EventArgs e)
        {
            using (var ctx = new SchoolContext())
            {
                //Random Query to get Class name which is taught by Fiona Madam and has Science subject in its Syllabus
                
                var Query1 = ctx.Classes.Where(s => s.Teachers.Any(m => m.Name == "Fiona") && s.Subjects.Any(n => n.Subject_Name == "Science")).Select(c => new { c.Class_Name, c.Section_Name });

                dataGridView1.DataSource = Query1.ToList();      
                                              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var ctx = new SchoolContext())
            {
                //Student and Class details of Student with Student Id = 1

                var StudentDetails = ctx.Student_Classes.Where(s => s.StudentId == 1).Select(s => new { s.Student.Name, s.date_from, s.date_to, s.Class.Class_Name, s.Class.Section_Name });

                dataGridView1.DataSource = StudentDetails.ToList();


            }


        }

        private void Query3_Click(object sender, EventArgs e)
        {
            using (var ctx = new SchoolContext())
            {
                //Total Fee paid to school till now by Student with Student Id = 2

                var StudentName = ctx.Students.SqlQuery("select * from students where Id=2");
                var name = StudentName.FirstOrDefault()?.Name ?? "NA";


                decimal TotalStudyFee = 0;
                var Fee = ctx.Students.Where(s => s.Id == 2).SelectMany(s => s.Student_Classes);
                TotalStudyFee = Fee.Sum(s => s.Academic_Fee);

                MessageBox.Show($"{name} has paid a Total of {TotalStudyFee} for his studies till now");


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

