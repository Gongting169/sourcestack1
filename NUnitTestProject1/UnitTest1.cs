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
            Assert.AreEqual(101, NunitTestMethod.GetMax(new int[] { 2, 32, -1, 5, 96, 8, 65, 101 }));
        }

      
    }
}