using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Passku.Business.Concrete.MongoDb;
using Passku.Generator;
using Passku.WebCoreApp.Models;

namespace Passku.WebCoreApp.Controllers
{
    public class HomeController : Controller
    {

        UserManager userManager { get; set; }

        public HomeController(UserManager userManager)
        {
            this.userManager = userManager;
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
        public IActionResult Contact(string msg)
        {
            // BURADA CONTACT
            return View();
        }


    }
}