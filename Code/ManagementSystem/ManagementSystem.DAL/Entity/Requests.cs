using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.DAL.Entity
{
    public class Requests
    {
        public int Id { get; set; }  
        public int Created_By { get; set; }
        public string Project_id { get; set; }
        public int Sent_To { get; set; }
        public bool Approved { get; set; }

        public int Request_Type_Id { get; set; }
        public virtual Request_Type Request_Type_Idest { get; set; }

        public int User_Type { get; set; }
        public virtual Roles Users_type { get; set; }


    }
}
