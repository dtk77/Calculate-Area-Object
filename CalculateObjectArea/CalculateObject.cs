using System;
using System.Runtime.CompilerServices;

namespace CalculateObjectArea
{
    public static class CalculateObject
    {

        /// <summary>
        /// This method calculates the area of ​​a triangle.
        /// </summary>
        /// <returns>
        /// returns the area of ​​a triangle
        ///</returns> 
        ///<exception cref="Arguments can be positive.">
        ///Thrown when one parameter or more is not pasitive.
        ///</exception>
        ///<exception cref="Triangle does not exist. Fix sides.">
        ///The sum of the lengths of any two sides of a triangle is greater
        ///than the length of the third side of that triangle
        ///</exception>

        public static double CalculateObjectArea(double a, double b, double c)
        {
            HelperForCalculate.CheckingArguments(a, b, c);

            double p = (double)(a + b + c) / 2;
            double area = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));

            return area;
        }

        /// <summary>
        /// This method calculates the area of ​​a circle.
        /// </summary>
        /// <returns>
        /// returns the area of ​​a circle
        ///</returns> 
        ///<exception cref="Argument can be positive.">
        ///Thrown when one parameter or more is not pasitive.
        ///</exception>
        
        public static double CalculateObjectArea(double radius)
        {
            HelperForCalculate.CheckingArguments(radius);

            double area = Math.PI * (radius * radius);
            area = Math.Round(area, 2);

            return area;
        }

        /// <summary>
        /// This method will return true, if there is a right angle triangle
        /// </summary>
        /// <returns>
        /// return true if there is a right angle triangle, else false
        ///</returns> 
        ///<exception cref="Arguments can be positive.">
        ///Thrown when one parameter or more is not pasitive.
        ///</exception>
        ///<exception cref="Triangle does not exist. Fix sides.">
        ///The sum of the lengths of any two sides of a triangle is greater
        ///than the length of the third side of that triangle
        ///</exception>
        public static bool GetCheckIsTriangleWithRightAngle(double a, double b, double c)
        {
            HelperForCalculate.CheckingArguments(a, b, c);

            bool IsTriangleWithRightAngle =
                            HelperForCalculate.CheckIsTriangleWithRightAngle(a, b, c);

            return IsTriangleWithRightAngle;
        }


    }
}
