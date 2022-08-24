using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */
            var car = new Car() { Make = "Lincoln", Model = "Town Car", EngineSize = 3 };
                var truck = new Truck() { Make = "Ford", Model = "F150", HasTailgate = true };
                var suv = new SUV() { Make = "Jeep", Model = "Wrangler", CanOffRoad = true };   

            var vehicles = new List<IVehicle>() { car, truck, suv };

            foreach (var item in vehicles)
            {
               
                Console.WriteLine($" Make: {item.Make}, Model: {item.Model}");
                item.Drive();
;
                Console.WriteLine();
            }

            Console.WriteLine("Please select which vehicle you would like to drive:   ");
            Console.ReadLine();
            Console.WriteLine();

            

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
