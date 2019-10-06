using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Passku.Business.Concrete.MongoDb;
using Passku.Models.Concrete;

namespace Passku.WebCoreApp.Controllers
{
    public class UserController : Controller
    {

        UserManager userManager { get; set; }

        public UserController(UserManager userManager)
        {
            this.userManager = userManager;
        }



        public IActionResult Home()
        {
            return View();
        }



        /* Login Operations */
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            var loginUser = userManager.Login(user);
            if (loginUser != null)
            {
                HttpContext.Session.SetString("SessionUserId", loginUser.Id.ToString());
                HttpContext.Session.SetString("SessionUserUsername", loginUser.Username);
                return RedirectToAction("Home", "User");
            }
            TempData["MsgUserLoginError"] = "You entered the password or username incorrectly";
            return View(loginUser);
        }



        /* Register Operations */
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            var registerUser = userManager.CheckByUsername(user);
            if (registerUser == null)
            {
                registerUser = userManager.CheckByMail(user);
                if (registerUser == null)
                {
                    user.CreatedDate = DateTime.Now.ToShortDateString();
                    userManager.Add(user);
                    TempData["MsgUserRegisterSuccesful"] = "You have successfully registered. You can now log in.";
                    return RedirectToAction("Login");
                }
            }
            TempData["MsgUserRegisterError"] = "The email address or username you entered is being used. Please enter another email address or username.";
            return View();
        }

    }
}