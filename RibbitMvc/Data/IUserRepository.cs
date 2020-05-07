using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbitMvc.Data
{
   public interface IUserRepository : IRepository<User>
    {
        User GetBy(int id);
        User GetBy(string username);
    }
}
