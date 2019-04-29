using Common.IRepository;
using ManagementSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.BLL.Service
{
    public class UserService
    {
        private IRepository<Users> _user;
      
        public UserService(IRepository<Users> user)
        {
            _user = user;
        }


        public Users Add(Users user)
        {
            try
            {
                _user.Add(user);
                _user.Save();
                return user;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Edit(Users user)
        {
            try
            {
                _user.Edit(user);
                _user.Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Delete(Users user)
        {
            try
            {
                _user.Delete(user);
                _user.Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }



    }
}
