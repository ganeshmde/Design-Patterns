using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Factory
{
    internal class VehicleFactory
    {
        public IVehicle getVehicleInstance(string vehicleType)
        {
            if (vehicleType == "Car")
            {
                return new Car();
            }
            else if (vehicleType == "Bike")
            {
                return new Bike();
            }

            return null;
        }
    }
}