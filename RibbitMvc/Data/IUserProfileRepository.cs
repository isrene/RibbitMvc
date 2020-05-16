using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbitMvc.Data
{
    public interface IUserProfileRepository: IRepository<UserProfile>
    {
        
    }
}
