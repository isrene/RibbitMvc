using RibbitMvc.Models;
using RibbitMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbitMvc.Services
{
    public interface IUserProfileService
    {
        UserProfile GetBy(int id);
        void Update(EditProfileViewModel model);
    }
}
