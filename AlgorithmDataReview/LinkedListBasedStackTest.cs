using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    class LinkedListBasedStackTest<T> : IEnumerable<T>
    {
        private readonly SinglyLinkedListTest<T> _list = new SinglyLinkedListTest<T>();

        public int count { get; set; }
        public bool isEmpty => count == 0;
        
        public T Peek()
        {
            if (isEmpty)
            {
                throw new InvalidOperationException("The Stack is Empty!!!!");
            }

            return _list.head.value;
        }

        public void Pop()
        {
            if (isEmpty)
            {
                throw new InvalidOperationException("The Stack is Empty!!!!");
            }
            _list.RemoveFirst();
            count--;
        }

        public void Push(T item)
        {
            _list.AddFirst(item);
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
