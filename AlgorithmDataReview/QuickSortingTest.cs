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
                //Sort(low, j - 1);
                //Sort(j + 1, high);

                int i = Partition(low, high);
                Sort(low, i - 1);
                if (i < array.Length)
                {
                    Sort(i+1, high);
                }
                else
                {
                    Sort(i, high);
                }                
            }

            int Partition(int low, int high)
            {
                int i = low;
                int j = low;
                int pivot = array[low];

                for (j = low; j <= high; j++)
                {
                    if (array[j] < pivot)
                    {
                        i++;
                        Swap(array, i, j);
                    }
                }
                Swap(array, low, i);
                return i;

                //----------------//

                //int i = low;
                //int j = high + 1;

                //int pivot = array[low];

                //while (true)
                //{
                //    while (array[++i] < pivot)
                //    {
                //        if (i == high)
                //        {
                //            break;
                //        }
                //    }

                //    while (array[--j] > pivot)
                //    {
                //        if (j == low)
                //        {
                //            break;
                //        }
                //    }

                //    if (i >= j)
                //    {
                //        break;
                //    }

                //    Swap(array, i, j);
                //}
                //Swap(array, low, j);
                //return j;
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (array[i] == array[j])
            {
                return;
            }

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

}
