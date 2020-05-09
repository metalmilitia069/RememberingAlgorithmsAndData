using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    class CircularQueueArrayBasedTest<T> : IEnumerable<T>
    {
        private T[] _queue;

        private int _head;
        private int _tail;
        public int count => _head <= _tail? _tail - _head : _tail - _head + _queue.Length;
        public bool isEmpty => count == 0;
        public int capacity => _queue.Length;

        public CircularQueueArrayBasedTest()
        {
            const int defaultCapacity = 4;
            _queue = new T[defaultCapacity];
        }

        public CircularQueueArrayBasedTest(int capacity)
        {
            _queue = new T[capacity]; 
        }

        public void Enqueue(T item)
        {
            if (count == _queue.Length - 1)
            {
                //int countPriorResize = count;
                T[] tempArray = new T[2 * _queue.Length];

                Array.Copy(_queue, _head, tempArray, 0, _queue.Length - _head);
                Array.Copy(_queue, 0, tempArray, _queue.Length - _head, _tail);

                _queue = tempArray;

                _head = 0;
                //_tail = countPriorResize;
                _tail = count;
            }
            _queue[_tail] = item;

            if (_tail < _queue.Length -1)
            {
                _tail++;
            }
            else
            {
                _tail = 0;
            }
        }

        public void Dequeue()
        {
            if (isEmpty)
            {
                throw new InvalidOperationException("This Queue is Empty!!!!");
            }

            _queue[_head++] = default(T);

            if (isEmpty)
            {
                _head = _tail = 0;
            }
            else if (_head == _queue.Length)
            {
                _head = 0;
            }
        }

        public T Peek()
        {
            if (isEmpty)
            {
                throw new InvalidOperationException("This Queue is Empty!!!!");
            }

            return _queue[_head];
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (_head <= _tail)
            {
                for (int i = _head; i < _tail; i++)
                {
                    yield return _queue[i];
                }
            }
            else
            {
                for (int i = _head; i < _queue.Length; i++)
                {
                    yield return _queue[i];
                }

                for (int i = 0; i < _tail; i++)
                {
                    yield return _queue[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
