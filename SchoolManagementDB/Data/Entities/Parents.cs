using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDB.Data.Entities
{
    public class Parents
    {
        public int StudentId { get; set; }
        public string Father_Name { get; set; }
        public string Mother_Name { get; set; }
        public virtual Student Student { get; set; }
    }

    public class ParentsConfig : EntityTypeConfiguration<Parents>
    {
        public ParentsConfig()
        {
            HasKey(e => e.StudentId);
            
        }
    }
}
