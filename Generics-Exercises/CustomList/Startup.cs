namespace CustomList
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var customList = new CustomList<string>();
            string commandLine;

            while ((commandLine = Console.ReadLine()) != "END" )
            {
                var cmdParams = commandLine.Split();
                var command = cmdParams[0];

                switch (command)
                {
                    case "Add":
                        var element = cmdParams[1];
                        customList.Add(element);
                        break;
                    case "Remove":
                        var index = int.Parse(cmdParams[1]);
                        customList.Remove(index);
                        break;
                    case "Sort":
                        customList.Sort();
                        break;
                    case "Contains":
                        var givenElement = cmdParams[1];
                        var result = customList.Contains(givenElement);
                        Console.WriteLine(result);
                        break;
                    case "Swap":
                        var firstIndex = int.Parse(cmdParams[1]);
                        var secondIndex = int.Parse(cmdParams[2]);
                        customList.Swap(firstIndex, secondIndex);
                        break;
                    case "Greater":
                        var count = customList.CountGreaterThan(cmdParams[1]);
                        Console.WriteLine(count);
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;
                    case "Print":
                        foreach (var item in customList)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
        }
    }
}
