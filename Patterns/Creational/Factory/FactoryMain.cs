using DesignPatterns.Runner;

namespace DesignPatterns.Patterns.Creational.Factory
{
    internal class FactoryMain : IRunner

    {
        public override void Run()
        {
            PrintStartLine();
            VehicleFactory vehicleFactory = new VehicleFactory();

            //Car
            IVehicle car = vehicleFactory.getVehicleInstance("Car");
            car.drive();

            //Bike
            IVehicle bike = vehicleFactory.getVehicleInstance("Bike");
            bike.drive();

            PrintEndLine();
        }
    }
}