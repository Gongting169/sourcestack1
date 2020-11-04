using CSharplearn;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void GetMax()
        {
          int max = NunitTestMethod.GetMax(new int[] { 2, 32, -1, 5, 96, 8, 65, 101 });
            Assert.AreEqual(101, max);
        }
        [Test]
        public void GetPrime()
        {
            int prime = NunitTestMethod.GetPrime(0,100);
        }
    }
}