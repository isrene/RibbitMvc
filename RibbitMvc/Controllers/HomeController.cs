using RibbitMvc.ViewModel;
using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RibbitMvc.Controllers
{
    public class HomeController : RibbitControllerBase
    {

        public HomeController(): base() { }

        public ActionResult Index()
        {
            if (!Security.IsAuthenticated)
            {
                return View("Landing", new SignupViewModel());
            }

            throw new NotImplementedException();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Follow(string username)
        {
            throw new NotImplementedException(username + " followed");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Unfollow(string username)
        {
            throw new NotImplementedException(username + " unfollowed");
        }

        public ActionResult Profiles()
        {
            var users = Users.All(true);
            return View(users);
        }

        public ActionResult Followers()
        {
            if (!Security.IsAuthenticated)
            {
                return RedirectToAction("Index");
            }

            var user = Users.GetAllFor(Security.UserId);

            return View("Buddies", new BuddiesViewModel
            {
                User = user,
                Buddies = user.Followers
            });

        }

        public ActionResult Followings()
        {
            if (!Security.IsAuthenticated)
            {
                return RedirectToAction("Index");
            }

            var user = Users.GetAllFor(Security.UserId);

            return View("Buddies", new BuddiesViewModel
            {
                User = user,
                Buddies = user.Followings
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create()
        {
            throw new NotImplementedException();
        }

    }
}