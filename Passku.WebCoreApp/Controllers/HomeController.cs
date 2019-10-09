using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Passku.Business.Concrete.MongoDb;
using Passku.Generator;
using Passku.Models.Concrete;
using Passku.WebCoreApp.Models;

namespace Passku.WebCoreApp.Controllers
{
    public class HomeController : Controller
    {

        UserManager userManager { get; set; }
        ContactManager contactManager { get; set; }

        public HomeController(UserManager userManager, ContactManager contactManager)
        {
            this.userManager = userManager;
            this.contactManager = contactManager;
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreatePass createPass)
        {
            Generate generate = new Generate();
            string pass = generate.CreatePassword(passwordLength: createPass.passwordLength, isSymbol: createPass.isSymbol, isNumber: createPass.isNumber, isLowerCase: createPass.isLowerCase, isUpperCase: createPass.isUpperCase);
            ViewBag.MsgPassword = pass;
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Source()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if (contact.FirstName.Length > 1 && contact.LastName.Length > 1 && contact.Email.Length > 1 && contact.Subject.Length > 3 && contact.Message.Length > 3)
            {
                contact.Date = DateTime.Now.ToShortDateString();
                contactManager.Add(contact);
                TempData["MsgContactMessage"] = "Your message was sent successfully";
                return RedirectToAction("Contact");
            }
            TempData["MsgContactMessage"] = "Please fill in all fields";
            return View(contact);
        }


    }
}