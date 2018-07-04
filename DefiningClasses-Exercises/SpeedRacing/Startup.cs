namespace SpeedRacing
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
                var fuelAmount = decimal.Parse(carInfo[1]);
                var fuelConsumptionForKm = decimal.Parse(carInfo[2]);

                var car = new Car(model, fuelAmount, fuelConsumptionForKm);
                AddCar(cars, model, car);
            }

            string commandLine;
            while ((commandLine = Console.ReadLine()) != "End")
            {
                var commmandAgs = commandLine.Split(' ');
                var model = commmandAgs[1];
                var amountOfKm = decimal.Parse(commmandAgs[2]);

                cars
                    .Where(c => c.Model == model)
                    .ToList()
                    .ForEach(c => c.CalculateDistance(amountOfKm));
            }

            cars.ForEach(c => c.PrintCar());
        }

        private static void AddCar(List<Car> cars, string model, Car car)
        {
            var isNotAvailable = true;
            foreach (var c in cars)
            {
                if (c.Model == model)
                {
                    isNotAvailable = false;
                    break;
                }
            }

            if (isNotAvailable)
            {
                cars.Add(car);
            }
        }
    }
}
