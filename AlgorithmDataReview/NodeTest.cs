using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    public class NodeTest<T>
    {
        public T value { get; set; }
        public NodeTest<T> next { get; set; }

        public NodeTest(T val)
        {
            value = val;
        }

        public static void PrintLinkedList(NodeTest<T> node)
        {
            int counter = 1;
            while (node != null)
            {
                Console.WriteLine($"Node Number# { counter} is Equal to: {node.value}");
                node = node.next;
                counter++;
            }
        }
    }


}
