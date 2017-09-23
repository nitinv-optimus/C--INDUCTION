using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    class Vehicle : IComparable<Vehicle>,IEquatable<Vehicle>
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public int CompareTo(Vehicle other)
        {
            return this.Speed.CompareTo(other.Speed);
        }

        public bool Equals(Vehicle other)
        {
            return Name == other.Name && Speed == other.Speed;
        }
        static void Main(string[] args)
        {
           
            Vehicle Car = new Vehicle();
            Vehicle Truck = new Vehicle();
            
            Car.Name = "i20";
            Car.Speed = 97;
            Truck.Name = "Ashok leyland";
            Truck.Speed = 67;

            List<Vehicle> VehicleList = new List<Vehicle>();
            
            VehicleList.Add(Car);
            VehicleList.Add(Truck);

           
            Console.WriteLine("After Sorting->");
            VehicleList.Sort();
            foreach (Vehicle v in VehicleList)
                Console.WriteLine("Vehicle is: {0} , Speed : {1} ", v.Name, v.Speed);

            if (Car.Equals(Truck) == false)
                Console.WriteLine("Vehicles are not equal ");
            else
                Console.WriteLine("Vehicles are equal");

            Console.Read();

            Console.ReadLine();

        }
    }
}
