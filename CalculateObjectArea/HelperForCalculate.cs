using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CalculateObjectArea.Tests")]
namespace CalculateObjectArea
{
   
    internal static class HelperForCalculate
    {
        internal static bool CheckingArguments(double a, double b, double c)
        {
            if (!isPositive(a) | !isPositive(b) | !isPositive(c))
            {
                throw new ArgumentException("Arguments can be positive.");
            }

            if (a + b <= c | a + c <= b | b + c <= a)
            {
                throw new ArgumentException("Triangle does not exist. Fix sides.");
            }
            return true;

        }

        internal static void CheckingArguments(double a)
        {
            if (!isPositive(a))
            {
                throw new ArgumentException("Arguments can be positive.");
            }
        }

        internal static bool isPositive(double number)
        {
            if (number > 0) return true;

            return false;
        }

        internal static bool CheckIsTriangleWithRightAngle(double a, double b, double c)
        {
            var w = Math.Max(a, b);
            w = Math.Max(w, c);

            if (((a * a) + (b * b)) == (w * w))
            {
                return true;
            }
            return false;
        }
    }
}
