namespace DesignPatterns.Runner
{
    internal abstract class IRunner
    {
        public abstract void Run();

        public void PrintStartLine()
        {
            Console.WriteLine($"{GetType().Name} Started");
        }

        public void PrintEndLine()
        {
            Console.WriteLine($"{GetType().Name} Ended");
            Console.WriteLine("----------------------------------------------");
        }
    }
}