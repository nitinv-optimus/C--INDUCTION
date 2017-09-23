using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    public class Vehicle : IComparable<Vehicle>
    {
        public string _typeOfVehicle;
        public string _make;
        public int _yearOfManufacture ;
        public string _model ;
        public float _speedOfVehicle;

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


        public int CompareTo(Vehicle other)
        {
            return this._typeOfVehicle.CompareTo(other._typeOfVehicle);
        }

        public override bool Equals(object obj)
        {
            if ((this._yearOfManufacture == ((Vehicle)obj)._yearOfManufacture) && (this._make == ((Vehicle)obj)._make))
                return true;
            else
                return false;
        }

        

    }

}

