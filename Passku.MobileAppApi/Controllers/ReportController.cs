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
    [Route("api/Report")]
    public class ReportController : Controller
    {

        CheckApiKey checkApiKey;

        ManagerManager managerManager { get; set; }
        ReportManager reportManager { get; set; }

        public ReportController(ManagerManager managerManager, ReportManager reportManager)
        {
            this.managerManager = managerManager;
            this.reportManager = reportManager;

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

        /******************** Example : www.app.passku.com/api/report ********************/


        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (CheckApi())
            {
                return Ok(reportManager.GetAll());
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
                return Ok(reportManager.GetById(Id));
            }
            else
            {
                return Ok("Api Key Error");
            }
        }


        [HttpPost]
        public async Task<ActionResult> Post(Report report)
        {
            if (CheckApi())
            {
                try
                {
                    reportManager.Add(report);
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
        public async Task<ActionResult> Put(string Id, Report report)
        {
            if (CheckApi())
            {
                try
                {
                    reportManager.Update(Id, report);
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
                    reportManager.Delete(Id);
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