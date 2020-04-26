using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDataStudying
{
    class InsertionSortTest
    {
        public static void InsertionSort(int[] array)
        {
            for (int wallIndex = 1; wallIndex < array.Length; wallIndex++)
            {
                int currentUnsorted = array[wallIndex];
            }
        }


        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }


}
