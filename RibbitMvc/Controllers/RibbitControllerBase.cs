using RibbitMvc.Data;
using RibbitMvc.Models;
using RibbitMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RibbitMvc.Controllers
{
    public class RibbitControllerBase : Controller
    {
        protected IContext DataContext;
        public User CurrentUser { get; set; }
        public IUserService Users { get; private set; }
        public ISecurityService Security { get; set; }

        public RibbitControllerBase()
        {
            DataContext = new Context();
            Users = new UserService(DataContext);
            Security = new SecurityService(Users);

        }

        protected override void Dispose(bool disposing)
        {
            if (DataContext!=null)
            {
                DataContext.Dispose();
            }

            base.Dispose(disposing);
        }

    }
}