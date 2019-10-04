using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Passku.Business.Concrete.MongoDb;

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

    }
}