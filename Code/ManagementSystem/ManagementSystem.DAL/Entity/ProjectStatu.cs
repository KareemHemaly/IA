using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.DAL.Entity
{
    public class ProjectStatu
    {
        public int Id { get; set; }
        public bool Has_TM { get; set; }
        public bool Has_PM { get; set; }
          
        public int Project_Id { get; set; }
        public virtual Project Projects { get; set; }


    }
}
