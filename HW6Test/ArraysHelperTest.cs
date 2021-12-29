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

        [TestCase(new int[] { })]
        public void MinimumArrayValue_WhenArrayIsNull_ShouldThrowArgumentNullException(
            int[] sourceArray)
        {
            try
            {
                ArraysHelper.MinimumArrayValue(ref sourceArray);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Value cannot be null.", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
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

        [TestCase(new int[] { })]
        public void MaximumArrayValue_WhenArrayIsNull_ShouldThrowArgumentNullException(
            int[] sourceArray)
        {
            try
            {
                ArraysHelper.MaximumArrayValue(ref sourceArray);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Value cannot be null.", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { 2 }, 0)]
        [TestCase(new int[] { }, 0)]
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
        public void ElementsSumWithOddIndex_WhenArrayNotNull_ShouldCalculateElementsSumWithOddIndex(
            int[] sourceArray,
            int expectedMinValue)
        {
            int actualResult = ArraysHelper.ElementsSumWithOddIndex(ref sourceArray);

            Assert.AreEqual(actualResult, expectedMinValue);
        }

        [TestCase(new int[] { })]
        public void ElementsSumWithOddIndex_WhenArrayIsNull_ShouldThrowArgumentNullException(
            int[] sourceArray)
        {
            try
            {
                ArraysHelper.ElementsSumWithOddIndex(ref sourceArray);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Value cannot be null.", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 3 }, new int[] { 3, 3, 2, 1 })]
        [TestCase(new int[] { 2 }, new int[] { 2 })]
        public void Reverse_WhenArrayNotNull_ShouldReverseArray(
            int[] sourceArray,
            int[] expectedArray)
        {
            ArraysHelper.Reverse(ref sourceArray);

            Assert.AreEqual(sourceArray, expectedArray);
        }

        [TestCase(new int[] { })]
        public void Reverse_WhenArrayIsNull_ShouldThrowArgumentNullException(
            int[] sourceArray)
        {
            try
            {
                ArraysHelper.Reverse(ref sourceArray);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Value cannot be null.", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 3 }, 3)]
        [TestCase(new int[] { 2, 4, 6 }, 0)]
        public void OddArrayElementsCount_WhenArrayNotNull_ShouldCalculateOddArrayElementsCount(
            int[] sourceArray,
            int expectedCount)
        {
            int actualCount = ArraysHelper.OddArrayElementsCount(ref sourceArray);

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCase(new int[] { })]
        public void OddArrayElementsCount_WhenArrayIsNull_ShouldThrowArgumentNullException(
            int[] sourceArray)
        {
            try
            {
                ArraysHelper.Reverse(ref sourceArray);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Value cannot be null.", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 3 }, new int[] { 3, 3, 1, 2 })]
        [TestCase(new int[] { 2, 4, 1 }, new int[] { 1, 4, 2 })]
        [TestCase(new int[] { 2, 4, 1, 3, 2 }, new int[] { 3, 2, 1, 2, 4 })]
        public void ReverseOfFirstSecondPart_WhenArrayNotNull_ShouldReverseOfFirstSecondPart(
            int[] sourceArray,
            int[] expectedArray)
        {
            ArraysHelper.ReverseOfFirstSecondPart(ref sourceArray);

            Assert.AreEqual(sourceArray, expectedArray);
        }

        [TestCase(new int[] { })]
        public void ReverseOfFirstSecondPart_WhenArrayIsNull_ShouldThrowArgumentNullException(
            int[] sourceArray)
        {
            try
            {
                ArraysHelper.ReverseOfFirstSecondPart(ref sourceArray);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Value cannot be null.", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 3 }, new int[] { 1, 2, 3, 3 })]
        [TestCase(new int[] { 2, 1, -3, 2 }, new int[] { -3, 1, 2, 2 })]
        public void SortArrayByInsertMethod_WhenArrayNotNull_ShouldSortArrayByInsertMethod(
            int[] sourceArray,
            int[] expectedArray)
        {
            ArraysHelper.SortArrayByInsertMethod(ref sourceArray);

            Assert.AreEqual(sourceArray, expectedArray);
        }

        [TestCase(new int[] { })]
        public void SortArrayByInsertMethod_WhenArrayIsNull_ShouldThrowArgumentNullException(
            int[] sourceArray)
        {
            try
            {
                ArraysHelper.SortArrayByInsertMethod(ref sourceArray);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Value cannot be null.", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 3 }, new int[] { 3, 3, 2, 1 })]
        [TestCase(new int[] { 2, 1, -3, 2 }, new int[] { 2, 2, 1, -3 })]
        public void SortArrayByBubbleMethod_WhenArrayNotNull_ShouldSortArrayByBubbleMethod(
            int[] sourceArray,
            int[] expectedArray)
        {
            ArraysHelper.SortArrayByBubbleMethod(ref sourceArray);

            Assert.AreEqual(sourceArray, expectedArray);
        }

        [TestCase(new int[] { })]
        public void SortArrayByBubbleMethod_WhenArrayIsNull_ShouldThrowArgumentNullException(
            int[] sourceArray)
        {
            try
            {
                ArraysHelper.SortArrayByBubbleMethod(ref sourceArray);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Value cannot be null.", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}
