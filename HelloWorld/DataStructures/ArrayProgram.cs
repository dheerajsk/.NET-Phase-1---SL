using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class ArrayProgram
    {
        public static void Do()
        {
            string[] students;

            students = new string[3] { "Student1", "Student2", "Student3" };

            int[] marks = new int[3];
            marks[0] = 20;
            marks[1] = 30;
            marks[2] = 40;

            Console.WriteLine("Students and their marks");
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("Name: " + students[i] + " | Marks: " + marks[i]);
            }

        }
    }
}
