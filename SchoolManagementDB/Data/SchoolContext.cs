using SchoolManagementDB.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDB.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Configurations.Add(new Student_Class_Config());
            builder.Configurations.Add(new ParentsConfig());
            builder.Configurations.Add(new StudentConfig());
            builder.Configurations.Add(new QualificationConfig());
            
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Student_Class> Student_Classes { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Parents> Parents { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        
    }
}