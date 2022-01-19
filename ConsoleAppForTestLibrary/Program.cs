using System;
using CalculateObjectArea;

namespace ConsoleAppForTestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = CalculateObject.CalculateObjectArea(4,3,7);

            Console.WriteLine($"Площадь круга = {result}");
        }
    }
}
