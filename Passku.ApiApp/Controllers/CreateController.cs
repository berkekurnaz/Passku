using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Passku.ApiApp.Models;
using Passku.Generator;

namespace Passku.ApiApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Create")]
    public class CreateController : Controller
    {

        /******************** Example : www.yoursite.com/api/create ********************/
        [HttpGet]
        public async Task<ActionResult> Get(int? length = 15, bool? symbol = false, bool? number = false, bool? lowercase = false, bool? uppercase = false)
        {

            if (length <= 0)
            {
                length = 1;
            }
            if (length >= 100)
            {
                length = 100;
            }

            InformationPassword informationPassword = new InformationPassword();
            informationPassword.length = length;
            informationPassword.symbol = symbol;
            informationPassword.number = number;
            informationPassword.lowercase = lowercase;
            informationPassword.uppercase = uppercase;

            Generate generate = new Generate();

            CreatedPassword createdPassword = new CreatedPassword();
            createdPassword.CreatedDate = DateTime.Now.ToString();
            createdPassword.Password = generate.CreatePassword(length,symbol,number,lowercase,uppercase);
            createdPassword.InformationPassword = informationPassword;

            return Ok(createdPassword);
        }


        /******************** Example : www.yoursite.com/api/create/10 ********************/
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAll(int Id, int? length = 15, bool? symbol = false, bool? number = false, bool? lowercase = false, bool? uppercase = false)
        {
            List<CreatedPassword> createdPasswords = new List<CreatedPassword>();

            if (Id <= 0)
            {
                Id = 1;
            }
            if (Id >= 100)
            {
                Id = 100;
            }

            for (int i = 0; i < Id; i++)
            {
                if (length <= 0)
                {
                    length = 1;
                }
                if (length >= 100)
                {
                    length = 100;
                }

                InformationPassword informationPassword = new InformationPassword();
                informationPassword.length = length;
                informationPassword.symbol = symbol;
                informationPassword.number = number;
                informationPassword.lowercase = lowercase;
                informationPassword.uppercase = uppercase;

                Generate generate = new Generate();

                CreatedPassword createdPassword = new CreatedPassword();
                createdPassword.CreatedDate = DateTime.Now.ToString();
                createdPassword.Password = generate.CreatePassword(length, symbol, number, lowercase, uppercase);
                createdPassword.InformationPassword = informationPassword;

                createdPasswords.Add(createdPassword);
            }

            return Ok(createdPasswords);
        }

    }
}