using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passku.ApiApp.Models
{
    public class CreatedPassword
    {

        public string CreatedDate { get; set; }
        public string Password { get; set; }
        public InformationPassword InformationPassword { get; set; }

    }
}
