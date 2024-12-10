namespace DesignPatterns.Patterns.Creational.Factory
{
    internal class Bike : IVehicle
    {
        public int Wheels { get => 2; }

        public void drive()
        {
            Console.WriteLine($"Driving bike with {Wheels} wheels");
        }
    }
}