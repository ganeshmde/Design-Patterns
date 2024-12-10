namespace DesignPatterns.Patterns.Behavioural.Observer
{
    internal class ComputerDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"ComputerDisplay: Temperature updated to {temperature}°C");
        }
    }
}