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


        public bool Add(Users user)
        {
            try
            {
                _user.Add(user);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Edit(Users user)
        {
            try
            {
                _user.Edit(user);
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
               
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<Users> Get()
        {
            return _user.GetAll();
        }
        public Users get(string email,string pass)
        {
          return  Get().Where(m => m.Email == email && m.Password == pass).FirstOrDefault();
        }

    }
}
