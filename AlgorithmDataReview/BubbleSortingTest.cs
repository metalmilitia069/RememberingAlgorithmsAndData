using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    class BubbleSortingTest
    {

        public static void BubbleSort(int[] array)
        {
            for (int wallIndex = array.Length - 1; wallIndex > 0; wallIndex--)
            {
                for (int i = 0; i < wallIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
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
