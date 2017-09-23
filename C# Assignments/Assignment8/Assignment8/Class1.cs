using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public enum studentattributes
    {
        StudentEnrolmentNo,
        Name,
        Address,
        DoB,
        Age
    }
    class Student
    {
        private int StudentEnrolmentNo;
        private string Name;
        private string Address;
        private int Age;
        private string DoB;

        public int enrolmentno
        {
            get
            {
                return this.StudentEnrolmentNo;
            }
            set
            {
                this.StudentEnrolmentNo = value;
            }
        }
        public string name
        {
            get
            {
                return this.Name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null");
                }
                this.Name = value;
            }
        } 
        public string address
        {
            get
            {
                return this.Address;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Address cannot be null");
                }
                this.Address = value;
            }
        }
        public string dob
        {
            get
            {
                return this.Address;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Dob cannot be null");
                }

                this.DoB = value;
            }
        }
        public int age
        {
            get
            {
                return this.Age;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Age must be greater then zero ");
                }
                else
                {
                    this.Age = value;
                }
            }
        }

        public Student()
        {
            Random rnd = new Random();
            enrolmentno = rnd.Next(50);
            Console.WriteLine("Enter Your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your address");
            address = Console.ReadLine();
            Console.WriteLine("Enter you date of birth");
            dob = Console.ReadLine();
            Console.WriteLine("Enter Your Age");
            age = int.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Welcome!!!");
            Console.WriteLine("Regn No. is {0}", StudentEnrolmentNo);
            Console.WriteLine("Name is {0}", Name);
            Console.WriteLine("Address is {0}", Address);
            Console.WriteLine("Date of Birth is {0}", DoB);
            Console.WriteLine("Age is {0}", Age);
        }

        public void display(studentattributes choice)
        {
            switch(choice)
            {
                case studentattributes.StudentEnrolmentNo:
                    Console.WriteLine(StudentEnrolmentNo);
                    Console.WriteLine("Your Enrolment is{0}",StudentEnrolmentNo);
                    break;
                case studentattributes.Name:
                    Console.WriteLine("Your name is {0}",Name);
                    break;
                case studentattributes.Address:
                    Console.WriteLine("Your address is {0}", Address);
                    break;
                case studentattributes.DoB:
                    Console.WriteLine("Your Date of Birth is {0}", DoB);
                    break;
                case studentattributes.Age:
                    Console.WriteLine("Your age is {0}", Age);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

        }
    }


