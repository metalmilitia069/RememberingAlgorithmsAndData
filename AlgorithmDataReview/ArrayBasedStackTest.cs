using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    class ArrayBasedStackTest<T> : IEnumerable<T>
    {
        private T[] _items;

        public int count { get; set; }
        public bool isEmpty => count == 0;

        public ArrayBasedStackTest()
        {
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];
        }

        public ArrayBasedStackTest(int capacity)
        {
            _items = new T[capacity];
        }

        public T Peek()
        {
            if (isEmpty)
            {
                throw new InvalidOperationException("The Stack is Empty!!!!");
            }

            return _items[count - 1];
        }

        public void Push(T item)
        {
            if (_items.Length == count)
            {
                T[] largerArray = new T[count * 2];
                Array.Copy(_items, largerArray, count);

                _items = largerArray;
            }
            _items[count++] = item;
        }

        public void Pop()
        {
            if (isEmpty)
            {
                throw new InvalidOperationException("This Stack is Empty!!!!");
            }

            _items[--count] = default(T);
        }



        public IEnumerator<T> GetEnumerator()
        {
            for (int i = count-1; i >= 0; i--)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
