using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{

    enum Weekdays
    {
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Weekdays.sunday);
            Console.WriteLine(Weekdays.monday);
            Console.WriteLine(Weekdays.tuesday);
            Console.WriteLine(Weekdays.wednesday);
            Console.WriteLine(Weekdays.thursday);
            Console.WriteLine(Weekdays.friday);
            Console.WriteLine(Weekdays.saturday);
            Console.ReadLine();
        }
        
    }
}
