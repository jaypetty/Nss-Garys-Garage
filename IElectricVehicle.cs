using System;

namespace Garage
{
    public interface IElectricVehicle
    {
        double BatteryKWh {get; set;}
        double CurrentChargePercentage {get; set;}
        
        void ChargeBattery()
        {
            Console.WriteLine("test");
        }
    }
}