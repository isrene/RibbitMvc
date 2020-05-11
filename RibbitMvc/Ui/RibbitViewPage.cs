using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RibbitMvc.Models;
using RibbitMvc.Data;
using RibbitMvc.Services;

namespace RibbitMvc.Ui
{
    public abstract class RibbitViewPage : WebViewPage
    {
        protected IContext DataContext;
        public User CurrentUser { get; private set; }
        public IUserService Users { get; set; }
        public ISecurityService Security { get; set; }

        public RibbitViewPage()
        {
            DataContext = new Context();
            Users = new UserService(DataContext);
            Security = new SecurityService(Users);
            CurrentUser = Security.GetCurrentUser();

        }
    }

    public abstract class RibbitViewPage<TModel> : WebViewPage<TModel>
    {
        protected IContext DataContext;
        public User CurrentUser { get; private set; }
        public IUserService Users { get; set; }
        public ISecurityService Security { get; set; }

        public RibbitViewPage()
        {
            DataContext = new Context();
            Users = new UserService(DataContext);
            Security = new SecurityService(Users);
            CurrentUser = Security.GetCurrentUser();

        }
    }
}