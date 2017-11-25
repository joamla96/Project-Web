using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void RemoveUser(User user);
        User GetUser(User user);
        User GetUserByUsername(string username);

        List<User> GetAllUsers();

    }
}
