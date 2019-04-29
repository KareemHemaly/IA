using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.DAL.Entity
{
    public class Users
    {[Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Mobile { get; set; } 
        public string JDescription { get; set; } 
        public string Photo { get; set; }
        [StringLength(250)]
        [Index(IsUnique = true)]
        public string Email { get; set; }
        public string Password { get; set; }


        public int User_Type { get; set; }
        public virtual Roles Users_type { get; set; }
    }
}
