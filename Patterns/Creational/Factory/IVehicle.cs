using System.ComponentModel.DataAnnotations;

namespace DesignPatterns.Patterns.Creational.Factory
{
    internal interface IVehicle
    {
        [Range(2, 10, ErrorMessage = "Value must be in between 2 and 10")]
        int Wheels { get; }

        void drive();
    }
}