using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace assignment4
{
    class TestStrings
    {
        static void Main(string[] args)
        {
            string _s1 = "Nitin";
            string _s2 = "Vashisth";

            _s1 += _s2; // Concatenates two strings
            Console.WriteLine(_s1);

            string _columns = "Column 1\tColumn 2\tColumn 3";
            string _rows = "Row 1\r\nRow 2\r\nRow 3";

            string _text = @"nitin       
                           vashisth
                              (optimus information)"; //verbatin literal

            Console.WriteLine(_columns);
            Console.WriteLine(_rows);
            Console.WriteLine(_text);

            System.Console.WriteLine("Enter a number");
            string _input = System.Console.ReadLine();

            // Convert the input string to an int. 
            int j;
            System.Int32.TryParse(_input, out j);

            
            string _s;
            for (int i = 0; i < 10; i++)
            {
                // A simple format string with no alignment formatting.
                _s = System.String.Format("{0} times {1} = {2}", i, j, (i * j));
                System.Console.WriteLine(_s);
            }

            //substring
            string _s3 = "Visual C# Express"; 
            System.Console.WriteLine(_s3.Substring(7, 2));
            System.Console.WriteLine(_s3.Replace("C#", "Basic")); //Replace

            //accessing individual characters in a string, reversing it

            string _s5 = "nitin vashisth";
            int len = _s5.Length;
            for(int i =0;i<len;i++)
            {
                Console.Write(_s5[len - i - 1]);
            }
            Console.WriteLine();
            string _s6 = "HeLLo World";
            System.Text.StringBuilder _sb = new System.Text.StringBuilder(_s6);

            char[] c = new char[_s6.Length];
            c = _s6.ToCharArray();
            Console.WriteLine(c);
            for (int i = 0; i < _s6.Length ; i++)
            {
                if (Char.IsLower(c[i]) == true)
                {
                    c[i] = Char.ToUpper(c[i]);
                }
            }
            for (int i = 0;i<_sb.Length;i++)
            {
                if(Char.IsLower(_sb[i])==true)
                {
                    _sb[i] = Char.ToUpper(_sb[i]);
                }
            }
            string _s7 = "";
            _s6 = _sb.ToString();
            _s7 = new string(c);
                Console.WriteLine(_s6);
            Console.WriteLine(_s7);

            //modify the strings

            string _a = "the have a great fun , the";
            _a = _a.Replace("fun", "day");
            string _a1 = "the";
            string _a2 = "today";
            _a = Regex.Replace(_a, _a1, _a2, RegexOptions.IgnoreCase);
            Console.WriteLine(_a);

            // remove the substring
            string temp = "have";
            int k = _a.IndexOf(temp);
            if (k >= 0)
            {
                _a = _a.Remove(k, temp.Length);
            }
            Console.WriteLine(_a);

            //remove leading and trailing whitespaces
            string a3 = "    I'm wider than I need to be.      ";
            Console.WriteLine(a3);
            a3 = a3.Trim();
            Console.WriteLine(a3);

            string b = "My name is nitin vashisth";
            string b1 = "My name is nitin";
            bool b2 = b.Equals(b1, StringComparison.Ordinal);
            Console.WriteLine("the two strings {0} and {1} are {2} ", b, b1, b2); 

            Console.ReadLine();

        }
    }
}
