using System;
using System.Collections.Generic;
using System.Text;

namespace Lession2_Basics
{
    class StringProgram
    {
        public static void Do()
        {
            string mary = "Mary had a little lamb";
            Console.WriteLine("Original String: " + mary);
            Console.WriteLine("Does string contains little: " + mary.Contains("little"));
            Console.WriteLine("Does string ends wth little: " + mary.EndsWith("little"));
            Console.WriteLine("Does string start wth little: " + mary.StartsWith("little"));

            Console.WriteLine("string in lowercases " + mary.ToLower());
            Console.WriteLine("string in uppercase " + mary.ToUpper());

            string[] maryValues = mary.Split(" ");
            Console.WriteLine("Separated string by space");
            foreach(string value in maryValues)
            {
                Console.WriteLine(value);
            }
        }
    }
}
