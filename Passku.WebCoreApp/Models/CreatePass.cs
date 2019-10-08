using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passku.WebCoreApp.Models
{
    public class CreatePass
    {
        public int passwordLength { get; set; }
        public bool isSymbol { get; set; }
        public bool isNumber { get; set; }
        public bool isLowerCase { get; set; }
        public bool isUpperCase { get; set; }
    }
}
