using System;
using System.Collections.Generic;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; } = 100.00;
        public double CurrentChargePercentage {get; set;}
       
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you! Yeeeeeoooowww!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle slowly turns {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a complete, and noiseless stop!");
        }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
    }
}