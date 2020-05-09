using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    public class QueueBasedOnLinkedList<T> : IEnumerable<T>
    {
        private readonly SinglyLinkedListTest<T> _list = new SinglyLinkedListTest<T>();

        public int count => _list.Count;
        public bool isEmpty => count == 0;

        public void Enqueue(T item)
        {
            _list.AddLast(item);
        }

        public void Dequeue()
        {
            if (isEmpty)
            {
                throw new InvalidOperationException("The Queue is Empty!!!!");
            }
            _list.RemoveFirst();
        }

        public T Peek()
        {
            if (isEmpty)
            {
                throw new InvalidOperationException("The Queue is Empty!!!!");
            }

            return _list.head.value;
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
