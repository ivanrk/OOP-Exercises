namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        private const double AdditionalConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double AirConditionerConsumption => AdditionalConsumption;
    }
}
