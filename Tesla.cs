using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage {get; set;}

        
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes past you! Mmmmmmm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle quietly makes a {direction} turn.");
        }
        public override void Stop()
        {
            Console.WriteLine("The vehicle buzzes to a complete stop.");
        }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100; 
        }
    }
}