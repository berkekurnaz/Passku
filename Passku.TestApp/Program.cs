using Passku.Generator;
using System;

namespace Passku.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Generate generate = new Generate();
            string myPassword = generate.CreatePassword(passwordLength: 15, isSymbol: true, isNumber: true, isUpperCase: false);
            Console.WriteLine(myPassword);
            Console.ReadLine();
        }
    }
}
