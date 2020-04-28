using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    class ShellSortingTest
    {
        public static void ShellSort(int[] array)
        {
            int gap = 1;

            while (gap <= array.Length/3)
            {                
                gap *= 3;
            }

            int count = 0;

            while (gap >= 1)
            {
                count++;
                Print(array);
                Console.Write("counter: " + count);
                Console.WriteLine();
                for (int i = gap; i < array.Length; i++)
                {
                    Print(array);
                    count++;
                    Console.Write("counter: " + count);
                    Console.WriteLine();
                    for (int j = i; j >= gap && array[j] < array[j-gap]; j--)
                    {
                        Swap(array, j, j - gap);
                        Print(array);
                        count++;
                        Console.Write("counter: " + count);
                        Console.WriteLine();
                    }
                }

                gap /= 3;
            }
           



            //int gap = 1;

            //while (gap < array.Length/3)
            //{
            //    gap = 3 * gap ;
            //}//gap = 9


            //while (gap >= 1)
            //{
            //    Print(array);
            //    for (int i = gap; i < array.Length; i++)
            //    {
            //        Print(array);
            //        for (int j = i; j >= gap && array[j] < array[j-gap]; j -= gap)
            //        {
            //            Swap(array, j, j - gap);
            //            Print(array);
            //        }
            //    }

            //    gap /= 3;
            //}
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

        private static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    

}
