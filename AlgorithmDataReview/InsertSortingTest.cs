using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    class InsertSortingTest
    {
        public static void InsertSorting(int[] array)
        {
            for (int wallIndex = 1; wallIndex < array.Length; wallIndex++)
            {
                int temp = array[wallIndex];
                int i = 0;
                for (i = wallIndex; i > 0 && array[i - 1] > temp; i--)
                {
                    array[i] = array[i - 1];
                }
                array[i] = temp;
            }
        }
    }
}
