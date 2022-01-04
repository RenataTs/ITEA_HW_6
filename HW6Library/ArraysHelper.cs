using System;
using System.Collections.Generic;
using System.Text;

namespace HW6Library
{
    public class ArraysHelper
    {
        public static int MinimumArrayValue(ref int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException();
            }

            int min = MinimumElementIndex(ref array);

            return array[min];
        }

        public static int MaximumArrayValue(ref int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException();
            }

            int max = MaximumElementIndex(ref array);

            return array[max];
        }

        public static int MinimumElementIndex(ref int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException();
            }

            int indexMin = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[indexMin])
                {
                    indexMin = i;
                }
            }

            return indexMin;
        }

        public static int MaximumElementIndex(ref int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException();
            }

            int indexMax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[indexMax])
                {
                    indexMax = i;
                }
            }

            return indexMax;
        }

        public static int ElementsSumWithOddIndex(ref int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException();
            }

            int sum = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int[] Reverse(ref int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException();
            }

            int n = array.Length;

            for (int i = 0; i < n / 2; i++)
            {
                VariablesHelper.Swap(ref array[i], ref array[n - i - 1]);
            }

            return array;
        }

        public static int OddArrayElementsCount(ref int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException();
            }

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    ++count;
                }
            }

            return count;
        }

        public static void ReverseOfFirstSecondPart(ref int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException();
            }

            int n = array.Length;

            for (int i = 0; i < n / 2; i++)
            {
                VariablesHelper.Swap(ref array[i], ref array[n / 2 + i + n % 2]);
            }
        }

        public static int[] SortArrayByInsertMethod(ref int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j >= (i + 1); j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        VariablesHelper.Swap(ref array[j], ref array[j - 1]);
                    }
                }
            }

            return array;
        }

        public static void SortArrayByBubbleMethod(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException();
            }

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0 && array[j - 1] < array[j]; j--)
                {
                    VariablesHelper.Swap(ref array[j - 1], ref array[j]);
                }
            }
        }
    }
}
