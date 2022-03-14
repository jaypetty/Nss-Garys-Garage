using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
             CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine("Zoooooom!");
        }
         public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle banks to the {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine("The vehicle makes it halfway to the end of the runway before coming to a full stop.");
        }
    }
}