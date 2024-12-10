using DesignPatterns.Runner;

namespace DesignPatterns.Patterns.Behavioural.Observer
{
    internal class ObserverMain : IRunner
    {
        public override void Run()
        {
            PrintStartLine();
            // Create WeatherStation (Subject)
            WeatherStation weatherStation = new WeatherStation();

            // Create Observers
            IObserver phoneDisplay = new PhoneDisplay();
            IObserver computerDisplay = new ComputerDisplay();

            // Register Observers
            weatherStation.RegisterObserver(phoneDisplay);
            weatherStation.RegisterObserver(computerDisplay);

            // Change temperature and notify observers
            weatherStation.SetTemperature(25.0f);
            weatherStation.SetTemperature(30.5f);

            // Unregister an observer and notify again
            weatherStation.RemoveObserver(phoneDisplay);
            weatherStation.SetTemperature(28.0f);

            PrintEndLine();
        }
    }
}