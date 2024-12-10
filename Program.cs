using DesignPatterns.Runner;

internal class Program
{
    private static void Main(string[] args)
    {
        var runnerFactory = new RunnerFactory();

        foreach (var runner in runnerFactory.CreateRunners())
        {
            runner.Run();
        }
    }
}