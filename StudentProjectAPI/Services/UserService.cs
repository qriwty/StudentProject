using System.Collections.Generic;
using StudentProjectAPI.Interfaces.Services;
using StudentProjectAPI.Models;

namespace StudentProjectAPI.Services
{
    public class UserService : IUserService
    {
        public List<User> GetUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    Name = "Super admin",
                    Email = "email@gmail.com"
                }
            };
        }
    }
}
