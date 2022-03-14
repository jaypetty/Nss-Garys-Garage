using System;

namespace Garage
{
    public interface IGasVehicle
    {
        double CurrentTankPercentage { get; set; }
        double FuelCapacity {get; set;}
        
        void RefuelTank();

    }
}