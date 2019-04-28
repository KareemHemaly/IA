﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.DAL.Entity
{
    public class ProjectStatu
    {
        public string Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsAssigned { get; set; }
          
        public string Project_Id { get; set; }
        public virtual Project Projects { get; set; }


    }
}
