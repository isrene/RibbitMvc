using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using RibbitMvc.Data;
using RibbitMvc.Models;

namespace RibbitMvc.Services
{
    public class UserService : ISecurityService
    {
        private readonly IContext _context;
        private readonly IUserRepository _users;

        public UserService(IContext context)
        {
            _context = context;
            _users = context.Users;
        }

        public User GetBy(int id)
        {
            return _users.GetBy(id);
        }

        public User GetBy(string username)
        {
            return _users.GetBy(username);
        }

        public User Create(string username, string password, UserProfile profile, DateTime? created)
        {
            var user = new User()
            {
                UserName = username,
                Password = Crypto.HashPassword(password),
                DateCreated = created.HasValue ? created.Value : DateTime.Now,
                Profile = profile
            };

            _users.Create(user);
            _context.SaveChanges();

            return user;
        }

       
    }
}