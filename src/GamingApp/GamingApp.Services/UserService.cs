using GamingApp.Data;
using GamingApp.Data.Models;
using GamingApp.Services.Interfaces;
using System;
using System.Linq;

namespace GamingApp.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> repo;

        public UserService(IRepository<User> repo)
        {
            this.repo = repo;
        }

        public User Register(string username, string password)
        {
            if (repo.All().Any(u => u.Username == username))
            {
                return null;
            }

            User newUser = new User()
            {
                Username = username,
                Password = password
            };

            this.repo.Add(newUser);

            this.repo.SaveChanges();

            return newUser;
        }

        public User Login(string username, string password)
        {
            var user = repo.All().FirstOrDefault(u => u.Username == username);

            if (user == null || user.Password != password)
            {
                throw new ArgumentException("Invalid Login Credentials");
            }

            return user;
        }
    }
}
