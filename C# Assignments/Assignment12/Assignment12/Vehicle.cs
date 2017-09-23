using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class Class1
    {

        public static void Main(string[] args)
        {
            Vehicle[] v = new Vehicle[2];
            Console.WriteLine("Enter 4 types of vehicle and their details\n");
            for (int i = 0; i <= 1; i++)
            {
                v[i] = new Vehicle();
                Console.WriteLine("Enter the type of Vehicle");
                v[i]._typeOfVehicle = Console.ReadLine();
                Console.WriteLine("Enter the Manufacturer");
                v[i]._make = Console.ReadLine();
                Console.WriteLine("Enter the Year of Manufacturing");
                v[i]._yearOfManufacture = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Model of Vehicle");
                v[i]._model = Console.ReadLine();
                Console.WriteLine("Enter the speed of Vehicle");
                v[i]._speedOfVehicle = float.Parse(Console.ReadLine());

            }

            List<Vehicle> VehicleList = new List<Vehicle>(100);
            for (int i = 0; i < 2; i++)
            {
                VehicleList.Add(v[i]);
            }
            int k = v[0].CompareTo(v[1]);
            if (k == 0)
                Console.WriteLine("Both Objects are equal");
            else
                Console.WriteLine("Both objects are not equal");



            VehicleList.Sort();


            foreach (Vehicle ver in VehicleList)
            {
                Console.WriteLine("\n Type of Vehicle is {0} ", ver._typeOfVehicle);
                Console.WriteLine("Manufacture of vehicle is {0}", ver._make);
                Console.WriteLine("Year of Manufacturing is {0}", ver._yearOfManufacture);
                Console.WriteLine("Model is {0}", ver._model);
                Console.WriteLine("Speed of Vehicle is {0}", ver._speedOfVehicle);
            }

            Console.WriteLine("\n--------------");
            Console.WriteLine(v[0].Equals(v[1]));


            Console.ReadLine();
        }
    }
}
