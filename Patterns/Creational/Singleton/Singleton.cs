namespace DesignPatterns.Patterns.Creational.Singleton
{
    internal sealed class Singleton
    {
        private static Singleton _instance = null;

        private Singleton()
        {
            Console.WriteLine("Singleton instance created");
        }

        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        // Calls the constructor while inheriting
        //public class SubClass : Singleton
        //{
        //}
    }
}