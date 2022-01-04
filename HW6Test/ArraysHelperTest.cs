using HW6Library;
using NUnit.Framework;
using System;

namespace HW6Test
{
    public class ArraysHelperTest
    {
        [TestCase(new int[] { 1, 2, 3 }, 1)]
        [TestCase(new int[] { 2 }, 2)]
        public void MinimumArrayValue_WhenArrayNotNull_ShouldReturnMinimumArrayValue(
            int[] sourceArray,
            int expectedMinValue)
        {
            int actualResult = ArraysHelper.MinimumArrayValue(ref sourceArray);

            Assert.AreEqual(actualResult, expectedMinValue);
        }
        public void MinimumArrayValue_WhenArrayIsNull_ShouldReturnMinimumArrayValue(
            int[,] sourceArray,
            int expectedCount)
        {
            int actualCount = TwoDimensionalsArraysHelper.GreaterThanNeighborhood(ref sourceArray);

            Assert.AreEqual(actualCount, expectedCount);
        }

        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 2 }, 2)]
        public void MaximumArrayValue_WhenArrayNotNull_ShouldReturnMaximumArrayValue(
            int[] sourceArray,
            int expectedMaxValue)
        {
            int actualResult = ArraysHelper.MaximumArrayValue(ref sourceArray);

            Assert.AreEqual(actualResult, expectedMaxValue);
        }

        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { 2 }, 0)]
        [TestCase(new int[] { }, null)]
        public void MinimumElementIndex_WhenArrayNotNull_ShouldReturnMinimumIndexArrayValue(
            int[] sourceArray,
            int expectedMinValue)
        {
            int actualResult = ArraysHelper.MinimumElementIndex(ref sourceArray);

            Assert.AreEqual(actualResult, expectedMinValue);
        }

        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 2 }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { }, 0)]
        public void MaximumElementIndex_WhenArrayNotNull_ShouldReturnMaximumIndexArrayValue(
            int[] sourceArray,
            int expectedMinValue)
        {
            int actualResult = ArraysHelper.MaximumElementIndex(ref sourceArray);

            Assert.AreEqual(actualResult, expectedMinValue);
        }

        [TestCase(new int[] { 1, 2, 3, 3 }, 5)]
        [TestCase(new int[] { 2 }, 0)]
        [TestCase(new int[] { }, null)]
        public void ElementsSumWithOddIndex_WhenArrayNotNull_ShouldCalculateElementsSumWithOddIndex(
            int[] sourceArray,
            int expectedMinValue)
        {
            int actualResult = ArraysHelper.ElementsSumWithOddIndex(ref sourceArray);

            Assert.AreEqual(actualResult, expectedMinValue);
        }

        [TestCase(new int[] { 1, 2, 3, 3 }, new int[] { 3, 3, 2, 1 })]
        [TestCase(new int[] { 2 }, new int[] { 2 })]
        [TestCase(new int[] { }, new int[] { })]
        public void Reverse_WhenArrayNotNull_ShouldReverseArray(
            int[] sourceArray,
            int[] expectedArray)
        {
            ArraysHelper.Reverse(ref sourceArray);

            Assert.AreEqual(sourceArray, expectedArray);
        }

        [TestCase(new int[] { 1, 2, 3, 3 }, 3)]
        [TestCase(new int[] { 2, 4, 6 }, 0)]
        [TestCase(new int[] { }, null)]
        public void OddArrayElementsCount_WhenArrayNotNull_ShouldCalculateOddArrayElementsCount(
            int[] sourceArray,
            int expectedCount)
        {
            int actualCount = ArraysHelper.OddArrayElementsCount(ref sourceArray);

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCase(new int[] { 1, 2, 3, 3 }, new int[] { 3, 3, 1, 2 })]
        [TestCase(new int[] { 2, 4, 1 }, new int[] { 1, 4, 2 })]
        [TestCase(new int[] { 2, 4, 1, 3, 2 }, new int[] { 3, 2, 1, 2, 4 })]
        [TestCase(new int[] { }, new int[] { })]
        public void ReverseOfFirstSecondPart_WhenArrayNotNull_ShouldReverseOfFirstSecondPart(
            int[] sourceArray,
            int[] expectedArray)
        {
            ArraysHelper.ReverseOfFirstSecondPart(ref sourceArray);

            Assert.AreEqual(sourceArray, expectedArray);
        }

        [TestCase(new int[] { 1, 2, 3, 3 }, new int[] { 1, 2, 3, 3 })]
        [TestCase(new int[] { 2, 1, -3, 2 }, new int[] { -3, 1, 2, 2 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortArrayByInsertMethod_WhenArrayNotNull_ShouldSortArrayByInsertMethod(
            int[] sourceArray,
            int[] expectedArray)
        {
            ArraysHelper.SortArrayByInsertMethod(ref sourceArray);

            Assert.AreEqual(sourceArray, expectedArray);
        }

        [TestCase(new int[] { 1, 2, 3, 3 }, new int[] { 3, 3, 2, 1 })]
        [TestCase(new int[] { 2, 1, -3, 2 }, new int[] { 2, 2, 1, -3 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortArrayByBubbleMethod_WhenArrayNotNull_ShouldSortArrayByBubbleMethod(
            int[] sourceArray,
            int[] expectedArray)
        {
            ArraysHelper.SortArrayByBubbleMethod(sourceArray);

            Assert.AreEqual(sourceArray, expectedArray);
        }
    }
}
