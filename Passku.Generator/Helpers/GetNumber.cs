using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Generator.Helpers
{
    class GetNumber
    {

        public GetNumber()
        {

        }

        public string Create(int number)
        {
            string myNumber = "";
            switch (number)
            {
                case 1: myNumber = "0"; break;
                case 2: myNumber = "1"; break;
                case 3: myNumber = "2"; break;
                case 4: myNumber = "3"; break;
                case 5: myNumber = "4"; break;
                case 6: myNumber = "5"; break;
                case 7: myNumber = "6"; break;
                case 8: myNumber = "7"; break;
                case 9: myNumber = "8"; break;
                case 10: myNumber = "9"; break;
                default: myNumber = "0"; break;
            }
            return myNumber;
        }

    }
}
