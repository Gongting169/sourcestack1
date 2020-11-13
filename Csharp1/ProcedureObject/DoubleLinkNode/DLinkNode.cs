using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.ProcedureObject.DoubleLinkNode
{
    public class DLinkNode
    {
        public DLinkNode Previous { get; set; }
        public DLinkNode Next { get; set; }

        public void AddBefore(DLinkNode node)
        {
            if (this.Previous != null)
            {
                this.Previous.Next = node;
                node.Previous = this.Previous;

            }
            this.Previous = node;
            node.Next = this;

        }
        public void InsertAfter(DLinkNode node1)
        {

        }
        public void InsertBefore(DLinkNode node)
        {
            if (this.Previous != null)
            {
                node.Previous = this.Previous;
                this.Previous.Next = node;
            }
            node.Next = this;
            this.Previous = node;
        }
        public void Delete(DLinkNode node3)
        {
            DLinkNode oldPre = this.Previous;
            DLinkNode oldNex = this.Next;
            if (oldPre != null)
            {
                oldPre.Next = this.Next;

            }
            if (oldNex != null)
            {
                oldNex.Previous = this.Previous;
            }
            this.Previous = this.Next = null;
        }
        public void Swap(DLinkNode node4)
        {

        }





    }

}
