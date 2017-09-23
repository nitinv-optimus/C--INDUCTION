using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Area
    {
        public static float _length;
        public static float _breadth;
        public static float _radius;
        public static float _side;

        public void Circle(float r)
        {
            Console.Write("The Area of the Circle is ");
            r = (float)Math.PI * r * r;
            Console.WriteLine("{0}\n",r);
        }
        public void Rectangle(float l , float b)
        {
            Console.Write("The Area of the Rectangle is ");
            l = l * b;
            Console.WriteLine("{0}\n", l);
        }
        public void Square(float s)
        {
            Console.Write("The Area of the Square is ");
            s = s * s;
            Console.WriteLine("{0}\n", s);
        }
        public static void Main(string[] args)
        {
            Area a1 = new Area();
            int _ch;
            do
            {
                Console.WriteLine("Choose your option\n");
                Console.WriteLine("1: To calculate the Area of Circle");
                Console.WriteLine("2: To calculate the Area of Rectangle");
                Console.WriteLine("3: To calculate the Area of Square");
                Console.WriteLine("4: To exit\n");
                _ch = int.Parse(Console.ReadLine());

                switch(_ch)
                {
                    case 1:
                        Console.WriteLine("Enter the Radius of the Circle\n");
                        _radius = float.Parse(Console.ReadLine());
                        Console.WriteLine();
                        a1.Circle(_radius);
                        break;

                    case 2:
                        Console.WriteLine("Enter the Length of the Rectangle\n");
                        _length = float.Parse(Console.ReadLine());
                         Console.WriteLine("Enter the Breadth of the Rectangle\n");
                        _breadth = float.Parse(Console.ReadLine());
                        Console.WriteLine();
                        a1.Rectangle(_length,_breadth);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Side of the Square\n");
                        _side = float.Parse(Console.ReadLine());
                        Console.WriteLine();
                        a1.Square(_side);
                        break;
                    case 4:
                        Console.WriteLine("Exited");
                        System.Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (_ch > 0);
        }
    }
}
