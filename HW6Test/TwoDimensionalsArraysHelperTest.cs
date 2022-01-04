using HW6Library;
using NUnit.Framework;
using System;

namespace HW6Test
{
    public class TwoDimensionalsArraysHelperTest
    {
        [TestCaseSource(nameof(MinCases))]
        public void MinValue_WhenArrayNotNul_ShouldReturnMinValueFromArray(
            int[,] sourceArray,
            int expectedMinValue)
        {
            int actualMinValue = TwoDimensionalsArraysHelper.MinValue(ref sourceArray);

            Assert.AreEqual(expectedMinValue, actualMinValue);
        }

        static object[] MinCases = new[]
        {
            new object[] { new[,] { { 1, 2, 3 }, { 1, 2, 3 } }, 1 },
            new object[] { new[,] { { 3, 2, 2 }, { 4, 3, 2 }, { 4, 3, 3 } }, 2 },
        };

        [TestCaseSource(nameof(MaxCases))]
        public void MaxValue_WhenArrayNotNul_ShouldReturnMaxValueFromArray(
            int[,] sourceArray,
            int expectedMinValue)
        {
            int actualMinValue = TwoDimensionalsArraysHelper.MaxValue(ref sourceArray);

            Assert.AreEqual(expectedMinValue, actualMinValue);
        }

        static object[] MaxCases = new[]
        {
            new object[] { new[,]{ { 1, 2, 3 }, { 3, 4, 5 } }, 5 },
            new object[] { new[,]{ { 3, 2, 1 }, { 4, 2, 6 } }, 6 },
            new object[] { new[,]{ { -4, -2, -3 }, { 0, -4, -3 } }, 0 }
        };

        [TestCaseSource(nameof(MinICase))]
        public void MinI_WhenArrayNotNull_ShouldReturnMinValueIndexFromArray(
            int[,] sourceArray,
            int expectedMinI,
            int expectedMinJ)
        {
            (int, int) expectedMinIndex = (expectedMinI, expectedMinJ);
            (int, int) actualMinIndex = TwoDimensionalsArraysHelper.MinI(ref sourceArray);

            Assert.AreEqual(expectedMinIndex, actualMinIndex);
        }

        static object[] MinICase = new[]
        {
            new object[] { new[,] { {1, 2, 3 }, { 3, 4, 5} }, 0, 0 },
            new object[] { new[,]{ {3, 2, 1 }, { 4, 2, 6} }, 0, 2 },
            new object[] { new[,]{ {4, -2, -3 }, { 0, -4, -3} }, 1, 1 }
        };

        [TestCaseSource(nameof(MaxICase))]
        public void MaxI_WhenArrayNotNull_ShouldReturnMaxValueIndexFromArray(
            int[,] sourceArray,
            int expectedMaxI,
            int expectedMaxJ)
        {
            (int, int) expectedMaxIndex = (expectedMaxI, expectedMaxJ);
            (int, int) actualMaxIndex = TwoDimensionalsArraysHelper.MaxI(ref sourceArray);

            Assert.AreEqual(actualMaxIndex, expectedMaxIndex);
        }

        static object[] MaxICase = new[]
        {
            new object[] { new[,]{ { 1, 2, 3 }, { 3, 4, 5 } }, 1, 2 },
            new object[] { new[,]{ { 3, 2, 1 }, { 7, 2, 6 } }, 1, 0 },
            new object[] { new[,]{ { 4, -2, -3 }, { 0, -4, -3 } }, 0, 0 }
        };

        [TestCaseSource(nameof(GreatestNeighborsCountCase))]
        public void GreaterThanNeighborhood_WhenArrayNotNull_ShouldReturnGreaterThanNeighborhoodCountFromArray(
            int[,] sourceArray,
            int expectedCount)
        {
            int actualCount = TwoDimensionalsArraysHelper.GreaterThanNeighborhood(ref sourceArray);

            Assert.AreEqual(actualCount, expectedCount);
        }

        static object[] GreatestNeighborsCountCase = new[]
        {
            new object[] { new[,]{ { 1, 2, 3 }, { 3, 4, 5 } }, 1 },
            new object[] { new[,]{ { 9, 2, 1 }, { 4, 2, 6 } }, 2 },
            new object[] { new[,]{ { 4, -2, -3 }, { 0, -4, -3 } }, 1 }
        };

        [TestCaseSource(nameof(NewArrayCase))]
        public void ChangeAlongTheMainDiagonal_WhenArrayNotNull_ShouldReturnArrayChangedAlongTheMainDiagonal(
            int[,] sourceArray,
            int[,] expectedArray)
        {
            TwoDimensionalsArraysHelper.ChangeAlongTheMainDiagonal(ref sourceArray);
        }

        static object[] NewArrayCase = new[]
{
            new object[] { new[,] { { 1, 2, 3 },
                                   { 3, 4, 5 },
                                   { 3, 4, 5 } },
                          new[,] { { 1, 3, 3 },
                                   { 2, 4, 4 },
                                   { 3, 5, 5 } } },
            new object[] { new[,] { { 4, 2, 1 },
                                   { 6, 9, 3 },
                                   { 7, 8, 0 } },
                          new[,] { { 4, 6, 7 },
                                   { 2, 9, 8 },
                                   { 1, 3, 0 } } }
        };
    }
}
