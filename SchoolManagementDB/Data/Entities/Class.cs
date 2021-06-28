using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDB.Data.Entities
{
    public class Class
    {
        public Class()
        {
            Subjects = new HashSet<Subject>();
            Teachers = new HashSet<Teacher>();
            Student_Classes = new HashSet<Student_Class>();
        }
        public int Id { get; set; }
        public string Class_Name { get; set; }
        public string Section_Name { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Student_Class> Student_Classes { get; set; }


    }
}
