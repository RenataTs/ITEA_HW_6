using HW6Library;
using NUnit.Framework;
using System;

namespace HW6Test
{
    public class VariablesHelperTests
    {
        [TestCase(2, 3, 19)]
        [TestCase(3, 5, 20)]
        public void CalculateEquation_WhenANotEqualToB_ShouldCalculateEquation(
            double a,
            double b,
            double expectedResult)
        {
            double actualResult = VariablesHelper.CalculateEquation(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CalculateEqution_WhenAEqualToB_ShouldThrowArgumentEquation()
        {
            try
            {
                VariablesHelper.CalculateEquation(1, 1);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A equal to B!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(10, 5, 2, 0)]
        public void CalculateDivisionAndRemainder_WhenBNotEqualsZero_CalculateDivisionAndRemainder(
            int a,
            int b,
            int expectedDivision,
            int expectedRemainder)
        {
            (int, int) expectedResult = (expectedDivision, expectedRemainder);
            (int, int) actualResult = VariablesHelper.CalculateDivisionAndRemainder(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CalculateDivisionAndRemainder_WhenBEqualsZero_ShouldThrowDivideByZero()
        {
            try
            {
                (int, int) actualResult = VariablesHelper.CalculateDivisionAndRemainder(10, 0);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("B equals zero", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(4, 2, 2, 0)]
        public static void CalculateExample_WhenABCNotEqualsToZero_ShouldCalculateExample(
            double a,
            double b,
            double c,
            double expectedResult)
        {
            double actualResult = VariablesHelper.CalculateExample(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void CalculateExample_WhenABCEqualsToZero_ShouldThrowArgumentExcemption()
        {
            try
            {
                double actualResult = VariablesHelper.CalculateExample(0, 2, 3);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("One of the variables are equals to zero", ex.Message);
                Assert.Pass();
            }
        }

        [TestCase(10, 5, 2, 1, 0.5, 1)]
        public static void StraigtLineEquation_WhenPointLiesOnTheAxis_SHouldCalculateStraigtLineEquation(
            int x1,
            int y1,
            int x2,
            int y2,
            double bExpected,
            double kExpected)
        {
            (double, double) expectedResult = (bExpected, kExpected);
            (double, double) actualResult = VariablesHelper.CalculateStraightLineEquation(x1, y1, x2, y2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void StraigtLineEquation_WhenOneOfThePointsAreLiesOnAxis_ShouldThrowArgumentExcemption()
        {
            try
            {
                (double, double) actualResult = VariablesHelper.CalculateStraightLineEquation(0, 5, 2, 1);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("One of the points are lies on axis", ex.Message);
                Assert.Pass();
            }
        }
    }
}