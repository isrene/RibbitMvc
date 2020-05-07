using System;
using RibbitMvc.Models;

namespace RibbitMvc.Services
{
    public interface IRibbitService
    {
        Ribbit Create(User user, string status, DateTime? created = null);
        Ribbit GetBy(int id);
    }
}