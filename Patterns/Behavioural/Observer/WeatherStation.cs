namespace DesignPatterns.Patterns.Behavioural.Observer
{
    internal class WeatherStation : IWeatherStation
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private float _temperature;

        // Register an observer
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        // Remove an observer
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        // Notify all observers about state change
        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }

        // Simulates a temperature change
        public void SetTemperature(float temperature)
        {
            _temperature = temperature;
            Console.WriteLine($"WeatherStation: New temperature is {_temperature}°C");
            NotifyObservers();
        }
    }
}