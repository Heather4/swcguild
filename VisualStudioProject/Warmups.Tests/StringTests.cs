using System.Net.Http.Headers;
using NUnit.Framework;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class StringTests
    { 
        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("X", "Hello X!")]
        public void SayHiTest(string name, string expected)
        {
            // arrange
            Strings obj = new Strings();

            // act
            string actual = obj.SayHi(name);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase("Hi", "Bye", "HiByeByeHi")]
        [TestCase("Yo", "Alice", "YoAliceAliceYo")]
        [TestCase("What", "Up", "WhatUpUpWhat")]
        public void AbbaTest(string a, string b, string expectedResult)
        {
           //arrange
            Strings obj = new Strings();

            //act
            string actual = obj.Abba(a, b);

            //assert
            Assert.AreEqual(expectedResult, actual);
         }

        [TestCase("i", "Yay", "<i>Yay</i>")]
        [TestCase("i", "Hello", "<i>Hello</i>")]
        [TestCase("cite", "Yay", "<cite>Yay</cite>")]
        public void MakeTags(string tag, string content, string expectedResult)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.MakeTags(tag, content);
            //assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "WooHoo", "<<WooHoo>>")]
        [TestCase("[[]]", "word", "[[word]]")]
        public void InsertWord(string container, string word, string expectedResult)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.InsertWord(container, word);
            //assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", "lololo")]
        [TestCase("ab", "ababab")]
        [TestCase("Hi", "HiHiHi")]
        public void MultipleEndings(string str, string expectedResult)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.MultipleEndings(str);
            //assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("WooHoo", "Woo")]
        [TestCase("HelloThere", "Hello")]
        [TestCase("abcdef", "abc")]
        public void FirstHalf(string str, string expected)
        { 
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.FirstHalf(str);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "ell")]
        [TestCase("java", "av")]
        [TestCase("coding", "odin")]
        public void TrimOne(string str, string expectedResult)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.TrimOne(str);
            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", "hi", "hiHellohi")]
        [TestCase("hi", "Hello", "hiHellohi")]
        [TestCase("aaa", "b", "baaab")]
        public void LongInMiddle(string a, string b, string expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.LongInMiddle(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "lloHe")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void Rotateleft2(string str, string expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.Rotateleft2(str);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "loHel")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotateRight2(string str, string expected)
        {
            //arrange
            Strings obj = new Strings(); 
            //act
            string actual = obj.Rotateright2(str);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", true, "H")]
        [TestCase("Hello", false, "o")]
        [TestCase("oh", true, "o")]
        public void TakeOne(string str, bool fromFront, string expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.TakeOne(str, fromFront);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("string", "ri")]
        [TestCase("code", "od")]
        [TestCase("Practice", "ct")]
        public void MiddleTwo(string str, string expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.MiddleTwo(str);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("oddly", true)]
        [TestCase("y", false)]
        [TestCase("oddy", false)]

        public void EndsWithLy(string str, bool expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            bool actual = obj.EndsWithLy(str);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", 2, "Helo")]
        [TestCase("Chocolate", 3, "Choate")]
        [TestCase("Chocolate", 1, "Ce")]
        public void FrontAndBack(string str, int n, string expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.FrontAndBack(str, n);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("java", 0, "ja")]
        [TestCase("java", 2, "va")]
        [TestCase("java", 3, "ja")]
        public void TakeTwoFromPosition(string str, int n, string expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.TakeTwoFromPosition(str, n);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("badxx", true)]
        [TestCase("xbadxx", true)]
        [TestCase("xxbadxx", false)]

        public void HasBad(string str, bool expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            bool actual = obj.HasBad(str);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("hello", "he")]
        [TestCase("hi", "hi")]
        [TestCase("h", "h@")]
        public void AtFirst(string str, string expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.AtFirst(str);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("last", "chars", "ls")]
        [TestCase("yo", "mama", "ya")]
        [TestCase("hi", "", "h@")]
        public void LastChars(string a, string b, string expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.LastChars(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("abc", "cat", "abcat")]
        [TestCase("dog", "cat", "dogcat")]
        [TestCase("abc", "", "abc")]
        public void ConCat(string a, string b, string expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.ConCat(a, b);
            //assert
            Assert.AreEqual(expected, actual);
            }

        [TestCase("coding", "codign")]
        [TestCase("cat", "cta")]
        [TestCase("ab", "ba")]
        public void SwapLast(string str, string expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.SwapLast(str);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("edited", true)]
        [TestCase("edit", false)]
        [TestCase("ed", true)]
        public void FrontAgain(string str, bool expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            bool actual = obj.FrontAgain(str);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "Hi", "loHi")]
        [TestCase("Hello", "java", "ellojava")]
        [TestCase("java", "Hello", "javaello")]
        public void MinCat(string a, string b, string expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.MinCat(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "llo")]
        [TestCase("away", "aay")]
        [TestCase("abed", "abed")]
        public void TweakFront(string str, string expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.TweakFront(str);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("xHix", "Hi")]
        [TestCase("xHi", "Hi")]
        [TestCase("Hxix", "Hxi")]
        public void StripX(string str, string expected)
        {
            //arrange
            Strings obj = new Strings();
            //act
            string actual = obj.StripX(str);
            //assert
            Assert.AreEqual(expected, actual);
        }


    }
    
}
