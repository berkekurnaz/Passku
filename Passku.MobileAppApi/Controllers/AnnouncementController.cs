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
    [Route("api/Announcement")]
    public class AnnouncementController : Controller
    {

        CheckApiKey checkApiKey;

        ManagerManager managerManager { get; set; }
        AnnouncementManager announcementManager { get; set; }


        public AnnouncementController(ManagerManager managerManager, AnnouncementManager announcementManager)
        {
            this.managerManager = managerManager;
            this.announcementManager = announcementManager;

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

        /******************** Example : www.app.passku.com/api/announcement ********************/


        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (CheckApi())
            {
                return Ok(announcementManager.GetAll());
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
                return Ok(announcementManager.GetById(Id));
            }
            else
            {
                return Ok("Api Key Error");
            }
        }


        [HttpPost]
        public async Task<ActionResult> Post(Announcement announcement)
        {
            if (CheckApi())
            {
                try
                {
                    announcementManager.Add(announcement);
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
        public async Task<ActionResult> Put(string Id, Announcement announcement)
        {
            if (CheckApi())
            {
                try
                {
                    announcementManager.Update(Id, announcement);
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
                    announcementManager.Delete(Id);
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