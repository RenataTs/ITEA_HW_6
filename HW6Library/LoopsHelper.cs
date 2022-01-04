using System;
using System.Collections.Generic;
using System.Text;

namespace HW6Library
{
    public class LoopsHelper
    {
        public static double Exponention(double a, int b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentException();
            }

            double result = a;

            if (b == 0)
            {
                result = 1;
            }
            else
            {
                for (int i = 2; i <= b; i++)
                {
                    result *= a;
                }
            }

            return result;
        }

        public static int[] NumbersArrayDivisibleByA(int a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("The A must be greater than zero!");
            }

            int maxValue = 50;
            int[] array = new int[maxValue / a];
            for (int i = a, j = 0; i <= maxValue; i += a)
            {
                array[j++] = i;
            }

            return array;
        }

        public static double NumbersSquerdLessThanA(double a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("A should be greater then zero!");
            }

            int count = 0;

            for (int i = 1; i * i < a; i++)
            {
                ++count;
            }

            return count;
        }

        public static int TheLargestDivider(int a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("A should be greater then zero!");
            }

            int result = 0;

            for (int i = a - 1; i >= 0; i--)
            {
                if (a % i == 0)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        public static int NumbersSumFromAToBWhichDivisibleBySeven(int a, int b)
        {
            if (a > b)
            {
                VariablesHelper.Swap(ref a, ref b);
            }

            int divider = 7;
            int sum = 0;
            a += (divider - a % divider) % divider;

            for (int i = a; i <= b; i += a)
            {
                sum += i;
            }

            return sum;
        }

        public static int NthFibonacciNumbers(int number)
        {
            if (number <= 1)
            {
                throw new ArgumentException("N should be greater than one!");
            }

            int a = 1;
            int b = 1;
            int fictive = 0;

            for (int i = 0; i < number; i++)
            {
                a += b;
                fictive = b;
                b = a - fictive;
            }

            return fictive;
        }

        public static int GeneralDividerByEuclidAlgorithm(int number1, int number2)
        {
            if (number1 == 0 || number2 == 0)
            {
                throw new ArgumentException("A and B should be not equal to zero!");
            }

            while (number1 != 0 && number2 != 0)
            {
                if (number1 > number2)
                {
                    number1 %= number2;
                }
                else
                {
                    number2 %= number1;
                }
            }

            return number1 + number2;
        }

        public static double CalculateNumberFromCubeByHalfDivisionMethod(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("A and B should be greater than zero!");
            }

            double lowerLimit = 0;
            double upperLimit = number;
            double x = (upperLimit + lowerLimit) / 2;

            while (Math.Abs(number - x * x * x) > 0.001)
            {
                if (number < x * x * x)
                {
                    upperLimit = x;
                    x = Math.Round((upperLimit + lowerLimit) / 2, 3);
                }
                else
                {
                    lowerLimit = x;
                    x = Math.Round((upperLimit + lowerLimit) / 2, 3);
                }
            }

            return x;
        }

        public static int CountOfOddNumbersInFigure(int number)
        {
            if (number == 0)
            {
                throw new ArgumentException("Tne figure should not be equal to zero");
            }

            int count = 0;

            while (number != 0)
            {
                int currentDigit = number % 10;
                number /= 10;

                if (currentDigit % 2 == 1)
                {
                    ++count;
                }
            }

            return count;
        }

        public static int NumberReserse(int number)
        {
            if (number == 0)
            {
                throw new ArgumentException("Tne figure should not be equal to zero");
            }

            int newNumber = 0;

            while (number != 0)
            {
                int currentDigit = number % 10;
                number /= 10;
                newNumber *= 10;
                newNumber += currentDigit;
            }

            return newNumber;
        }

        static (int oddSum, int evenSum) GetValueParts(int n)
        {
            int oddSum = 0;
            int evenSum = 0;
            while (n != 0)
            {
                if (n % 2 == 0)
                {
                    evenSum += n % 10;
                }
                else
                {
                    oddSum += n % 10;
                }

                n /= 10;
            }

            return (oddSum, evenSum);
        }

        public static int[] EvenAndOddNumbersSum(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("The N must be greater than zero!");
            }

            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                (int oddSum, int evenSum) = GetValueParts(i);
                if (evenSum > oddSum)
                {
                    ++count;
                }
            }

            int[] array = new int[count];
            for (int i = 1, j = 0; i <= n; i++)
            {
                (int oddSum, int evenSum) = GetValueParts(i);
                if (evenSum > oddSum)
                {
                    array[j++] = i;
                }
            }

            return array;
        }

        public static bool EqualNumbersInDigit(int number1, int number2)
        {
            bool result = false;

            while (number1 != 0)
            {
                int currentDigit1 = number1 % 10;
                number1 /= 10;
                int dummy_number2 = number2;

                while (dummy_number2 != 0)
                {
                    int currentDigit2 = dummy_number2 % 10;
                    dummy_number2 /= 10;

                    if (currentDigit1 == currentDigit2)
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
