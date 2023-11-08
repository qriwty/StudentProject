using System.Collections.Generic;
using StudentProjectAPI.Models;


namespace StudentProjectAPI.Interfaces.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
    }
}
