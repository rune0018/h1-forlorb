using System;
using System.Runtime.InteropServices;

namespace GPOpgaver
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] intArray = { 1, 3, 4, 5, 6, 8, 9, 11 };
            int steps = Opgaver.StepsInBinarySearch(intArray, 0, intArray.Length - 1, 9);
            Console.WriteLine(steps);
        }
    }
}
