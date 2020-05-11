using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbitMvc.Services
{
    public interface ISecurityService
    {
        bool Authenticate(string username, string password);
        User CreateUser(string username, string password, bool login);
        bool DoesUserExists(string username);
        User GetCurrentUser();
        bool IsAuthenticated { get; }
        void Login(User user);
        void Login(string username);
        void Logout();
        int UserId { get; set; }
    }
}
