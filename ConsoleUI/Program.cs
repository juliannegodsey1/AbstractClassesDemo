using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Vehicles

            List<Vehicle> vehicles = new List<Vehicle>();

            var myCar = new Car()
            {
                Year = "2023", 
                Make = "Volkswagen", 
                Model = "Jetta", 
                HasTrunk = true
            };

            var myMotorcycle = new Motorcycle()
            {
                Year = "2019",
                Make = "Harley",
                Model = "Cruiser",
                HasSideCart = true
            };

            Vehicle myVehicle1 = new Car()
            {

                Year = "2024",
                Make = "Honda",
                Model = "Civic",
                HasTrunk = true

            };
            Vehicle myVehicle2 = new Motorcycle()
            {
                Year = "2021",
                Make = "Harley",
                Model = "Touring",
                HasSideCart = false

            };

            vehicles.Add(myCar);
            vehicles.Add(myMotorcycle);
            vehicles.Add(myVehicle1);
            vehicles.Add(myVehicle2);

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
            }
            #endregion            
            Console.ReadLine();
        }
    }
}
