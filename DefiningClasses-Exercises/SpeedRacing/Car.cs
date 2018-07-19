namespace SpeedRacing
{
    using System;

    public class Car
    {
        private string model;
        private decimal fuelAmount;
        private decimal fuelConsumption;
        private decimal distanceTravelled;

        public Car(string model, decimal fuelAmount, decimal fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            this.distanceTravelled = 0;
        }

        public string Model
        {
            get { return this.model; }
        }

        public void CalculateDistance(decimal amountOfKm)
        {
            var travelConsumption = amountOfKm * this.fuelConsumption;

            if (travelConsumption > fuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.fuelAmount -= travelConsumption;
                this.distanceTravelled += amountOfKm;
            }
        }

        public void PrintCar()
        {
            Console.WriteLine($"{this.model} {this.fuelAmount:f2} {this.distanceTravelled}");
        }
    }
}
