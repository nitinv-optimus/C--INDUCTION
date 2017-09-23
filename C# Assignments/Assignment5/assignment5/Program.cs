using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class Program
    {
        string[] _name = new string[2];
        public string[] Array()
        {
            _name[0] = "nitin";
            _name[1] = "vashisth";
            return _name;
        }
      
        static void Main(string[] args)
        {
            Program x = new Program();
            //string[] k = new string[2];
            //k = x.array();

            foreach(var name in x.Array())
            {
                Console.WriteLine(name);
            }
            

            Console.ReadLine();
        }
    }
}
