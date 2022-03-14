using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            fxs.CurrentChargePercentage = 45;
            fxs.MainColor = "Midnight Blue";
            fxs.BatteryKWh = 7.2;
            fxs.Name = "Better Zero";

            Tesla modelS = new Tesla();
            modelS.MainColor = "White";
            modelS.CurrentChargePercentage = 60;
            modelS.BatteryKWh = 100;
            modelS.Name = "Ghost White";

            Zero fx = new Zero();
            fx.MainColor = "Black";
            fx.BatteryKWh = 7.2;
            fx.CurrentChargePercentage = 75;
            fxs.Name = "Zero";

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram ();
            ram.MainColor = "Blue";
            ram.FuelCapacity = 26;
            ram.CurrentTankPercentage = 45;
            ram.Name = "Big Truck";


            Cessna cessna150 = new Cessna ();
            cessna150.MainColor = "Grey";
            cessna150.FuelCapacity = 25;
            cessna150.CurrentTankPercentage = 70;
            cessna150.Name = "Motorcycle";

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();

            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();

            cessna150.Drive();
            cessna150.Turn("right");
            cessna150.Stop();

            ram.Drive();
            ram.Turn("right");
            ram.Stop();
        }
    }
}