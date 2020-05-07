using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RibbitMvc.Data
{
    public class UserRepository : EfRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context, bool sharedContext): base(context, sharedContext)
        {

        }

        public User GetBy(int id)
        {
            return Find(u => u.UserId == id);
        }

        public User GetBy(string username)
        {
            return Find(u => u.UserName == username);
        }
    }
}