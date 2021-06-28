using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDB.Data.Entities
{
    public class Student
    {
        public Student()
        {
            Student_Classes = new HashSet<Student_Class>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime? DOB { get; set; }
        public virtual Parents Parents { get; set; }
        public virtual ICollection<Student_Class> Student_Classes { get; set; }
    }

    public class StudentConfig : EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            HasOptional(e => e.Parents).WithRequired(e => e.Student);
        }
    }
}
