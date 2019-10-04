using Passku.Generator.Abstract;
using Passku.Generator.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Generator
{
    public class Generate : IGenerate
    {

        GetWord getWord = new GetWord();
        GetNumber getNumber = new GetNumber();
        GetSymbol getSymbol = new GetSymbol();

        public Generate()
        {

        }

        public String CreatePassword(int? passwordLength=15, bool? isSymbol=false, bool? isNumber=false, bool? isUpperCase=false)
        {
            string myPassword = "";

            int numberWord = 0;
            int numberNumber = 0;
            int numberSymbol = 0;

            int numberRandom1 = 0;
            int numberRandom2 = 0;

            Random random = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                /* Upper Case Control */
                if (isUpperCase == true)
                {
                    numberWord = random.Next(44);
                }
                else
                {
                    numberWord = random.Next(23);
                }

                numberNumber = random.Next(11);
                numberSymbol = random.Next(11);

                numberRandom1 = random.Next(6);
                numberRandom2 = random.Next(6);

                string word = getWord.Create(numberWord);
                string number = getNumber.Create(numberWord);
                string symbol = getSymbol.Create(numberWord);

                if (isSymbol == true && numberRandom1 == 1)
                {
                    myPassword = myPassword + symbol;
                }

                if (isNumber == true && numberRandom2 == 1)
                {
                    myPassword = myPassword + number;
                }

                myPassword = myPassword + word;
            }

            return myPassword;
        }



    }
}
