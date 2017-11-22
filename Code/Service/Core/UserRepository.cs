using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;

namespace Core
{
    class UserRepository: IUserRepository
    {
        List<User> usersList = new List<User>();

        private static IUserRepository instance;
        public static IUserRepository Instance {
            get {
                if (instance == null) { instance = new UserRepository(); }
                return instance;
            }
        }

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
            foreach(User item in usersList)
            {
                if(item.Equals(user))
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
            foreach(User item in usersList)
            {
                if(username.Equals(item.Username))
                {
                    result = item;
                }
            }
            if(result==null)
            {
                throw new NullReferenceException();
            }
            return result;
        }
    }
}
