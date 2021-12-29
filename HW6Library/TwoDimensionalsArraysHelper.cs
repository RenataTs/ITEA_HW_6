using System;
using System.Collections.Generic;
using System.Text;

namespace HW6Library
{
    public class TwoDimensionalsArraysHelper
    {
        public static int MinValue(ref int[,] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array is null or empty!");
            }

            (int minI, int minJ) = MinI(ref array);

            return array[minI, minJ];
        }

        public static int MaxValue(ref int[,] array)
        {
            (int maxI, int maxJ) = MaxI(ref array);

            return array[maxI, maxJ];
        }

        public static (int, int) MinI(ref int[,] array)
        {
            int indexI = 0;
            int indexJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < array[indexI, indexJ])
                    {
                        indexI = i;
                        indexJ = j;
                    }
                }
            }

            return (indexI, indexJ);
        }

        public static (int, int) MaxI(ref int[,] array)
        {
            int maxI = 0;
            int maxJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > array[maxI, maxJ])
                    {
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            return (maxI, maxJ);
        }

        public static int GreaterThanNeighborhood(ref int[,] array)
        {
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i > 0 && array[i - 1, j] >= array[i, j])
                    {
                        continue;
                    }

                    if (j > 0 && array[i, j - 1] >= array[i, j])
                    {
                        continue;
                    }

                    if (i < array.GetLength(0) - 1 && array[i + 1, j] >= array[i, j])
                    {
                        continue;
                    }

                    if (j < array.GetLength(1) - 1 && (array[i, j + 1] >= array[i, j]))
                    {
                        continue;
                    }

                    ++count;
                }
            }

            return count;
        }

        public static int[,] ChangeAlongTheMainDiagonal(ref int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    VariablesHelper.Swap(ref array[i, j], ref array[j, i]);
                }
            }

            return array;
        }
    }
}
