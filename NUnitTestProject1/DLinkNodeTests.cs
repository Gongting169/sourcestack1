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
            //1 2 3   原来的顺序
            //  1  [3]  2
            node2.AddBefore(node3);
            Assert.IsNull(node1.Previous);
            Assert.AreEqual(node3, node1.Next);
            Assert.AreEqual(node1, node3.Previous);
            Assert.AreEqual(node2, node3.Next);
            Assert.AreEqual(node3, node2.Previous);

            // [2]  1  3
            node1.AddBefore(node2);
            Assert.IsNull(node2.Previous);
            Assert.AreEqual(node1, node2.Next);
            Assert.AreEqual(node2, node1.Previous);
            Assert.AreEqual(node3, node1.Next);
            Assert.AreEqual(node1, node3.Previous);

            // [3]  1  2
            node1.AddBefore(node3);
            Assert.IsNull(node3.Previous);
            Assert.AreEqual(node1, node3.Next);
            Assert.AreEqual(node3, node1.Previous);
            Assert.AreEqual(node2, node1.Next);
            Assert.AreEqual(node1, node2.Previous);
        }

        [Test]
        public void InsertAfterTest()
        {
            // 2  3   4 原来的顺序
            // 2 [4]  3
            node2.InsertAfter(node4);
            Assert.AreEqual(node4, node2.Next);
            Assert.AreEqual(node2, node4.Previous);
            Assert.AreEqual(node3, node4.Next);
            Assert.AreEqual(node4, node3.Previous);

            //3 4 [2]
            node4.InsertAfter(node2);
            Assert.AreEqual(node4, node3.Next);
            Assert.AreEqual(node3, node4.Previous);
            Assert.AreEqual(node2, node4.Next);
            Assert.AreEqual(node4, node2.Previous);

            //3 [2]  4
            Assert.AreEqual(node2, node3.Next);
            Assert.AreEqual(node3, node2.Previous);
            Assert.AreEqual(node4, node2.Next);
            Assert.AreEqual(node2, node4);
        }
        [Test]
        public void InsertBefore()
        {
            // 1 2  3 原来的顺序
            //[3]  1 2
            node1.InsertBefore(node3);
            Assert.IsNull(node3.Previous);
            Assert.AreEqual(node1, node3.Next);
            Assert.AreEqual(node3, node1.Previous);
            Assert.AreEqual(node2, node1.Next);
            Assert.AreEqual(node1, node2.Previous);

            //1 [3]  2
            node2.InsertBefore(node3);
            Assert.IsNull(node1.Previous);
            Assert.AreEqual(node3, node1.Next);
            Assert.AreEqual(node1, node3.Previous);
            Assert.AreEqual(node2, node3.Next);
            Assert.AreEqual(node3, node2.Previous);

            // 2 [1]  3
            node3.InsertBefore(node1);
            Assert.IsNull(node2.Previous);
            Assert.AreEqual(node1, node2.Next);
            Assert.AreEqual(node2, node1.Previous);
            Assert.AreEqual(node3, node1.Next);
            Assert.AreEqual(node1, node3.Previous);
        }
        public void Delete()
        {
            // 1 2 3  原来的顺序
            //[1] 2 3 
            node1.Delete(node1);
            Assert.IsNull(node2.Previous);
            Assert.AreEqual(node3, node2.Next);
            Assert.AreEqual(node2, node3.Previous);

            // 1  [2] 3 
            node2.Delete(node2);
            Assert.IsNull(node1.Previous);
            Assert.AreEqual(node3, node1.Next);
            Assert.AreEqual(node1, node3.Previous);

            // 1  2 [3]
            node3.Delete(node3);
            Assert.IsNull(node1.Previous);
            Assert.AreEqual(node2, node1.Next);
            Assert.AreEqual(node1, node2.Previous);

            // 只有一个
            node2.Delete(node2);
            node3.Delete(node3);
            Assert.IsNull(node1.Previous);
            Assert.IsNull(node1.Next);
        }
        public void Swap()
        {
            // 1 2 3 4 5 
            // [1] 2 3 4 [5]  1和5交换
            node5.Swap(node1);
            Assert.IsNull(node5.Previous);
            Assert.AreEqual(node2, node5.Next);
            Assert.AreEqual(node5, node2.Previous);
            Assert.AreEqual(node3, node2.Next);
            Assert.AreEqual(node2, node3.Previous);
            Assert.AreEqual(node4, node3.Next);
            Assert.AreEqual(node3, node4.Previous);
            Assert.AreEqual(node1, node4.Next);
            Assert.AreEqual(node4, node1.Previous);
            Assert.IsNull(node1.Next);

            // [2] [1] 3 4 5   1和2交换
            node2.Swap(node1);
            Assert.IsNull(node2.Previous);
            Assert.AreEqual(node1, node2.Next);
            Assert.AreEqual(node2, node1.Previous);
            Assert.AreEqual(node3, node1.Next);
            Assert.AreEqual(node1, node3.Previous);
            Assert.AreEqual(node4, node3.Next);
            Assert.AreEqual(node3, node4.Previous);
            Assert.AreEqual(node5, node4.Next);
            Assert.AreEqual(node4, node5.Previous);
            Assert.IsNull(node5.Next);

            // [3] 2 [1] 4 5   1和3交换
            node3.Swap(node1);
            Assert.IsNull(node3.Previous);
            Assert.AreEqual(node2, node3.Next);
            Assert.AreEqual(node3, node2.Previous);
            Assert.AreEqual(node1, node2.Next);
            Assert.AreEqual(node2, node1.Previous);
            Assert.AreEqual(node4, node1.Next);
            Assert.AreEqual(node1, node4.Previous);
            Assert.AreEqual(node5, node4.Next);
            Assert.AreEqual(node4, node5.Previous);
            Assert.IsNull(node5.Next);

            // 1 [4] 3 [2] 5   2和4交换






        }

    }
}
