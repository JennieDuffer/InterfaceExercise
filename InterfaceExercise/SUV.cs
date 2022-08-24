using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public bool SitsHigher { get; set; }

        public bool CanOffRoad { get; set; }

        public int WheelCount { get; set; }
        public int EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public string BrandName { get; set; }
        public bool HasSalesPeople { get; set; }


        public void Drive()
        {
            Console.WriteLine("The SUV is now in drive");
        }

        internal void Build()
        {
            throw new NotImplementedException();
        }
    }
}
