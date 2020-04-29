using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    class QuickSortingTest
    {
        public static void QuickSort(int[] array)
        {
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low)
                {
                    return;
                }

                //int j = Partition(low, high);
                Sort(low, j - 1);
                Sort(j + 1, high);
            }

            //int Partition(int low, int high)
            //{

            //}
        }
    }
}
