using CSharplearn;
using CSharplearn.ProcedureObject.DoubleLinkNode;
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
            Assert.AreEqual(196, NunitTestMethod.GetMax(new int[] { 2, 32, -1, 5, 196, 8, 65, 10 }));
            Assert.AreEqual(96, NunitTestMethod.GetMax(new int[] { 2, 32, -1, 5, 96, 8, 65, 10 }));
            Assert.AreEqual(65, NunitTestMethod.GetMax(new int[] { 2, 32, -1, 5, 6, 8, 65, 10 }));
            Assert.AreEqual(88, NunitTestMethod.GetMax(new int[] { 2, 32, -1, 5, 9, 88, 65, 10 }));
        }


    }
}