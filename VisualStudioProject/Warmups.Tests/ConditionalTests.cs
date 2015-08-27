using NUnit.Framework;
using NUnit.Framework.Constraints;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class ConditionalTests
    {
        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        public void AreWeInTroubleTest(bool aSmile, bool bSmile, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.AreWeInTrouble(aSmile, bSmile);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
        public void CanSleepIn(bool isWeekday, bool isVacation, bool expected)
        {
            //arrange
            Conditionals obj = new Conditionals();
            //act
            bool actual = obj.CanSleepIn(isWeekday, isVacation);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]
        public void SumDouble(int a, int b, int expected)
        {
            //arrange
            Conditionals obj = new Conditionals();
            //act
            int actual = obj.SumDouble(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        public void Diff21(int n, int expected)
        {
            //arrange
            Conditionals obj = new Conditionals();
            //act
            int actual = obj.Diff21(n);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
