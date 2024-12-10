namespace DesignPatterns.Patterns.Creational.Prototype
{
    internal class Student : IPrototype<Student>
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int RollNumber { get; private set; }
        private static int Counter { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Counter++;
            RollNumber = Counter;
        }

        public Student Clone()
        {
            var st = new Student(Name, Age);
            st.RollNumber = RollNumber;
            return st;
        }

        public void PrintStudentDetails()
        {
            Console.WriteLine($"Name - {Name}, Age - {Age}, RollNumber - {RollNumber}");
        }
    }
}