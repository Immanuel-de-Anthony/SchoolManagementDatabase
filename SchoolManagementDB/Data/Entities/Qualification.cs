using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDB.Data.Entities
{
    public class Qualification
    {
        public int Id { get; set; }
        public string Qualification_Name { get; set; }
        public string Institution_Name { get; set; }
        public DateTime? DateofCompletion { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

    }

    public class QualificationConfig : EntityTypeConfiguration<Qualification>
    {
        public QualificationConfig()
        {
            
            Property(e => e.Institution_Name).HasMaxLength(20).IsRequired();
            
            
        }
    }
}
