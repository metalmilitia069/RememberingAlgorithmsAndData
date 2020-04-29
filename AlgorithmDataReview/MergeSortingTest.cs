using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    class MergeSortingTest
    {
        public static void MergeSort(int[] array)
        {
            int[] auxiliaryArray = new int[array.Length];
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (low >= high)
                {
                    return;
                }

                int mid = (low + high) / 2;

                Sort(low, mid);
                Sort(mid + 1, high);
                Merge(low, mid, high);
            }

            void Merge(int low, int mid, int high)
            {
                Array.Copy(array, low, auxiliaryArray, low, (high - low) + 1);

                int i = low;
                int j = mid +1;
                int k = low;

                while (i <= mid && j <= high)
                {
                    if (auxiliaryArray[i] <= auxiliaryArray[j])
                    {
                        array[k] = auxiliaryArray[i++];
                    }
                    else
                    {
                        array[k] = auxiliaryArray[j++];
                    }
                    k++;
                }

                while (i <= mid)
                {
                    array[k] = auxiliaryArray[i++];
                    k++;
                }
            }

        }
        #region OtherSolution
        //public static void MergeSort(int[] array)
        //{
        //    int[] auxiliaryArray = new int[array.Length];
        //    Sort(0, array.Length - 1);
        //    //Sort(4, 6);

        //    //local functions
        //    void Sort(int low, int high)
        //    {
        //        if (high <= low)
        //        {
        //            return;
        //        }

        //        int mid = (high + low) / 2;

        //        Console.Write("Sort(low, mid) = " + low + mid);
        //        Console.WriteLine();
        //        Sort(low, mid);
        //        Console.Write("Sort(mid+ 1, high) = " + (mid + 1) + high);
        //        Console.WriteLine();
        //        Sort(mid + 1, high);
        //        Merge(low, mid, high);
        //    }

        //    void Merge(int low, int mid, int high)
        //    {
        //        //Guard clause to skip merge if the array is alread sorted 
        //        //optional: this if statement is here just to speed up
        //        //if (array[mid] <= array[mid+1])
        //        //{
        //        //    return;
        //        //}


        //        int i = low;
        //        int j = mid + 1;

        //        Array.Copy(array, low, auxiliaryArray, low, high - low + 1);
        //        Console.Write("Auxiliary Array: ");
        //        foreach (var item in auxiliaryArray)
        //        {
        //            Console.Write(item + " ");
        //        }


        //        for (int k = low; k <= high; k++)
        //        {
        //            if (i > mid)
        //            {
        //                array[k] = auxiliaryArray[j++];
        //            }
        //            else if (j > high)
        //            {
        //                array[k] = auxiliaryArray[i++];
        //            }
        //            else if (auxiliaryArray[j] < auxiliaryArray[i])
        //            {
        //                array[k] = auxiliaryArray[j++];
        //                //Console.Write("Principal Array: ");
        //                //foreach (var item in array)
        //                //{
        //                //    Console.Write(item + " ");
        //                //}
        //            }
        //            else
        //            {
        //                array[k] = auxiliaryArray[i++];
        //            }
        //        }

        //        Console.Write("Principal Array: ");
        //        foreach (var item in array)
        //        {
        //            Console.Write(item + " ");
        //        }
        //    }
        //}
        #endregion
    }
}
