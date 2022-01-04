using HW6Library;
using NUnit.Framework;
using System;

namespace HW6Test
{
    public class ConditionalOpetatorsHelperTest
    {
        [TestCase(2, 3, -1)]
        [TestCase(4, 4, 16)]
        [TestCase(5, 2, 7)]
        public void CalculateByAAndB_WhenAAndBArePassed_ShouldReturnResultByAAndB(
            int sourceA,
            int sourceB,
            int expectedResult)
        {
            double actualResult = ConditionalOperatorsHelper.CalculateByAAndB(sourceA, sourceB);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(2, 3, 1)]
        [TestCase(-3, 4, 2)]
        [TestCase(-5, -2, 3)]
        [TestCase(5, -2, 4)]
        public void Quater_WhenPointNotOnAxis_ShouldReturnQuarterPoint(
            int sourceA,
            int sourceB,
            int expectedResult)
        {
            double actualResult = ConditionalOperatorsHelper.Quarter(sourceA, sourceB);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(2, 0)]
        [TestCase(0, 4)]
        [TestCase(-5, 0)]
        [TestCase(0, -2)]
        public void Quater_WhenPointLayOnAxis_ShouldThrowArgumentException(
            int sourceA,
            int sourceB)
        {
            try
            {
                ConditionalOperatorsHelper.Quarter(sourceA, sourceB);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Point should not lay on axis!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(2, 3, 1, 1, 2, 3)]
        [TestCase(-3, 4, 2, -3, 2, 4)]
        [TestCase(-5, -2, 3, -5, -2, 3)]
        [TestCase(5, -2, 4, -2, 4, 5)]
        [TestCase(5, -2, null, -2, null, 5)]
        public void ABCSort_WhenABCIsPassed_ShouldReturnQuarterPoint(
            int sourceA,
            int sourceB,
            int sourceC,
            int expectedA,
            int expectedB,
            int expectedC)
        {
            (int, int, int) expectedResult = (expectedA, expectedB, expectedC);
            (int, int, int) actualResult = ConditionalOperatorsHelper.ABCSort(sourceA, sourceB, sourceC);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, -2, -3, 3, -1)]
        [TestCase(-1, -2, 15, -5, 3)]
        [TestCase(1, 12, 36, -6, -6)]
        public void SquareQuation_WhenDiscriminantNotLessThanZero_ShouldCalculateSquareQuation(
            double sourceA,
            double sourceB,
            double sourceC,
            double expectedX1,
            double expectedX2)
        {
            (double, double) expectedResult = (expectedX1, expectedX2);
            (double, double) actualResult = ConditionalOperatorsHelper.SquareQuation(sourceA, sourceB, sourceC);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, 3, 7)]
        public void SquareQuation_WhenDiscriminantIsLessThanZero_ShouldThrowArgumentException(
            double sourceA,
            double sourceB,
            double sourceC)
        {
            try
            {
                ConditionalOperatorsHelper.SquareQuation(sourceA, sourceB, sourceC);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The discriminant must be equal to or greater than zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(9, "nine")]
        [TestCase(35, "thirty five")]
        [TestCase(11, "eleven")]
        public void TransformNumberInText_WhenNumberNotLessThanZero_ShouldTransformNumberInText(
            int sourceNumber,
            string expectedString)
        {
            string actualString = ConditionalOperatorsHelper.TransformNumberInText(sourceNumber);

            Assert.AreEqual(expectedString, actualString);
        }

        [TestCase(0)]
        [TestCase(-2)]
        [TestCase(-7)]
        public void TransformNumberInText_WhenNumberIsLessThanZero_ShouldThrowArgumentException(
            int sourceNumber)
        {
            try
            {
                ConditionalOperatorsHelper.TransformNumberInText(sourceNumber);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The number must be greater than zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}
