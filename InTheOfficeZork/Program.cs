using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InTheOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, cube slave. What is your name? Not that it matters.");
            Console.Write(">");
            string sResponse = Console.ReadLine();
            Console.WriteLine("You, cube slave, are here for data entry. I know, I know. Your name is {0}. That doesn't matter. Just pay attention to my instructions.", sResponse);
            Console.ReadLine();
        }
    }
}
