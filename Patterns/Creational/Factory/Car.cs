namespace DesignPatterns.Patterns.Creational.Factory
{
    internal class Car : IVehicle
    {
        public int Wheels { get => 4; }

        public void drive()
        {
            Console.WriteLine($"Driving car with {Wheels} wheels");
        }
    }
}