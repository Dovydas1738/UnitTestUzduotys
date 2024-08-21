using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserServiceTests.Models;

namespace UserServiceTests.Models
{
    public class UserService : IUserService
    {
        public List<User> Users;
        public UserService()
        {
            Users = new List<User>();
        }

        public void Register(string username, string password)
        {
            User newUser = new User(username, password);

            foreach (User u in Users)
            {
                if (username == u.UserName)
                {
                    return;
                }
            }
            Users.Add(newUser);
        }

        public string Login(string username, string password)
        {
            foreach (User u in Users)
            {
                if(u.UserName == username && u.Password == password)
                {
                    return $"Welcome back!";
                }

            }
            return $"User not found";
        }

        public void ChangePassword(string username, string oldPassword, string newPassword)
        {

            foreach (User u in Users)
            {
                if (u.UserName == username && u.Password == oldPassword)
                {
                    u.Password = newPassword;
                    return;
                }

            }
        }
    }

    public interface IUserService
    {
        void Register(string username, string password);
        string Login(string username, string password);
        void ChangePassword(string username, string oldPassword, string newPassword);
    }
}
