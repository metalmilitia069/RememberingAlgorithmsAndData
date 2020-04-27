using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arromba = { -5, -7, -2, -7, -9, 1, 5, 7, 2, 5, 3, 1, 4, 7, 9, 8, 7, 4, 0 };

            //BubbleSortingTest.BubbleSort(arromba);
            SelectionSortingTest.SelectSort(arromba);
            //InsertSortingTest.InsertSorting(arromba);


            foreach (var item in arromba)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
