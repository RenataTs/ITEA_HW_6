using System;

namespace HW6Library
{
    public class VariablesHelper
    {
        public static double CalculateEquation(double a, double b)
        {
            if (a == b)
            {
                throw new ArgumentException("A equal to B!");
            }

            return (5 * a + b * b) / (b - a);
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static (int, int) CalculateDivisionAndRemainder(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("B equals zero");
            }

            return (a / b, a % b);
        }

        public static double CalculateExample(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                throw new ArgumentException("One of the variables are equals to zero");
            }

            return (c - b) / a;
        }
        public static (double, double) CalculateStraightLineEquation(int x1, int y1, int x2, int y2)
        {
            if (x1 == 0 || y1 == 0 || x2 == 0 || y2 == 0)
            {
                throw new ArgumentException("One of the points are lies on axis");
            }

            return ((double)(y1 - y2) / (x1 - x2), (double)(y2 - (y1 - y2) / (x1 - x2) * x2));
        }
    }
}
