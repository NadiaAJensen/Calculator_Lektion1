using System;
using Calculator_Lektion1;
using NUnit.Framework;

namespace Test_Program
{
    public class Tests
    {
        public Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [TestCase(5,10,15)]
        [TestCase(3,25,28)]
        [TestCase(47.6,4.8,52.4)]
        public void TestAdd(double a, double b, double expectedsum)
        {
            double sum = uut.Add(a, b);
            Assert.That(sum, Is.EqualTo(expectedsum));
        }

        [TestCase(30, 10, 20)]
        [TestCase(20, 10, 10)]
        [TestCase(10, 10, 0)]
        [TestCase(0, 10, -10)]
        [TestCase(50, 10, 40)]
        public void TestSubtract(double a, double b, double expectedsum)
        {
            double sum = uut.Subract(a, b);
            Assert.That(sum, Is.EqualTo(expectedsum));
        }

        [TestCase(5, 10, 50)]
        [TestCase(8,8,64)]
        [TestCase(9,3,27)]
        public void TestMultiply(double a, double b, double expectedsum)
        {
            double sum = uut.Multiply(a, b);
            Assert.That(sum, Is.EqualTo(expectedsum));
        }

        [TestCase(5, 2, 25)]
        [TestCase(6,6,46656)]
        [TestCase(8,4,4096)]
        public void TestPower(double a, double b, double expectedsum)
        {
            double sum = uut.Power(a, b);
            Assert.That(sum, Is.EqualTo(expectedsum));
        }
        
        [TestCase(64,8)]
        [TestCase(81,9)]
        [TestCase(25,5)]
        public void TestSquareroot(double d, double expectedsum)
        {
            double sum = uut.Squareroot(d);
            Assert.That(sum, Is.EqualTo(expectedsum));
        }

        [TestCase(-64,8)]
        [TestCase(-81, 9)]
        [TestCase(-25,5)]
        public void TestSquarerootWithException(double d, double expectedsum)
        {
            Assert.That(()=>uut.Squareroot(d), Throws.TypeOf<Exception>().With.Message.EqualTo("Will not give a real number"));
            
        }

        [TestCase(100,10,10)]
        [TestCase(10, 2, 5)]
        [TestCase(50, 5, 10)]
        public void TestDivideWithSucces(double a, double b, double expectedsum)
        {
            double sum = uut.Divide(a, b);
            Assert.That(sum, Is.EqualTo(expectedsum));
        }

        [TestCase(76, 0, 10.9)]
        [TestCase(60, 0, 70)]
        [TestCase(50, 0, 10)]
        public void TestDivisionWithZero(double a, double b, double expectedsum)
        {
            Assert.That(() => uut.Divide(a,b),Throws.TypeOf<Exception>().With.Message.EqualTo("Not allowed to divide by 0"));
        }

        [TestCase(80, 6, 0)]
        [TestCase(7, 9.6, 0)]
        [TestCase(3.4, 8.6, 0)]
        public void TestClearSum(double a, double b, double expectedsum)
        {
            uut.Multiply(a, b);
            uut.ClearSum();
            Assert.That(uut.Sum, Is.EqualTo(expectedsum));
        }


    }
}