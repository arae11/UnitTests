using NUnit.Framework;
using TestFirstExercises;

namespace TestFirstExercises_Tests
{
    public class OperatorTests
    {
        [TestCase(5, 2, true)]
        [TestCase(2, 5, false)]
        [TestCase(5, 5, true)]
        [TestCase(10, 10, true)]
        [TestCase(16, 99, false)]
        [TestCase(3, 7, true)]
        public void GivenTwoNumbersXY_GreaterEqual_ReturnsWhetherXIsGreatorOrEqualToY(int x, int y, bool expResult)
        {
            Assert.That(Methods.GreaterEqual(x, y), Is.EqualTo(expResult));
        }

        [TestCase(0, 10.429)]
        [TestCase(10, 24.714)]
        public void GivenNumber_BODMAS_ReturnsTheExpectedResult(int num, double expResult)
        {
            Assert.That(Methods.BODMAS(num), Is.EqualTo(expResult));
        }

        [TestCase(-2)]
        [TestCase(0)]
        [TestCase(2)]
        [TestCase(348)]
        public void WhenTheArgumentIsEven_EvenOdd_ReturnsTrue(int x)
        {
            var result = Methods.EvenOdd(x);
            Assert.IsTrue(result);
        }

        [TestCase(-3)]
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(347)]
        public void WhenTheArgumentIsOdd_EvenOdd_ReturnsFalse(int x)
        {
            var result = Methods.EvenOdd(x);
            Assert.IsFalse(result);
        }

        [TestCase(-3)]
        public void GivenANegativeParameter_SumEvenFive_ReturnsZero(int max)
        {
            Assert.That(Methods.SumEvenFive(max), Is.EqualTo(expResult));
        }

        [TestCase(0)]
        public void GivenAParameterOfZero_SumEvenFive_ReturnsZero(int max)
        {
            Assert.That(Methods.SumEvenFive(max), Is.EqualTo(expResult));
        }

        [TestCase(5)]
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(10, 35)]
        [TestCase(22, 152)]
        [TestCase(9, 25)]
        public void SumEvenFive_ReturnsExpectedResult(int max)
        {
            Assert.That(Methods.SumEvenFive(max), Is.EqualTo(expResult));
        }

        [TestCase(0)]
        public void GivenAnyStringExceptPassword_CheckInput_ReturnsFalse(string input)
        {
            Assert.That(Methods.SumEvenFive(max), Is.EqualTo(expResult));
        }
    }
}
