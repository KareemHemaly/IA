using ManagementSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.DTO.DTO
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Mobile { get; set; }
        public string JDescription { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }

        public string User_Type { get; set; }
        public virtual Roles Users_type { get; set; }

        public UserDTO MapToDTO(Users users)
        {
            UserDTO user = new UserDTO();
            user.FName = users.FName;
            user.LName = users.LName;
            user.Mobile = users.Mobile;
            user.JDescription = users.JDescription;
            user.Photo = users.Photo;
            user.Email = users.Email;
            user.User_Type = users.User_Type;

            return user;
        }
    }
}
