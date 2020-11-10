using CSharplearn;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    public class DLinkNodeTests
    {
        public DLinkNode node1, node2, node3, node4, node5;
        [SetUp]
        public void Setup()
        {
            DLinkNode node1 = new DLinkNode();
            DLinkNode node2 = new DLinkNode();
            DLinkNode node3 = new DLinkNode();
            DLinkNode node4 = new DLinkNode();
            DLinkNode node5 = new DLinkNode();
            node1.Next = node2;
            node2.Previous = node1;

            node2.Next = node3;
            node3.Previous = node2;

            node3.Next = node4;
            node4.Previous = node3;

            node4.Next = node5;
            node5.Previous = node4;

        }

        [Test]
        public void AddBeforeTest()
        {
            //  1  [2] 3
            node3.AddBefore(node2);
            Assert.IsNull(node1.Previous);
            Assert.AreEqual(node2, node1.Next);
            Assert.AreEqual(node1, node2.Previous);
            Assert.AreEqual(node3, node2.Next);
            Assert.AreEqual(node2, node3.Previous);

            // [2]  1  3
            node1.AddBefore(node2);
            Assert.IsNull(node2.Previous);
            Assert.AreEqual(node1, node2.Next);
            Assert.AreEqual(node2, node1.Previous);
            Assert.AreEqual(node3, node1.Next);
            Assert.AreEqual(node1, node3.Previous);

            // 
            node5.AddBefore(node2);
            Assert.AreEqual(node2 ,node4.Next); 
            Assert.AreEqual(node4 ,node2.Previous);
            Assert.AreEqual(node5 ,node2.Next);
            Assert.AreEqual(node2 ,node5.Previous);
            Assert.IsNull(node5.Next);
        }

        [Test]
        public void InsertAfterTest()
        {

        }

    }
}
