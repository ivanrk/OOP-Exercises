namespace VehiclesExtension
{
    using System;

    public class Truck : Vehicle
    {
        private const double AdditionalConsumption = 1.6;
        private const double FuelTankDefect = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double AirConditionerConsumption => AdditionalConsumption;

        public override void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else if (this.FuelQuantity + amount > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
            }

            var fuelAmount = amount * FuelTankDefect;
            this.FuelQuantity += fuelAmount;
        }
    }
}
