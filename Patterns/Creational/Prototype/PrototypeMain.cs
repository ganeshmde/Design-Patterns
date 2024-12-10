using DesignPatterns.Runner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Creational.Prototype
{
    internal class PrototypeMain : IRunner
    {
        public override void Run()
        {
            PrintStartLine();

            Student student = new Student("John", 23);
            Student studentCopy = student.Clone();
            student.Age++;

            Console.WriteLine("Updated Student Details");
            student.PrintStudentDetails();

            Console.WriteLine($"StudentCopy Details");
            studentCopy.PrintStudentDetails();

            PrintEndLine();
        }
    }
}