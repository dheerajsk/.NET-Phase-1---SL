using System;
using System.Collections.Generic;
using System.Text;

namespace Lession2_Basics
{
    class DateProgram
    {
        public static void Do()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Current date and time is : " + dt.ToString());

            Console.WriteLine("Short date and time is : " + dt.ToShortDateString());
            Console.WriteLine("Long date and time is : " + dt.ToLongDateString());

            DateTime FiveyearsFuture = dt.AddYears(5);
            Console.WriteLine("5 years from now: " + FiveyearsFuture.ToShortDateString());
            DateTime FiveyearsBefore = dt.AddYears(-5);
            Console.WriteLine("5 years before: " + FiveyearsBefore.ToShortDateString());

            Console.WriteLine("Custom Formats for date strings");
            Console.WriteLine(dt.ToString("d"));
            Console.WriteLine(dt.ToString("D"));
            Console.WriteLine(dt.ToString("y"));
        }
    }
}
