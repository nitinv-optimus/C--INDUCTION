using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            int i;
            do
            {
                Console.WriteLine("Please Enter Your Choice");
                Console.WriteLine("1 : To display all the details of the student");
                Console.WriteLine("2 : To display enrolmentno");
                Console.WriteLine("3 : To display name");
                Console.WriteLine("4 : To display address");
                Console.WriteLine("5 : To display Date Of Birth");
                Console.WriteLine("6 : To display Age");
                Console.WriteLine("7 : To exit");

                i = int.Parse(Console.ReadLine());

                switch(i)
                {
                    case 1:
                        s1.display();
                        break;
                    case 2:
                        s1.display(studentattributes.StudentEnrolmentNo);
                        break;
                    case 3:
                        s1.display(studentattributes.Name);
                        
                        break;
                    case 4:
                        s1.display(studentattributes.Address);
                        break;
                    case 5:
                        s1.display(studentattributes.DoB);
                        break;
                    case 6:
                        s1.display(studentattributes.Age);
                        break;
                    case 7:
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (i>0);
            
            Console.ReadLine();
        }
    }
}
