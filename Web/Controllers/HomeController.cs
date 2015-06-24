using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Register()
        {
            ViewBag.Message = "Select your username and channel to join the chats";

            return View();
        }

        public IActionResult Chat(string user, string channel)
        {
            ViewBag.Message = user + " joined channel '" + channel + "'";
            ViewBag.Username = user;
            ViewBag.Channel = channel;

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
