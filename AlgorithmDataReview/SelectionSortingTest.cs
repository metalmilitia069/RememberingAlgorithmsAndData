using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    class SelectionSortingTest
    {
        public static void SelectSort(int[] array)
        {
            for (int wallIndex = array.Length - 1; wallIndex > 0; wallIndex--)
            {
                int largestAt = 0;

                for (int i = 1; i <= wallIndex; i++)
                {
                    if (array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }
                }
                Swap(array, largestAt, wallIndex);
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
