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
    [Route("api/User")]
    public class UserController : Controller
    {

        CheckApiKey checkApiKey;

        ManagerManager managerManager { get; set; }
        UserManager userManager { get; set; }

        public UserController(ManagerManager managerManager, UserManager userManager)
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

        /******************** Example : www.app.passku.com/api/user ********************/

        
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (CheckApi())
            {
                List<User> users = userManager.GetAll();
                return Ok(users);
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
                return Ok(userManager.GetById(Id));
            }
            else
            {
                return Ok("Api Key Error");
            }
        }


        [HttpPost]
        public async Task<ActionResult> Post(User user)
        {
            if (CheckApi())
            {
                try
                {
                    userManager.Add(user);
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


        [HttpPost("{loginUsername}/{loginPassword}")]
        public async Task<ActionResult> Login(string loginUsername, string loginPassword)
        {
            if (CheckApi())
            {
                User user = new User();
                user.Username = loginUsername;
                user.Password = loginPassword;
                try
                {
                    User loginUser = userManager.Login(user);
                    if (loginUser != null)
                    {
                        return Ok("Login Success");
                    }
                    else
                    {
                        return Ok("Login Error");
                    }
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
        public async Task<ActionResult> Put(string Id, User user)
        {
            if (CheckApi())
            {
                try
                {
                    userManager.Update(Id, user);
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
                    userManager.Delete(Id);
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