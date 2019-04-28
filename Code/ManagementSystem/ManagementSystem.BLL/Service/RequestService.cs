using Common.IRepository;
using ManagementSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.BLL.Service
{
    class RequestService
    {
        private IRepository<Requests> _Requests;

        public RequestService(IRepository<Requests> request)
        {
            _Requests = request;
        }

    }
}
