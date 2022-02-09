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
        public void TestMultiply(double a, double b, double expectedsum)
        {
            double sum = uut.Multiply(a, b);
            Assert.That(sum, Is.EqualTo(expectedsum));
        }

        [TestCase(5, 2, 25)]
        public void TestPower(double a, double b, double expectedsum)
        {
            double sum = uut.Power(a, b);
            Assert.That(sum, Is.EqualTo(expectedsum));
        }
        
        [TestCase(81,9)]
        public void TestSquareroot(double d, double expectedsum)
        {
            double sum = uut.Squareroot(d);
            Assert.That(sum, Is.EqualTo(expectedsum));
        }
    }
}