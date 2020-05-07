using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbitMvc.Data
{
    public interface IRibbitRepository: IRepository<Ribbit>
    {
        Ribbit GetBy(int id);
        IEnumerable<Ribbit> GetFor(User user);
        void AddFor(Ribbit ribbit, User user);
    }
}
