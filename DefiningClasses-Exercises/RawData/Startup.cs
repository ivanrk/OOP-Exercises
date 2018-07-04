namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < N; i++)
            {
                var carInfo = Console.ReadLine().Split(' ');
                var model = carInfo[0];
                var engineSpeed = int.Parse(carInfo[1]);
                var enginePower = int.Parse(carInfo[2]);
                var cargoWeight = int.Parse(carInfo[3]);
                var cargoType = carInfo[4];
                var tire1Pressure = double.Parse(carInfo[5]);
                var tire1Age = int.Parse(carInfo[6]);
                var tire2Pressure = double.Parse(carInfo[7]);
                var tire2Age = int.Parse(carInfo[8]);
                var tire3Pressure = double.Parse(carInfo[9]);
                var tire3Age = int.Parse(carInfo[10]);
                var tire4Pressure = double.Parse(carInfo[11]);
                var tire4Age = int.Parse(carInfo[12]);

                var car = new Car(
                    model,
                    new Engine(engineSpeed, enginePower),
                    new Cargo(cargoWeight, cargoType),
                    new List<Tire>
                    {
                        new Tire(tire1Pressure, tire1Age),
                        new Tire(tire2Pressure, tire2Age),
                        new Tire(tire3Pressure, tire3Age),
                        new Tire(tire4Pressure, tire4Age)
                    });

                cars.Add(car);
            }

            var command = Console.ReadLine();
            if (command == "fragile")
            {
                cars = cars
                        .Where(c => c.Cargo.Type == "fragile")
                        .Where(c => c.Tires.Any(t => t.Pressure < 1))
                        .ToList();

                foreach (var car in cars)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")
            {
                cars = cars
                        .Where(c => c.Cargo.Type == "flamable")
                        .Where(c => c.Engine.Power > 250)
                        .ToList();

                cars.ForEach(c => Console.WriteLine(c.Model));
            }
        }
    }
}
