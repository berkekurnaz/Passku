using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using MongoDB.Bson;
using Passku.Business.Concrete.MongoDb;
using Passku.Cryptology;
using Passku.MobileAppApi.Helpers;
using Passku.Models.Concrete;

namespace Passku.MobileAppApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Password")]
    public class PasswordController : Controller
    {

        CheckApiKey checkApiKey;

        ManagerManager managerManager { get; set; }
        StoredPasswordManager passwordManager { get; set; }

        public PasswordController(ManagerManager managerManager, StoredPasswordManager passwordManager)
        {
            this.managerManager = managerManager;
            this.passwordManager = passwordManager;

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

        /******************** Example : www.app.passku.com/api/password ********************/


        [HttpGet("{user}")]
        public async Task<ActionResult> GetAll(string user)
        {
            if (CheckApi())
            {
                // Password Decrypt
                List<StoredPassword> passwords = passwordManager.GetByUserId(user);
                PasswordCryptology passwordCryptology = new PasswordCryptology();
                foreach (var item in passwords)
                {
                    item.Password = passwordCryptology.Decrypt(item.Password);
                }

                return Ok(passwords);
            }
            else
            {
                return Ok("Api Key Error");
            }
        }


        [HttpGet("{user}/{id}")]
        public async Task<ActionResult> GetById(string user, string Id)
        {
            if (CheckApi())
            {
                PasswordCryptology passwordCryptology = new PasswordCryptology();
                StoredPassword storedPassword = passwordManager.GetById(Id);
                storedPassword.Password = passwordCryptology.Decrypt(storedPassword.Password);
                return Ok(storedPassword);
            }
            else
            {
                return Ok("Api Key Error");
            }
        }


        [HttpPost("{user}")]
        public async Task<ActionResult> Post(StoredPassword storedPassword, string user)
        {
            if (CheckApi())
            {
                try
                {
                    PasswordCryptology passwordCryptology = new PasswordCryptology();
                    storedPassword.Password = passwordCryptology.Encrypt(storedPassword.Password);

                    storedPassword.UserId = new ObjectId(user);
                    passwordManager.Add(storedPassword);
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
        public async Task<ActionResult> Put(string Id, StoredPassword storedPassword)
        {
            if (CheckApi())
            {
                try
                {
                    PasswordCryptology passwordCryptology = new PasswordCryptology();
                    storedPassword.Password = passwordCryptology.Encrypt(storedPassword.Password);

                    passwordManager.Update(Id, storedPassword);
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
                    passwordManager.Delete(Id);
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