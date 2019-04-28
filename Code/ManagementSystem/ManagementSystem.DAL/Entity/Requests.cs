using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.DAL.Entity
{
    public class Requests
    {
        public string Id { get; set; }  
        public string Created_By { get; set; }
        public string Project_id { get; set; }
        public string Sent_To { get; set; }
        public bool Approved { get; set; }

        public string Request_Type_Id { get; set; }
        public virtual Request_Type Request_Type_Idest { get; set; }




    }
}
