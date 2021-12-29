using System;
using System.Collections.Generic;
using System.Text;

namespace HW6Library
{
    public class ConditionalOperatorsHelper
    {
        public static double CalculateByAAndB(int a, int b)
        {
            double result;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }

            return result;
        }

        public static int Quarter(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                throw new ArgumentException("Point should not lay on axis!");
            }

            int n = 0;

            if (x > 0 && y > 0)
            {
                n = 1;
            }
            else if (x < 0 && y > 0)
            {
                n = 2;
            }
            else if (x < 0 && y < 0)
            {
                n = 3;
            }
            else if (x > 0 && y < 0)
            {
                n = 4;
            }

            return n;
        }

        public static (double, double, double) ABCSort(double a, double b, double c)
        {
            if (a % 1 != 0 || b % 1 != 0 || c % 1 != 0)
            {
                throw new ArgumentException("A, B, C should be integer!");
            }

            if (a > b)
            {
                (a, b) = (b, a);
            }
            if (a > c)
            {
                (a, c) = (c, a);
            }
            if (b > c)
            {
                (b, c) = (c, b);
            }

            return (a, b, c);
        }

        public static (double, double) SquareQuation(double a, double b, double c)
        {
            double X1;
            double X2;

            double d = b * b - 4 * a * c;

            if (d < 0)
            {
                throw new ArgumentException("The discriminant must be equal to or greater than zero!");
            }

            X1 = Math.Round((-b + Math.Sqrt(d)) / 2 * a, 3);
            X2 = Math.Round((-b - Math.Sqrt(d)) / 2 * a, 3);

            return (X1, X2);
        }

        public static string TransformNumberInText(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("The number must be greater than zero!");
            }

            string result;

            string[] Array1 = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] Array2 = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] Array3 = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            int b = number % 10;
            int a = number / 10;

            if (number > 10 && number < 20)
            {
                result = Array2[number - 11];
            }
            else if (number < 10)
            {
                result = Array1[number - 1];
            }
            else
            {
                result = Array3[a - 1] + " " + Array1[b - 1];
            }

            return result;
        }
    }
}
