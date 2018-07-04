namespace CarSalesman
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var numberOfEngines = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();
            var cars = new List<Car>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                var engineInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = engineInfo[0];
                var power = int.Parse(engineInfo[1]);

                var engine = new Engine(model, power);
                CheckIfEngineHasAnyOtherInfo(engineInfo, engine);
                engines.Add(engine);
            }

            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var carModel = carInfo[0];
                var engineModel = carInfo[1];
                var engine = new Engine(null, 0);

                foreach (var eng in engines)
                {
                    if (eng.Model == engineModel)
                    {
                        engine = eng;
                    }
                }

                var car = new Car(carModel, engine);
                CheckIfCarHasAnyOtherInfo(carInfo, car);

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                PrintInfo(car);
            }
        }

        private static void PrintInfo(Car car)
        {
            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($"  {car.Engine.Model}:");
            Console.WriteLine($"    Power: {car.Engine.Power}");
            Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
            Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
            Console.WriteLine($"  Weight: {car.Weight}");
            Console.WriteLine($"  Color: {car.Color}");
        }

        private static void CheckIfCarHasAnyOtherInfo(string[] carInfo, Car car)
        {
            if (carInfo.Length > 2)
            {
                if (int.TryParse(carInfo[2], out int number))
                {
                    car.Weight = number.ToString();
                }
                else
                {
                    car.Color = carInfo[2];
                }
            }
            if (carInfo.Length > 3)
            {
                car.Color = carInfo[3];
            }
        }

        private static void CheckIfEngineHasAnyOtherInfo(string[] engineInfo, Engine engine)
        {
            if (engineInfo.Length > 2)
            {
                if (int.TryParse(engineInfo[2], out int number))
                {
                    engine.Displacement = number.ToString();
                }
                else
                {
                    engine.Efficiency = engineInfo[2];
                }
            }
            if (engineInfo.Length > 3)
            {
                engine.Efficiency = engineInfo[3];
            }
        }
    }
}
