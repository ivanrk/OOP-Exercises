namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double AdditionalConsumption = 1.6;
        private const double FuelTankDefect = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double AirConditionerConsumption => AdditionalConsumption;

        public override void Refuel(double amount)
        {
            var fuelAmount = amount * FuelTankDefect;
            this.FuelQuantity += fuelAmount;
        }
    }
}
