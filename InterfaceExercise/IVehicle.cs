using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int WheelCount { get; set; }
        public int EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public void Drive();

    }
}
