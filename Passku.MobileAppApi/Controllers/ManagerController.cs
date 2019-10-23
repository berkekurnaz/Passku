using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Passku.Business.Concrete.MongoDb;
using Passku.MobileAppApi.Helpers;
using Passku.Models.Concrete;

namespace Passku.MobileAppApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Manager")]
    public class ManagerController : Controller
    {

        CheckApiKey checkApiKey;

        ManagerManager managerManager { get; set; }
        UserManager userManager { get; set; }

        public ManagerController(ManagerManager managerManager, UserManager userManager)
        {
            this.managerManager = managerManager;
            this.userManager = userManager;

            checkApiKey = new CheckApiKey(managerManager);
        }

        bool CheckApi()
        {
            StringValues value1;
            Request.Headers.TryGetValue("apikey", out value1);
            if (checkApiKey.Check(value1.FirstOrDefault()))
            {
                return true;
            }
            return false;
        }

        /******************** Example : www.app.passku.com/api/manager ********************/

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (CheckApi())
            {
                return Ok(managerManager.GetAll());
            }
            else
            {
                return Ok("Api Key Error");
            }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(string Id)
        {
            if (CheckApi())
            {
                return Ok(managerManager.GetById(Id));
            }
            else
            {
                return Ok("Api Key Error");
            }
        }


        [HttpPost]
        public async Task<ActionResult> Post(Manager manager)
        {
            if (CheckApi())
            {
                try
                {
                    managerManager.Add(manager);
                    return Ok("Added");
                }
                catch
                {
                    return Ok("Error");
                }
            }
            else
            {
                return Ok("Api Key Error");
            }
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string Id, Manager manager)
        {
            if (CheckApi())
            {
                try
                {
                    managerManager.Update(Id, manager);
                    return Ok("Updated");
                }
                catch
                {
                    return Ok("Error");
                }
            }
            else
            {
                return Ok("Api Key Error");
            }
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string Id)
        {
            if (CheckApi())
            {
                try
                {
                    managerManager.Delete(Id);
                    return Ok("Deleted");
                }
                catch
                {
                    return Ok("Error");
                }
            }
            else
            {
                return Ok("Api Key Error");
            }
        }


    }
}