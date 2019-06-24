namespace VehiclesExtension
{
    public class Car : Vehicle
    {
        private const double AdditionalConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double AirConditionerConsumption => AdditionalConsumption;
    }
}
