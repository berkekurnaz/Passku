using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Generator.Helpers
{
    class GetWord
    {

        public GetWord()
        {

        }

        public string Create(int number)
        {
            string word = "";
            switch (number)
            {
                case 1: word = "a"; break;
                case 2: word = "b"; break;
                case 3: word = "c"; break;
                case 4: word = "d"; break;
                case 5: word = "e"; break;
                case 6: word = "g"; break;
                case 7: word = "f"; break;
                case 8: word = "h"; break;
                case 9: word = "i"; break;
                case 10: word = "j"; break;
                case 11: word = "k"; break;
                case 12: word = "l"; break;
                case 13: word = "m"; break;
                case 14: word = "n"; break;
                case 15: word = "o"; break;
                case 16: word = "p"; break;
                case 17: word = "r"; break;
                case 18: word = "s"; break;
                case 19: word = "t"; break;
                case 20: word = "u"; break;
                case 21: word = "v"; break;
                case 22: word = "y"; break;
                case 23: word = "z"; break;
                case 24: word = "A"; break;
                case 25: word = "B"; break;
                case 26: word = "C"; break;
                case 27: word = "D"; break;
                case 28: word = "E"; break;
                case 29: word = "G"; break;
                case 30: word = "H"; break;
                case 31: word = "I"; break;
                case 32: word = "J"; break;
                case 33: word = "K"; break;
                case 34: word = "L"; break;
                case 35: word = "M"; break;
                case 36: word = "N"; break;
                case 37: word = "O"; break;
                case 38: word = "P"; break;
                case 39: word = "R"; break;
                case 40: word = "S"; break;
                case 41: word = "T"; break;
                case 42: word = "U"; break;
                case 43: word = "Y"; break;
                case 44: word = "Z"; break;
                default: word = "A"; break;
            }
            return word;
        }

    }
}
