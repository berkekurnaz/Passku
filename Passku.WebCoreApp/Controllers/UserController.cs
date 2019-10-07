using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Passku.Business.Concrete.MongoDb;
using Passku.Models.Concrete;

namespace Passku.WebCoreApp.Controllers
{
    public class UserController : Controller
    {

        UserManager userManager { get; set; }
        StoredPasswordManager storedPasswordManager { get; set; }

        public UserController(UserManager userManager, StoredPasswordManager storedPasswordManager)
        {
            this.userManager = userManager;
            this.storedPasswordManager = storedPasswordManager;
        }



        public IActionResult Home()
        {
            return View();
        }

      
    
        /* List Passwords By UserId */
        public IActionResult Passwords()
        {
            var userId = HttpContext.Session.GetString("SessionUserId").ToString();
            var list = storedPasswordManager.GetByUserId(userId);
            return View(list);
        }



        /* List Announcements */
        public IActionResult Announcements()
        {
            // BURAYA DUYURULARI LİSTELE.
            return View();
        }

        /* Get Announcement By Announcement Id */
        public IActionResult AnnouncementDetail(string id)
        {
            // BURADA ID DEGERİNE GORE DUYURU GELECEK.
            return View();
        }



        /*---------------------------------------------------------------------------*/

        /* List Passwords By UserId */
        public IActionResult Profile()
        {
            var userId = HttpContext.Session.GetString("SessionUserId").ToString();
            var user = userManager.GetById(userId);
            return View(user);
        }

        /* Change Password Operations */
        [HttpPost]
        public IActionResult ChangePassword(string oldPassword, string newPassword1, string newPassword2)
        {
            var userId = HttpContext.Session.GetString("SessionUserId").ToString();
            var user = userManager.GetById(userId);
            if (oldPassword.Length >= 2 && newPassword1.Length >= 2 && newPassword2.Length >= 2)
            {
                if (user.Password == oldPassword)
                {
                    if (newPassword1 == newPassword2)
                    {
                        user.Password = newPassword1;
                        userManager.Update(userId, user);
                        TempData["MsgUserChangePasswordSuccesful"] = "Your password has been successfully updated.";
                        return RedirectToAction("Profile");
                    }
                    else
                    {
                        TempData["MsgUserChangePasswordError"] = "The two passwords you typed are not the same.";
                        return RedirectToAction("Profile");
                    }
                }
                TempData["MsgUserChangePasswordError"] = "Please enter the correct password you are currently using";
                return RedirectToAction("Profile");
            }
            TempData["MsgUserChangePasswordError"] = "Please enter the required fields";
            return RedirectToAction("Profile");
        }



        /*---------------------------------------------------------------------------*/

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



        /* Logout Operations */
        public IActionResult Logout()
        {
            return RedirectToAction("Index","Home");
        }

        /*---------------------------------------------------------------------------*/
    }
}