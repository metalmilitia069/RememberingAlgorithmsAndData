using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDataStudying
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArraysDemo();

           // BubbleSortingTest blob = new BubbleSortingTest();

            int[] array = { 2132, 4343, 112, 21, 32, 22, 3213, 213, 6544, 786, 9977, 65656, 32, 123123, -1, -1000, -40, 213, 2, 7, 4, 3, 5, 6, 6, 6, 43 };

            //BubbleSortingTest.BubbleSort(array);
            SelectionSortTest.SelectSort(array);

            foreach (var item in array)
            {
                Console.Write(item + " ");                
            }

            Console.WriteLine();
        }

        //private static void ArraysDemo()
        //{
        //    int[] a1;

        //    a1 = new int[10];

        //    int[] a2 = new int[5];

        //    int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

        //    int[] a4 = { 1, 3, 2, 4, 5 };

        //    for (int i = 0; i < a3.Length; i++)
        //    {
        //        Console.Write($"{a3[i]} ");
        //    }

        //    Console.WriteLine();

        //    foreach (var el in a4)
        //    {
        //        Console.Write($"{el} ");
        //    }

        //    Console.WriteLine();

        //    Array mozo = new int[5];

        //    Console.Read();
        //}
    }
}
