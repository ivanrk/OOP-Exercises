namespace VehiclesExtension
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var carInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var carFuelQuantity = double.Parse(carInput[1]);
            var carFuelConsumption = double.Parse(carInput[2]);
            var carTankCapacity = double.Parse(carInput[3]);
            Vehicle car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);

            var truckInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var truckFuelQuantity = double.Parse(truckInput[1]);
            var truckFuelConsumption = double.Parse(truckInput[2]);
            var truckTankCapacity = double.Parse(truckInput[3]);
            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);

            var busInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var busFuelQuantity = double.Parse(busInput[1]);
            var busFuelConsumption = double.Parse(busInput[2]);
            var busTankCapacity = double.Parse(busInput[3]);
            Vehicle bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commandLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
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

                    case nameof(Bus):
                        ExecuteCommand(bus, command, amount);
                        break;
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ExecuteCommand(Vehicle vehicle, string command, double amount)
        {
            if (command == "Drive")
            {
                Console.WriteLine(vehicle.Drive(amount));
            }
            else if (command == "DriveEmpty")
            {
                Console.WriteLine(vehicle.DriveEmpty(amount));
            }
            else if (command == "Refuel")
            {
                try
                {
                    vehicle.Refuel(amount);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
