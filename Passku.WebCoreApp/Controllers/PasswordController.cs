using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Passku.Business.Concrete.MongoDb;
using Passku.Cryptology;
using Passku.Models.Concrete;
using Passku.WebCoreApp.Helpers.Auth;

namespace Passku.WebCoreApp.Controllers
{
    public class PasswordController : Controller
    {

        UserManager userManager { get; set; }
        StoredPasswordManager storedPasswordManager { get; set; }

        public PasswordController(UserManager userManager, StoredPasswordManager storedPasswordManager)
        {
            this.userManager = userManager;
            this.storedPasswordManager = storedPasswordManager;
        }



        /* Create New Password */
        [AuthFilter]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(StoredPassword storedPassword)
        {
            var userId = new ObjectId(HttpContext.Session.GetString("SessionUserId").ToString());
            if (storedPassword.Password.Length >= 3 && storedPassword.Title.Length >= 3)
            {
                // Password Encrypt
                PasswordCryptology passwordCryptology = new PasswordCryptology();
                storedPassword.Password = passwordCryptology.Encrypt(storedPassword.Password);

                storedPassword.CreatedDate = DateTime.Now.ToShortDateString();
                storedPassword.UserId = userId;
                storedPasswordManager.Add(storedPassword);
                TempData["MsgPasswordAddSuccessful"] = "Your password has been successfully saved in the system.";
                return RedirectToAction("Passwords", "User");
            }
            return View(storedPassword);
        }



        /* Read Password By Id */
        [AuthFilter]
        public IActionResult Detail(string id)
        {
            var userId = new ObjectId(HttpContext.Session.GetString("SessionUserId").ToString());
            var password = storedPasswordManager.GetById(id);
            if (password == null)
            {
                return RedirectToAction("Error", "User");
            }
            if (password.UserId != userId)
            {
                return RedirectToAction("Error", "User");
            }

            // Password Decrypt
            PasswordCryptology passwordCryptology = new PasswordCryptology();
            password.Password = passwordCryptology.Decrypt(password.Password);

            return View(password);
        }



        /* Edit Password By Id */
        [AuthFilter]
        public IActionResult Edit(string id)
        {
            var userId = new ObjectId(HttpContext.Session.GetString("SessionUserId").ToString());
            var password = storedPasswordManager.GetById(id);
            if (password == null)
            {
                return RedirectToAction("Error", "User");
            }
            if (password.UserId != userId)
            {
                return RedirectToAction("Error", "User");
            }

            // Password Decrypt
            PasswordCryptology passwordCryptology = new PasswordCryptology();
            password.Password = passwordCryptology.Decrypt(password.Password);

            return View(password);
        }
        [HttpPost]
        public IActionResult Edit(string id, StoredPassword storedPassword)
        {
            var item = storedPasswordManager.GetById(id);
            if (storedPassword.Password.Length >= 3 && storedPassword.Title.Length >= 3)
            {
                // Password Encrypt
                PasswordCryptology passwordCryptology = new PasswordCryptology();

                item.Title = storedPassword.Title;
                item.Password = passwordCryptology.Encrypt(storedPassword.Password);
                item.Content = storedPassword.Content;
                item.Url = storedPassword.Url;
                storedPasswordManager.Update(id, item);
                TempData["MsgPasswordEditSuccessful"] = "Your password has been successfully edited in the system.";
                return RedirectToAction("Passwords", "User");
            }
            return View(storedPassword);
        }



        /* Delete Password By Id */
        [AuthFilter]
        public IActionResult Delete(string id)
        {
            var userId = new ObjectId(HttpContext.Session.GetString("SessionUserId").ToString());
            var password = storedPasswordManager.GetById(id);
            if (password == null)
            {
                return RedirectToAction("Error", "User");
            }
            if (password.UserId != userId)
            {
                return RedirectToAction("Error", "User");
            }

            // Password Decrypt
            PasswordCryptology passwordCryptology = new PasswordCryptology();
            password.Password = passwordCryptology.Decrypt(password.Password);

            return View(password);
        }
        [HttpPost]
        public IActionResult Delete(string id, IFormCollection collection)
        {
            var userId = new ObjectId(HttpContext.Session.GetString("SessionUserId").ToString());
            var password = storedPasswordManager.GetById(id);
            if (password == null)
            {
                return RedirectToAction("Error", "User");
            }
            if (password.UserId != userId)
            {
                return RedirectToAction("Error", "User");
            }
            storedPasswordManager.Delete(id);
            TempData["MsgPasswordDeleteSuccessful"] = "Your password has been successfully deleted in the system.";
            return RedirectToAction("Passwords","User");
        }


    }
}