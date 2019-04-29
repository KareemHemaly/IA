using Common.IRepository;
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

        public ProjectService(IRepository<Project> project)
        {
            _project = project;

        }

        public void update(int id)
        {
            Project project = _project.GetAll().Where(x => x.Id == id).FirstOrDefault();
            project.Cloumn = false;
            _project.Add(project);
            _project.Save();
        }

        public bool Add(Project project)
        {
            try
            {
                _project.Add(project);
                _project.Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Edit(Project project)
        {
            try
            {
                _project.Edit(project);
                _project.Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Delete(Project project)
        {
            try
            {
                _project.Delete(project);
                _project.Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }



    }
}
