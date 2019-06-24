namespace GenericBox
{
    using System.Collections.Generic;

    public static class SwapBoxes 
    {
        public static void Swap<T>(IList<T> boxes, int firstIndex, int secondIndex)
        {
            T currentElement = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = currentElement;
        }
    }
}
