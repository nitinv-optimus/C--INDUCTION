using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    public class Bicycle : Vehicle
    {
        public Bicycle()
        {

        }
        public Bicycle(string m, int y, string o, float s) : base(m, y, o, s)
        {

        }
        public override void Display1()
        {
            Vehicle v1 = new Vehicle();
            int _ch = 1;
            Bicycle b1 = new Bicycle("Hero Cycles", 2013, "HC1507", 5.67F);
            while (_ch != 6)
            {
                Console.WriteLine("Please select from the following options\n");
                Console.WriteLine("1.Accelerate your vehicle");
                Console.WriteLine("2.Deacclerate your vehicle");
                Console.WriteLine("3.Stop your vehicle");
                Console.WriteLine("4.Is your vehicle moving?");
                Console.WriteLine("5.Display all details");
                Console.WriteLine("6.Exit\n");

                Console.WriteLine("Enter your Choice");
                _ch = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (_ch)
                {
                    case 1:
                        b1.Accelerate();
                        break;
                    case 2:
                        b1.Deaccelerate();
                        break;
                    case 3:
                        b1.Stop();
                        break;
                    case 4:
                        {
                            if (b1.IsMoving() == true)
                                Console.WriteLine("Moving\n");
                            else
                                Console.WriteLine("Not Moving\n");
                        }
                        break;
                    case 5:
                        b1.Display();
                        break;
                    case 6:
                        Console.WriteLine("Exited\n");
                        v1.Display2();
                        break;
                    default:
                        Console.WriteLine("Incorrect option");
                        break;
                }

            }

            Console.Read();
        }
        
    }
    public class Bike : Vehicle
    {
        public Bike()
        {

        }
        public Bike(string m, int y, string o, float s) : base(m, y, o, s)
        {

        }
        public override void Display1()
        {
            Vehicle v1 = new Vehicle();
            int _ch = 1;
            Bike b1 = new Bike("Honda", 2013, "CBR 250R Repsol", 30.00F);
            while (_ch != 6)
            {
                Console.WriteLine("Please select from the following options\n");
                Console.WriteLine("1.Accelerate your vehicle");
                Console.WriteLine("2.Deacclerate your vehicle");
                Console.WriteLine("3.Stop your vehicle");
                Console.WriteLine("4.Is your vehicle moving?");
                Console.WriteLine("5.Display all details");
                Console.WriteLine("6.Exit\n");
                Console.WriteLine("Enter your Choice");
                _ch = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (_ch)
                {
                    case 1:
                        b1.Accelerate();
                        break;
                    case 2:
                        b1.Deaccelerate();
                        break;
                    case 3:
                        b1.Stop();
                        break;
                    case 4:
                        {
                            if (b1.IsMoving() == true)
                                Console.WriteLine("Moving\n");
                            else
                                Console.WriteLine("Not Moving\n");
                        }
                        break;
                    case 5:
                        b1.Display();
                        break;
                    case 6:
                        Console.WriteLine("Exited\n");
                        v1.Display2();

                        break;
                    default:
                        Console.WriteLine("Incorrect option\n");
                        break;
                }

            }

            Console.Read();
        }

    }
    public class Car : Vehicle
    {
        public Car()
        {

        }
        public Car(string m, int y, string o, float s) : base(m, y, o, s)
        {

        }
        public override void Display1()
        {
            Vehicle v1 = new Vehicle();
            int _ch = 1;
            Car b1 = new Car("Hyundai", 2016, "i20 sport", 80.00F);
            while (_ch != 6)
            {
                Console.WriteLine("Please select from the following options\n");
                Console.WriteLine("1.Accelerate your vehicle");
                Console.WriteLine("2.Deacclerate your vehicle");
                Console.WriteLine("3.Stop your vehicle");
                Console.WriteLine("4.Is your vehicle moving?");
                Console.WriteLine("5.Display all details");
                Console.WriteLine("6.Exit\n");
                Console.WriteLine("Enter your Choice");
                _ch = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (_ch)
                {
                    case 1:
                        b1.Accelerate();
                        break;
                    case 2:
                        b1.Deaccelerate();
                        break;
                    case 3:
                        b1.Stop();
                        break;
                    case 4:
                        {
                            if (b1.IsMoving() == true)
                                Console.WriteLine("Moving\n");
                            else
                                Console.WriteLine("Not Moving\n");
                        }
                        break;
                    case 5:
                        b1.Display();
                        break;
                    case 6:
                        Console.WriteLine("Exited\n");
                        v1.Display2();

                        break;
                    default:
                        Console.WriteLine("Incorrect option\n");
                        break;
                }

            }

            Console.Read();
        }

    }
    public class Truck : Vehicle
    {
        public Truck()
        {

        }
        public Truck(string m, int y, string o, float s) : base(m, y, o, s)
        {

        }
        public override void Display1()
        {
            Vehicle v1 = new Vehicle();
            int _ch = 1;
            Truck b1 = new Truck("Ashok Leyland", 2015 , "2516 IL", 50.00F);
            while (_ch != 6)
            {
                Console.WriteLine("Please select from the following options\n");
                Console.WriteLine("1.Accelerate your vehicle");
                Console.WriteLine("2.Deacclerate your vehicle");
                Console.WriteLine("3.Stop your vehicle");
                Console.WriteLine("4.Is your vehicle moving?");
                Console.WriteLine("5.Display all details");
                Console.WriteLine("6.Exit\n");
                Console.WriteLine("Enter your Choice");
                _ch = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (_ch)
                {
                    case 1:
                        b1.Accelerate();
                        break;
                    case 2:
                        b1.Deaccelerate();
                        break;
                    case 3:
                        b1.Stop();
                        break;
                    case 4:
                        {
                            if (b1.IsMoving() == true)
                                Console.WriteLine("Moving\n");
                            else
                                Console.WriteLine("Not Moving\n");
                        }
                        break;
                    case 5:
                        b1.Display();
                        break;
                    case 6:
                        Console.WriteLine("Exited\n");
                        v1.Display2();

                        break;
                    default:
                        Console.WriteLine("Incorrect option\n");
                        break;
                }

            }

            Console.Read();
        }

    }
}
