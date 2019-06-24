namespace VehiclesExtension
{
    using System;

    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                this.fuelConsumption = value;
            }
        }

        public double TankCapacity
        {
            get { return this.tankCapacity; }
            private set
            {
                this.tankCapacity = value;

                if (this.tankCapacity < this.FuelQuantity)
                {
                    this.FuelQuantity = 0;
                    this.tankCapacity = 0;
                }
            }
        }

        public abstract double AirConditionerConsumption { get; }

        public string Drive(double distance)
        {
            var fuelConsumption = this.FuelConsumption + AirConditionerConsumption;
            var travelConsumption = distance * fuelConsumption;

            if (travelConsumption > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            this.FuelQuantity -= travelConsumption;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public string DriveEmpty(double distance)
        {
            var travelConsumption = distance * this.FuelConsumption;

            if (travelConsumption > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            this.FuelQuantity -= travelConsumption;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else if (this.FuelQuantity + amount > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
            }
            this.FuelQuantity += amount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
