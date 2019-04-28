using Common.IRepository;
using ManagementSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.BLL.Service
{
    class TeamService
    {

        private IRepository<Team> _team;

        public TeamService(IRepository<Team> team)
        {
            _team = team;

        }



    }
}
