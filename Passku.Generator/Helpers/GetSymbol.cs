using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Generator.Helpers
{
    class GetSymbol
    {

        public GetSymbol()
        {

        }

        public string Create(int number)
        {
            string mySymbol = "";
            switch (number)
            {
                case 1: mySymbol = "@"; break;
                case 2: mySymbol = "#"; break;
                case 3: mySymbol = "!"; break;
                case 4: mySymbol = "?"; break;
                case 5: mySymbol = "="; break;
                case 6: mySymbol = "&"; break;
                case 7: mySymbol = "%"; break;
                case 8: mySymbol = "$"; break;
                case 9: mySymbol = "*"; break;
                case 10: mySymbol = "|"; break;
                default: mySymbol = "@"; break;
            }
            return mySymbol;
        }

    }
}
