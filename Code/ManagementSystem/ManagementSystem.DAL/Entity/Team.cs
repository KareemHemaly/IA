using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.DAL.Entity
{
    public class Team
    {
        public string Id { get; set; }
        public bool IsActive { get; set; }

        public string Project_Id { get; set; }
        public virtual Project Project { get; set; }

        public string Member_Id { get; set; } 
        public virtual Users User_Id { get; set; }
    }
}
