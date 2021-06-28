using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDB.Data.Entities
{
    public class Teacher
    {
        public Teacher()
        {
            Classes = new HashSet<Class>();
            Qualifications = new HashSet<Qualification>();

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime? DOJ { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Qualification> Qualifications { get; set; }

       
    }

  
}
