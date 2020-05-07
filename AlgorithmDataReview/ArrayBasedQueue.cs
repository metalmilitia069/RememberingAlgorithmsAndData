using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    class ArrayBasedQueue<T> : IEnumerable<T>
    {
        private T[] _queue;
        private int _head;
        private int _tail;

        public int count => _tail - _head;
        public bool isEmpty => count == 0;
        public int capacity => _queue.Length;        

        public ArrayBasedQueue()
        {
            const int defaultCapacity = 4;
            _queue = new T[defaultCapacity];
        }

        public ArrayBasedQueue(int capacity)
        {
            _queue = new T[capacity];
        }

        public void Enqueue(T item)
        {
            if (_queue.Length == _tail)
            {
                T[] largerArray = new T[count * 2];
                Array.Copy(_queue, largerArray, count);
                _queue = largerArray;
            }
            _queue[_tail++] = item;
        }

        public void Dequeue()
        {
            if (isEmpty)
            {
                throw new InvalidOperationException("The Queue is Empty!!!!");
            }

            _queue[_head++] = default(T);

            if (isEmpty)
            {
                _head = _tail = 0;
            }
        }

        public T Peek()
        {
            if (isEmpty)
            {
                throw new InvalidOperationException("The Queue is Empty!!!!");
            }

            return _queue[_head];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _head; i < _tail; i++)
            {
                yield return _queue[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
