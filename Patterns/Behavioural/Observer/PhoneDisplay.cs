namespace DesignPatterns.Patterns.Behavioural.Observer
{
    internal class PhoneDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"PhoneDisplay: Temperature updated to {temperature}°C");
        }
    }
}