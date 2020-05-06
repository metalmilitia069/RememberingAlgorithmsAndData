using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    public class DoublyLinkedListTest<T>
    {
        public DoublyNodeTest<T> head { get; set; }
        public DoublyNodeTest<T> tail { get; set; }

        public int count { get; set; }
        public bool IsEmpty => count == 0;

        public void AddFirst(T value)
        {
            AddFirst(new DoublyNodeTest<T>(value));
        }

        public void AddFirst(DoublyNodeTest<T> doublyNode)
        {
            DoublyNodeTest<T> temp = head;
            head = doublyNode;
            head.next = temp;

            if (IsEmpty)
            {
                tail = head;
            }
            else
            {                
                temp.prev = head;
            }
            count++;
        }

        public void AddLast(T value)
        {
            AddLast(new DoublyNodeTest<T>(value));
        }

        public void AddLast(DoublyNodeTest<T> doublyNode)
        {
            if (IsEmpty)
            {
                head = doublyNode;               
            }
            else
            {
                tail.next = doublyNode;
                doublyNode.prev = tail;                
            }
            tail = doublyNode;
            count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("The List is Empty!!!!");
            }

            head = head.next;
            count--;

            if (IsEmpty)
            {
                tail = null;
            }
            else
            {
                head.prev = null;
            }
        }

        public void RemoveLast()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("The List is Empty!!!");
            }

            if (count == 1)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail.prev.next = null;
                tail = tail.prev;
            }
            count--;
        }
    }
}
