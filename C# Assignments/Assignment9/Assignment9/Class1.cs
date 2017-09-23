using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    public class Vehicle
    {
        string _make;
        int _yearOfManufacture;
        string _model;
        float _speedOfVehicle;

    public string make
        {
            get
            {
                return this._make;
            }
            set
            {
                this._make = value;
            }
        }
        
    public string model
        {
            get
            {
                return this._model;
            }
            set
            {
                this._model = value;
            }
        }
    public int yearOfManufacture
        {
            get
            {
                return this._yearOfManufacture;
            }
            set
            {
                this._yearOfManufacture = value;
            }
        }
    public float speed
        {
            get
            {
                return this._speedOfVehicle;
            }
            set
            {
                this._speedOfVehicle = value;
            }
        }
        public Vehicle()
        {

        }
    public Vehicle(string m , int y , string o , float s)
        {
            _make = m;
            _yearOfManufacture = y;
            _model = o;
            _speedOfVehicle = s;
        }
    public void Accelerate()
        {
            Console.Write("The vehicle {0} is accelerated from {1}", _make, _speedOfVehicle);
            _speedOfVehicle += 10;
            Console.WriteLine("to {0} \n",_speedOfVehicle);
        }
    public void Deaccelerate()
        {
            Console.Write("The vehicle {0} is deaccelerated from {1}", _make, _speedOfVehicle);
            _speedOfVehicle -= 10;
            Console.WriteLine("to {0} \n", _speedOfVehicle);
        }
    public void Stop()
        {
            _speedOfVehicle = 0;
            Console.WriteLine("{0} gets stopped \n", _make);
        }
    public bool IsMoving()
        {
            if (_speedOfVehicle == 0)
                return false;
            else
                return true;
        }
        public void Display()
        {
            Console.WriteLine("Manufacturer is {0}", _make);
            Console.WriteLine("Year Of Manufacture is {0}", _yearOfManufacture);
            Console.WriteLine("Model is{0}", _model);
            Console.WriteLine("Speed of Vehicle is", _speedOfVehicle);
            Console.WriteLine();
        }
        public virtual void Display1()
        {   

        }

        public void Display2()
        {
            Vehicle v2 = new Bicycle();
            Vehicle v3 = new Bike();
            Vehicle v4 = new Car();
            Vehicle v5 = new Truck();
            int? ch1 = 1;
            while (ch1 != 2)
            {
                Console.WriteLine("please enter your choice");
                Console.WriteLine("1: For Bicycle");
                Console.WriteLine("2: For Bike");
                Console.WriteLine("3: For Car");
                Console.WriteLine("4: For Truck");
                Console.WriteLine("5: To exit");
                ch1 = int.Parse(Console.ReadLine());
                switch (ch1)
                {
                    case 1:
                        v2.Display1();
                        break;
                    case 2:
                        v3.Display1();
                        break;
                    case 3:
                        v4.Display1();
                        break;
                    case 4:
                        v5.Display1();
                        break;
                    case 5:
                        Console.WriteLine("exited");
                        System.Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }

        }
        public static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle();
            v1.Display2();
            

        }

    }
   
}

