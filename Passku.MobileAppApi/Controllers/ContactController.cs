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
    [Route("api/Contact")]
    public class ContactController : Controller
    {

        CheckApiKey checkApiKey;

        ManagerManager managerManager { get; set; }
        ContactManager contactManager { get; set; }

        public ContactController(ManagerManager managerManager, ContactManager contactManager)
        {
            this.managerManager = managerManager;
            this.contactManager = contactManager;

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

        /******************** Example : www.app.passku.com/api/user ********************/


        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (CheckApi())
            {
                return Ok(contactManager.GetAll());
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
                return Ok(contactManager.GetById(Id));
            }
            else
            {
                return Ok("Api Key Error");
            }
        }


        [HttpPost]
        public async Task<ActionResult> Post(Contact contact)
        {
            if (CheckApi())
            {
                try
                {
                    contactManager.Add(contact);
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
        public async Task<ActionResult> Put(string Id, Contact contact)
        {
            if (CheckApi())
            {
                try
                {
                    contactManager.Update(Id, contact);
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
                    contactManager.Delete(Id);
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