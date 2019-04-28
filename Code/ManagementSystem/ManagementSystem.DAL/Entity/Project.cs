using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.DAL.Entity
{
    public class Project
    {
        public string Id { get; set; }
        public string Name { get; set; }  
        public string price { get; set; }
        public string Created_By { get; set; }
        public string Start_Date { get; set; }
        public string End_Date { get; set; }
        public bool IsActive { get; set; }
        public bool IsAssigned { get; set; }
        public bool IsDelivered { get; set; }
    }
}
