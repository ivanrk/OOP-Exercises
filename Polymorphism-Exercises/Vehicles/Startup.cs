namespace Vehicles
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var carInput = Console.ReadLine().Split();
            var carFuelQuantity = double.Parse(carInput[1]);
            var carFuelConsumption = double.Parse(carInput[2]);
            Vehicle car = new Car(carFuelQuantity, carFuelConsumption);

            var truckInput = Console.ReadLine().Split();
            var truckFuelQuantity = double.Parse(truckInput[1]);
            var truckFuelConsumption = double.Parse(truckInput[2]);
            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commandLine = Console.ReadLine().Split();
                var command = commandLine[0];
                var vehicle = commandLine[1];
                var amount = double.Parse(commandLine[2]);

                switch (vehicle)
                {
                    case nameof(Car):
                        ExecuteCommand(car, command, amount);
                        break;

                    case nameof(Truck):
                        ExecuteCommand(truck, command, amount);
                        break;
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void ExecuteCommand(Vehicle vehicle, string command, double amount)
        {
            if (command == "Drive")
            {
                Console.WriteLine(vehicle.Drive(amount));
            }
            else if (command == "Refuel")
            {
                vehicle.Refuel(amount);
            }
        }
    }
}
