using RibbitMvc.Data;
using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RibbitMvc.Services
{
    public class RibbitService : IRibbitService
    {
        private readonly IContext _context;

        private IRibbitRepository _ribbits;

        public RibbitService(IContext context)
        {
            _context = context;
            _ribbits = context.Ribbits;
        }

        public Ribbit GetBy(int id)
        {
            return _ribbits.GetBy(id);
        }

        public Ribbit Create(User user, string status, DateTime? created = null)
        {
            return Create(user.UserId, status, created);
        }

        public Ribbit Create(int userId, string status, DateTime? created = null)
        {
            var ribbit = new Ribbit()
            {
                AuthorId = userId,
                Status = status,
                DateCreated = created.HasValue ? created.Value : DateTime.Now
            };

            _ribbits.Create(ribbit);

            _context.SaveChanges();

            return ribbit;
        }

        public IEnumerable<Ribbit> GetTimelineFor(int userId)//GetTimelineFor
        {
            return _ribbits.FindAll(r => r.Author.Followers.Any(f => f.UserId == userId) || r.AuthorId == userId)
                .OrderByDescending(r => r.DateCreated);
        }

       
    }
}