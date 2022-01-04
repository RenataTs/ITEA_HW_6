using HW6Library;
using NUnit.Framework;
using System;

namespace HW6Test
{
    public class LoopsHelperTest
    {
        [TestCase(-2, 3, -8)]
        [TestCase(3, 2, 9)]
        [TestCase(3, null, 1)]
        public void Exponention_WhenBNotDouble_ShouldCalculateExponention(
            double a,
            int b,
            double expectedResult)
        {
            double actualResult = LoopsHelper.Exponention(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 })]
        [TestCase(6, new int[] { 6, 12, 18, 24, 30, 36, 42, 48 })]
        public void NumbersArrayDivisibleByA_WhenANotLessThanZero_ShouldReturnNumbersArrayDivisibleByA(
            int a,
            int[] expectedArray)
        {
            int[] actualArray = LoopsHelper.NumbersArrayDivisibleByA(a);

            Assert.AreEqual(expectedArray, actualArray);
        }

        [TestCase(0)]
        [TestCase(-7)]
        public void NumbersArrayDivisibleByA_WhenANotLessThanZero_ShouldThrowArgumentException(
            int a)
        {
            try
            {
                LoopsHelper.NumbersArrayDivisibleByA(a);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The A must be greater than zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(12, 3)]
        [TestCase(20, 4)]
        public void NumbersSquerdLessThanA_WhenAisPositiveNuber_ShouldCalculateCountOfNumbersSquerdLessThanA(
            double a,
            double expectationResult)
        {
            double actualResult = LoopsHelper.NumbersSquerdLessThanA(a);

            Assert.AreEqual(expectationResult, actualResult);
        }

        [TestCase(-12)]
        public void NumbersSquerdLessThanA_WhenAisNotPositiveNumber_ShouldThrowArgumentException(
            double a)
        {
            try
            {
                LoopsHelper.NumbersSquerdLessThanA(a);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A should be greater then zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(150, 75)]
        [TestCase(200, 100)]

        public void TheLargestDividerr_WhenANotLessThanA_ShouldCalculateTheLargestDivider(
            int a,
            int expectationResult)
        {
            int actualResult = LoopsHelper.TheLargestDivider(a);

            Assert.AreEqual(expectationResult, actualResult);
        }

        [TestCase(-50)]
        [TestCase(0)]
        public void TheLargestDivider_WhenAIsLessThanA_ShouldThrowArgumentExpectation(
            int a)
        {
            try
            {
                LoopsHelper.TheLargestDivider(a);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A should be greater then zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(2, 15, 21)]
        public void NumbersSumFromAToBWhichDivisibleBySeven_WhenAAndBPassed_ShouldCalculateNumerSumFromAtoB(
            int a,
            int b,
            int expectationResult)
        {
            int actualResult = LoopsHelper.NumbersSumFromAToBWhichDivisibleBySeven(a, b);

            Assert.AreEqual(expectationResult, actualResult);
        }

        [TestCase(7, 13)]
        public void NthFibonacciNumbers_WhenNGreaterThanOne_ShouldPrintNthNumberFibonacci(
            int n,
            int expectationResult)
        {
            int actualResult = LoopsHelper.NthFibonacciNumbers(n);

            Assert.AreEqual(expectationResult, actualResult);
        }

        [TestCase(0)]
        [TestCase(1)]
        public void NthFibonacciNumbers_WhenNNotGreaterThanOne_ShouldThrowArgumentExeption(
            int n)
        {
            try
            {
                LoopsHelper.NthFibonacciNumbers(n);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("N should be greater than one!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(5, 10, 5)]
        public void GeneralDividerByEuclidAlgorithm_WhenAOrBNotEqualZero_ShouldCalculateGeneralDividerByEuclidAlgorithm(
            int a,
            int b,
            int expectationResult)
        {
            int actualResult = LoopsHelper.GeneralDividerByEuclidAlgorithm(a, b);

            Assert.AreEqual(expectationResult, actualResult);
        }

        [TestCase(0, 4)]
        public void GeneralDividerByEuclidAlgorithm_WhenAOrBEqualZero_ShouldThrowArgumentExeption(
            int a,
            int b)
        {
            try
            {
                LoopsHelper.GeneralDividerByEuclidAlgorithm(a, b);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A and B should be not equal to zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(27, 3)]
        public void CalculateNumberFromCubeByHalfDivisionMethod_WhenNGreaterThanZero_ShouldCalculateNumberFromCubeByHalfDivisionMethod(
            int a,
            double expectationResult)
        {
            double actualResult = LoopsHelper.CalculateNumberFromCubeByHalfDivisionMethod(a);

            Assert.AreEqual(expectationResult, actualResult);
        }

        [TestCase(0)]
        public void CalculateNumberFromCubeByHalfDivisionMethod_WhenNNotGreaterThanZero_ShouldThrowArgumentException(
            int a)
        {
            try
            {
                LoopsHelper.CalculateNumberFromCubeByHalfDivisionMethod(a);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A and B should be greater than zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(321, 2)]
        [TestCase(4443, 1)]
        public void CountOfOddNumbersInFigure_WhenFigureNotEqualtoZero_ShouldCalculateCountOfOddNumbersInFigure(
           int a,
           int expectationResult)
        {
            int actualResult = LoopsHelper.CountOfOddNumbersInFigure(a);

            Assert.AreEqual(expectationResult, actualResult);
        }

        [TestCase(0)]
        public void CountOfOddNumbersInFigure_WhenFigureEqualtoZero__ShouldThrowArgumentException(
            int a)
        {
            try
            {
                LoopsHelper.CountOfOddNumbersInFigure(a);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Tne figure should not be equal to zero", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(321, 123)]
        [TestCase(3400, 43)]
        public void NumberReserse_WhenNumberNotEqualtoZero_ShouldReturnNumberReserse(
            int a,
            int expectationResult)
        {
            int actualResult = LoopsHelper.NumberReserse(a);

            Assert.AreEqual(expectationResult, actualResult);
        }

        [TestCase(0)]
        public void NumberReserse_WhenNumberEqualtoZero__ShouldThrowArgumentException(
            int a)
        {
            try
            {
                LoopsHelper.NumberReserse(a);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Tne figure should not be equal to zero", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(30, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28 })]
        [TestCase(15, new int[] { 2, 4, 6, 8, 12, 14 })]
        public void EvenAndOddNumbersSum_WhenNumberNotLessThanZero_ShouldReturnNumbersArrayWhereNumbersEvenSumGreaterThanOddSum(
            int n,
            int[] expectationArray)
        {
            int[] actualArray = LoopsHelper.EvenAndOddNumbersSum(n);

            Assert.AreEqual(actualArray, expectationArray);
        }

        [TestCase(0)]
        [TestCase(-3)]
        public void EvenAndOddNumbersSum_WhenNumberIsLessThanZero__ShouldThrowArgumentException(
            int n)
        {
            try
            {
                LoopsHelper.EvenAndOddNumbersSum(n);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The N must be greater than zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(321, 144, true)]
        [TestCase(90, 144, false)]
        public void EqualNumbersInDigit_WhenNumberNotEqualtoZero_ShouldReturnEqualNumbersInDigitOrNot(
            int a,
            int b,
            bool expectationResult)
        {
            bool actualResult = LoopsHelper.EqualNumbersInDigit(a, b);

            Assert.AreEqual(expectationResult, actualResult);
        }
    }
}
