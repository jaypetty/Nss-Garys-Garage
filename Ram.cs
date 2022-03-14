using System;
using System.Collections.Generic;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle //Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram rumbles past! Rrruummmbbble!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle quickly lumbers around a {direction} turn");
        }
        public override void Stop()
        {
            Console.WriteLine("The vehicle quickly comes to a full stop!");
        }
    }
}