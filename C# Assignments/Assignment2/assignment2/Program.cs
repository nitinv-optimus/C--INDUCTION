using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class TestSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the programming language");
            string language = Console.ReadLine();
            switch (language)
            {
                case "VB":
                    Console.WriteLine("VB.NET: OOP, multithreading and more!");
                    break;
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
