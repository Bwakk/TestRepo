using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PingPongPairing.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void TestArea()
        {
            Rectangle testRect = new Rectangle(10, 10);
            double area = testRect.getArea();
            Assert.AreEqual(100, area);
        }
        [TestMethod]
        public void TestPerimeter()
        {
            Rectangle testRect = new Rectangle(10, 10);
            double perimeter = testRect.getPerimeter();
            Assert.AreEqual(40, perimeter);
        }
    }
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void TestArea()
        {
            Circle testCircle = new Circle(10);
            double area = testCircle.getArea();
            Assert.AreEqual(314, area);
        }
        [TestMethod]
        public void TestPerimeter()
        {
            Circle testCircle = new Circle(10);
            double perimeter = testCircle.getPerimeter();
            Assert.AreEqual((20*3.14), perimeter);
        }
    }

    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void TestFizzBuzz()
        {
            FizzBuzz testFizz = new FizzBuzz();
            string answer = testFizz.Answer(15);
            Assert.AreEqual("fizzbuzz", answer);
        }
        [TestMethod]
        public void TestFizz()
        {
            FizzBuzz testFizz = new FizzBuzz();
            string answer = testFizz.Answer(9);
            Assert.AreEqual("fizz", answer);
        }

        [TestMethod]
        public void TestBuzz()
        {
            FizzBuzz testFizz = new FizzBuzz();
            string answer = testFizz.Answer(10);
            Assert.AreEqual("buzz", answer);
        }
        [TestMethod]
        public void TestFizzBuzzNeither()
        {
            FizzBuzz testFizz = new FizzBuzz();
            string answer = testFizz.Answer(4);
            Assert.AreEqual("4", answer);
        }
    }
    [TestClass]
    public class TeaPartyTests
    {
        [TestMethod]
        public void TeaPartyReturnMs()
        {
            TeaParty testTeaParty = new TeaParty();
            string msg = testTeaParty.welcome("Schmidt", true, false);
            Assert.AreEqual("Ms. Schmidt", msg);
        }

        [TestMethod]
        public void TeaPartyReturnSir()
        {
            TeaParty testTeaParty = new TeaParty();
            string msg = testTeaParty.welcome("Schmidt", false, true);
            Assert.AreEqual("Sir Schmidt", msg);
        }

        [TestMethod]
        public void TeaPartyReturnMr()
        {
            TeaParty testTeaParty = new TeaParty();
            string msg = testTeaParty.welcome("Schmidt", false, false);
            Assert.AreEqual("Mr. Schmidt", msg);
        }
    }
    [TestClass]
    public class CountdownTests
    {
        [TestMethod]
        public void CountdownTest()
        {
            Countdown testCountdown = new Countdown();
            int[] countDown = testCountdown.countdown(4);
            int[] assertArray = new int[] { 4, 3, 2, 1, 0 };
            CollectionAssert.AreEqual(assertArray, countDown);
        }
    }
}
