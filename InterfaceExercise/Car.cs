using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool IsSmall { get; set; }

        public bool HasTrunk { get; set; }

        public int WheelCount { get ; set; }
        public int EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public string BrandName { get; set; }
        public bool HasSalesPeople { get; set; }

        public void Drive()
        {
            Console.WriteLine("The car is now in drive");
        }

        internal void Build()
        {
            Console.WriteLine("You chose the car!");
        }
    }
}
