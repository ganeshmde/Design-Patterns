namespace DesignPatterns.Patterns.Behavioural.Observer
{
    internal interface IWeatherStation
    {
        void RegisterObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void NotifyObservers();
    }
}