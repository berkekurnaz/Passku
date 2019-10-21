using Microsoft.AspNetCore.Mvc;
using Passku.Business.Concrete.MongoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passku.MobileAppApi.Helpers
{
    public class CheckApiKey
    {

        ManagerManager managerManager { get; set; }

        public CheckApiKey(ManagerManager managerManager)
        {
            this.managerManager = managerManager;
        }

        public bool Check(string apikey)
        {
            bool state = false;

            var manager = managerManager.CheckByApikey(apikey);
            
            if (manager != null)
            {
                state = true;
            }

            return state;
        }

    }
}
