using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public class Student
    {
        public string _name;
        public int _rollNo;
        public int _age;
        public void Display(string n , int r , int a)
        {
            Console.WriteLine("Name : {0}", n);
            Console.WriteLine("Rollno : {0}", r);
            Console.WriteLine("Age : {0}\n", a);
        }
        public static void Main(string[] args)
        {
            SchoolStudent s1 = new SchoolStudent();
            CollegeStudent s2 = new CollegeStudent();
            int _ch;
            do
            {
                Console.WriteLine("Choose your option\n");
                Console.WriteLine("1: to view details of school student");
                Console.WriteLine("2: to view details of college student");
                Console.WriteLine("3: to exit \n");
                _ch = int.Parse(Console.ReadLine());

                switch(_ch)
                {
                    case 1:
                        s1.Register();
                        break;
                    case 2:
                        s2.Register();
                        break;
                    case 3:
                        Console.WriteLine("exited");
                        System.Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            
            } while (_ch > 0);
        }
    }
    public class SchoolStudent : Student
    {
        public void Register()
        {
            _name = "Nilesh";
            _rollNo = 22;
            _age = 15;
            Display(_name,_rollNo,_age);
        }        
    }
    public class CollegeStudent : Student
    {
        public void Register()
        {
            _name = "Shailesh";
            _rollNo = 7439;
            _age = 19;
            Display(_name, _rollNo, _age);
        }

    }
}