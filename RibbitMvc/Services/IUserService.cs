using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbitMvc.Services
{
    public interface IUserService
    {
        User GetBy(int id);
        User GetBy(string username);
        User Create(string username, string password, UserProfile profile, DateTime? created);
    }
}
