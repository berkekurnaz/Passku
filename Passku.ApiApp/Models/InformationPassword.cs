using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passku.ApiApp.Models
{
    public class InformationPassword
    {

        public int? length { get; set; }
        public bool? symbol { get; set; }
        public bool? number { get; set; }
        public bool? lowercase { get; set; }
        public bool? uppercase { get; set; }

    }
}
