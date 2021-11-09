using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Testif
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the programming language\n");
            string _language = Console.ReadLine();
            if(string.Compare(_language,"VB") == 0)
                Console.WriteLine("VB.NET: OOP, multithreading and more!");
            else if(string.Compare(_language, "C#") == 0)
                Console.WriteLine("Good choice, C# is a fine language.");
            else
                Console.WriteLine("Well...good luck with that!");

            Console.ReadLine();
        }
    }
}
