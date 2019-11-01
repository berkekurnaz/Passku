using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Passku.Business.Concrete.MongoDb;
using Passku.Generator;
using Passku.Models.Concrete;
using Passku.WebCoreApp.Helpers.Auth;
using Passku.WebCoreApp.Models;

namespace Passku.WebCoreApp.Controllers
{
    public class UserController : Controller
    {

        UserManager userManager { get; set; }
        StoredPasswordManager storedPasswordManager { get; set; }
        AnnouncementManager announcementManager { get; set; }
        ReportManager reportManager { get; set; }

        public UserController(UserManager userManager, StoredPasswordManager storedPasswordManager, AnnouncementManager announcementManager, ReportManager reportManager)
        {
            this.userManager = userManager;
            this.storedPasswordManager = storedPasswordManager;
            this.announcementManager = announcementManager;
            this.reportManager = reportManager;
        }



        [AuthFilter]
        public IActionResult Home()
        {
            var userId = HttpContext.Session.GetString("SessionUserId").ToString();

            ViewBag.Username = HttpContext.Session.GetString("SessionUserUsername").ToString();

            ViewBag.YourPasswords = storedPasswordManager.GetUserPasswordCount(userId).ToString();
            ViewBag.TotalPasswords = storedPasswordManager.GetTotalPasswordCount().ToString();
            ViewBag.Announcements = announcementManager.GetAnnouncementCount().ToString();
            ViewBag.MemberCount = userManager.GetUserCount().ToString();

            return View();
        }



        /* List Passwords By UserId */
        [AuthFilter]
        public IActionResult Passwords()
        {
            var userId = HttpContext.Session.GetString("SessionUserId").ToString();
            var list = storedPasswordManager.GetByUserId(userId);
            return View(list);
        }

        /*---------------------------------------------------------------------------*/

        /* Create Password Operations */
        [AuthFilter]
        public IActionResult CreatePassword() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePassword(CreatePass createPass)
        {
            Generate generate = new Generate();
            string pass = generate.CreatePassword(passwordLength: createPass.passwordLength, isSymbol: createPass.isSymbol, isNumber: createPass.isNumber, isLowerCase: createPass.isLowerCase, isUpperCase: createPass.isUpperCase);
            ViewBag.MsgPassword = pass;
            return View();
        }



        /*---------------------------------------------------------------------------*/

        /* List Announcements */
        [AuthFilter]
        public IActionResult Announcements()
        {
            var list = announcementManager.GetAll();
            return View(list);
        }

        /* Get Announcement By Announcement Id */
        [AuthFilter]
        public IActionResult AnnouncementDetail(string id)
        {
            var announcement = announcementManager.GetById(id);
            if (announcement == null)
            {
                return RedirectToAction("Error", "User");
            }
            return View(announcement);
        }


        /*---------------------------------------------------------------------------*/

        /* Report Operations */
        [AuthFilter]
        public IActionResult Report()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Report(Report report)
        {
            if (report.Title.Length >= 5 && report.Content.Length >= 10)
            {
                var userId = new ObjectId(HttpContext.Session.GetString("SessionUserId").ToString());
                report.Date = DateTime.Now.ToShortDateString();
                report.UserId = userId;
                TempData["MsgReportMessage"] = "Your report has been sent successfully.";
                return RedirectToAction("Report");
            }
            TempData["MsgReportMessage"] = "Title field must be at least 5 characters and the Content field must be at least 10 characters.";
            return View();
        }



        /*---------------------------------------------------------------------------*/

        /* List Passwords By UserId */
        [AuthFilter]
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

        /* Forget Password Operations */
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ForgetPassword(string mail)
        {
            if (mail.Length > 1)
            {
                // TODO : FORGET PASSWORD OPERATİONS.
                TempData["MsgUserForgetPasswordMessage"] = "Your password has been sent to your email address.";
                return RedirectToAction("ForgetPassword");
            }
            TempData["MsgUserForgetPasswordMessage"] = "Please enter the mail field.";
            return View();
        }

        /* Logout Operations */
        public IActionResult Logout()
        {
            return RedirectToAction("Index","Home");
        }



        /*---------------------------------------------------------------------------*/

        /* Error Page */
        [AuthFilter]
        public IActionResult Error()
        {
            return View();
        }



        /*---------------------------------------------------------------------------*/

        /* About Page */
        [AuthFilter]
        public IActionResult About()
        {
            return View();
        }

        /* Use Page */
        [AuthFilter]
        public IActionResult Use()
        {
            return View();
        }

        /* Source Page */
        [AuthFilter]
        public IActionResult Source()
        {
            return View();
        }


    }
}