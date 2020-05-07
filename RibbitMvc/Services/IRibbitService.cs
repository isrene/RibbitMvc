using System;
using RibbitMvc.Models;

namespace RibbitMvc.Services
{
    public interface IRibbitService
    {
        Ribbit Create(User user, string status, DateTime? created);
        Ribbit GetBy(int id);
    }
}