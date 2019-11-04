using Mailjet.Client;
using Mailjet.Client.Resources;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passku.WebCoreApp.Helpers.Mail
{
    public class SendMail
    {

        public static async Task RunAsync(string password)
        {
            MailjetClient client = new MailjetClient(Environment.GetEnvironmentVariable("02008799fa0a9245d1e94920c217e61c"), Environment.GetEnvironmentVariable("ef07f08cd0b129deec2675de39e3703a"))
            {
                Version = ApiVersion.V3_1,
            };
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
             .Property(Send.Messages, new JArray {
     new JObject {
      {
       "From",
       new JObject {
        {"Email", "kurnaz.berke1907@gmail.com"},
        {"Name", "Berke"}
       }
      }, {
       "To",
       new JArray {
        new JObject {
         {
          "Email",
          "bkoyunberkekurnaz@hotmail.com"
         }, {
          "Name",
          "Passku"
         }
        }
       }
      }, {
       "Subject",
       "Hello World"
      }, {
       "TextPart",
       "My first Mailjet email"
      }, {
       "HTMLPart",
       "<h3>Dear passenger 1, welcome to <a href='https://www.mailjet.com/'>Mailjet</a>!</h3><br />May the delivery force be with you!"
      }, {
       "CustomID",
       "AppGettingStartedTest"
      }
     }
             });
            MailjetResponse response = await client.PostAsync(request);
            if (response.IsSuccessStatusCode)
            {
                response.GetData();
            }
            else
            {
                response.GetData();
            }
        }
    }

}
