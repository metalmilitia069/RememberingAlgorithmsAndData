using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    public class DoublyNodeTest<T>
    {
        public DoublyNodeTest<T> next { get; set; }
        public DoublyNodeTest<T> prev { get; set; }

        public T value { get; set; }

        public DoublyNodeTest(T val)
        {
            value = val;
        }
    }
}
