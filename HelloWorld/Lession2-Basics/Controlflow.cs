using System;
using System.Collections.Generic;
using System.Text;

namespace Lession2_Basics
{
    class Controlflow
    {
        public static void Do() 
        {
            int x = 10;

            Console.WriteLine("While loop");
            while (x < 20)
            {
                Console.WriteLine(x);
                x++;
            }

            Console.WriteLine("For loop");
            for(int y=10; y<20; y++)
            {
                Console.WriteLine(y);
            }

            Console.WriteLine("Do while");

            x = 10;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 20);

            x = 10;
            switch (x)
            {
                case 9:
                    Console.WriteLine("Value from Case 9 :"+x);
                    break;
                case 10:
                    Console.WriteLine("Value from Case 10 : "+ x);
                    break;
            }
        }
    }
}
