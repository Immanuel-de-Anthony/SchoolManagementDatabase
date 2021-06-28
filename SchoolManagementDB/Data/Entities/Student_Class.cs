using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDB.Data.Entities
{
    public class Student_Class
    {
        public DateTime? date_from { get; set; }
        public DateTime? date_to { get; set; }
        public int Academic_Fee { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Class Class { get; set; }

    }

    public class Student_Class_Config : EntityTypeConfiguration<Student_Class>
    {

        public Student_Class_Config()
        {
            HasKey(e => new { e.StudentId, e.ClassId });
        }

    }
}
