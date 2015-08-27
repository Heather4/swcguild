using NUnit.Framework;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class LoopTests
    {
        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        public void StringTimesTest(string str, int n, string expected)
        {
            // arrange
            Loops obj = new Loops();

            // act
            string actual = obj.StringTimes(str, n);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Chocolate", 2,"ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]
        public void FrontTimes(string str, int n, string expected)
        {
            //arrange
            Loops obj = new Loops();
            //act
            string actual = obj.FrontTimes(str, n);
            //assert
            Assert.AreEqual(expected,actual);
        }

        [TestCase("abcxx", 1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]
        public void CountXX(string str, int expected)
        {
            //arrange
            Loops obj = new Loops();
            //act
            int actual = obj.CountXX(str);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
