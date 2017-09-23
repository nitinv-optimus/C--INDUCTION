using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionNList2
{
    public class Vehicle
    {
        public string VehicleName;
        public string VehicleModel;

        public override string ToString()
        {
            return this.VehicleName + " " + this.VehicleModel;
        }

    }
    public class TestCollection
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle();
            ArrayList VehicleList = new ArrayList();



            v1.VehicleName = "Bicycle";
            v1.VehicleModel = "HERO101";
            Vehicle v2 = new Vehicle();
            v2.VehicleName = "Bike";
            v2.VehicleModel = "HondaCBshine";
            Vehicle v3 = new Vehicle();
            v3.VehicleName = "Car";
            v3.VehicleModel = "i20 sport";
            Vehicle v4 = new Vehicle();
            v4.VehicleName = "Truck";
            v4.VehicleModel = "AL104";


            VehicleList.Add(v1);
            VehicleList.Add(v2);
            VehicleList.Add(v3);
            VehicleList.Add(v4);


            foreach (var v in VehicleList)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("\n \n using indexes\n \n");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0} {1}", ((Vehicle)VehicleList[i]).VehicleName, ((Vehicle)VehicleList[i]).VehicleModel);
            }

           
            Console.ReadLine();

        }
    }

}



