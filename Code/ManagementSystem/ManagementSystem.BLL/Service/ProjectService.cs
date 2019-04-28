﻿using Common.IRepository;
using ManagementSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.BLL.Service
{
    public class ProjectService
    {
        private IRepository<Project> _project;

        public ProjectService()
        {
                
        }

        public void update(int id)
        {
            Project project = _project.GetAll().Where(x => x.Id == id).FirstOrDefault();
            project.IsAssigned = false;
            _project.Add(project);
            _project.Save();
        }


    }
}
