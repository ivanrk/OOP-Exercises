namespace GenericBox
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var boxes = new List<Box<string>>();
            var numberOfStrings = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStrings; i++)
            {
                var box = new Box<string>(Console.ReadLine());
                boxes.Add(box);
            }

            var givenElement = Console.ReadLine();
            var countOfGreaterElements = 0;

            foreach (var box in boxes)
            {
                var count = box.CompareElementsCount(givenElement);
                countOfGreaterElements += count;
            }

            Console.WriteLine(countOfGreaterElements);
            //SwapPlaces(boxes);
        }

        private static void SwapPlaces(List<Box<string>> boxes)
        {
            var swapIndexes = Console.ReadLine().Split();
            var index = int.Parse(swapIndexes[0]);
            var withIndex = int.Parse(swapIndexes[1]);

            SwapBoxes.Swap(boxes, index, withIndex);
        }
    }
}
