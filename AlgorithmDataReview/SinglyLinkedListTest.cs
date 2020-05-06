using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    class SinglyLinkedListTest<T> : IEnumerable<T>
    {
        public NodeTest<T> head { get; private set; }
        public NodeTest<T> tail { get; private set; }

        public int Count { get; private set; }

        private bool isEmpty => Count == 0;

        public void AddFirst(T value)
        {
            AddFirst(new NodeTest<T>(value));
        }

        private void AddFirst(NodeTest<T> nodeTest)
        {
            NodeTest<T> temp = head;
            head = nodeTest;
            head.next = temp;

            Count++;

            if (Count == 1)
            {
                tail = head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new NodeTest<T>(value));
        }

        private void AddLast(NodeTest<T> nodeTest)
        {
            if (isEmpty)
            {
                head = nodeTest;                
            }
            else
            {
                tail.next = nodeTest;                
            }
            tail = nodeTest;
            Count++;
        }

        public void RemoveFirst()
        {
            if (isEmpty)
            {
                throw new InvalidOperationException("The List is Empty!!!");
            }

            head = head.next;

            if (Count == 1)
            {
                tail = null;
            }

            Count--;
        }

        public void RemoveLast()
        {
            if (isEmpty)
            {
                throw new InvalidOperationException("The List is Empty!!!");
            }

            if (Count == 1)
            {
                head = tail = null;
            }
            else
            {
                var current = head;
                while (current.next != tail)
                {
                    current = current.next;
                }

                current.next = null;
                tail = current;
            }
            Count--;
        }

        public void PrintList()
        {
            if (head != null)
            {
                var current = head;
                while (current != null)
                {
                    Console.WriteLine(current.value);
                    current = current.next;
                }
                Console.WriteLine();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            NodeTest<T> current = head;
            while (current != null)
            {
                yield return current.value;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
