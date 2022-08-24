using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool HasTailgate { get; set; }
        public bool HasFourWheelDrive { get; set; }

        public int WheelCount { get; set; }
        public int EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public string BrandName { get; set; }
        public bool HasSalesPeople { get; set; }

        public void Drive()
        {
            Console.WriteLine("The truck is now in drive");
        }

    }
}
