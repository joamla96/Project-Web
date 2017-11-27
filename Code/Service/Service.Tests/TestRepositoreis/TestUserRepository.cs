using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Interfaces;

namespace Service.Tests.TestRepositoreis
{
    class TestUserRepository : IUserRepository
    {
        List<User> usersList = new List<User>();

        public void AddUser(User user)
        {
            usersList.Add(user);
        }

        public void RemoveUser(User user)
        {
            usersList.Remove(user);
        }

        public User GetUser(User user)
        {
            User result = null;
            foreach (User item in usersList)
            {
                if (item.Equals(user))
                {
                    result = item;

                }

            }
            if (result == null)
            {
                throw new NullReferenceException();
            }
            return result;

        }

        public User GetUserByUsername(string username)
        {
            User result = null;
            foreach (User item in usersList)
            {
                if (username.Equals(item.Username))
                {
                    result = item;
                }
            }
            if (result == null)
            {
                throw new NullReferenceException();
            }
            return result;
        }

        public List<User> GetAllUsers()
        {
            return this.usersList;
        }
    }
}
