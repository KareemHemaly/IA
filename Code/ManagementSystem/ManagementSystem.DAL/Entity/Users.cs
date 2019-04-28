using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.DAL.Entity
{
    public class Users
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Mobile { get; set; } 
        public string JDescription { get; set; } 
        public string Photo { get; set; }
        public string Email { get; set; }

        public int User_Type { get; set; }
        public virtual Roles Users_type { get; set; }
    }
}
