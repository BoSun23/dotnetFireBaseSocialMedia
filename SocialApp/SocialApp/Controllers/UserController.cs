using Microsoft.AspNetCore.Mvc;
using SocialApp.Models;

namespace SocialApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(User user)
        {
            return View(user);
        }

        public IActionResult CreateProfile(User user)
        {
            return View(user);
        }

        public IActionResult myProfile(User user)
        {
            return View(user);
        }
    }
}
