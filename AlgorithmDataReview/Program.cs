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
            int[] arromba1 = { 6, 2, 4, 5, 1, 3, 0};
            //int[] arromba1 = { 0,2,3,6,5,4,1 };

            //SORTING

            //BubbleSortingTest.BubbleSort(arromba);
            //SelectionSortingTest.SelectSort(arromba);
            //InsertSortingTest.InsertSorting(arromba);
            //ShellSortingTest.ShellSort(arromba);            
            //MergeSortingTest.MergeSort(arromba);
            //QuickSortingTest.QuickSort(arromba);

            //Console.WriteLine("Final Array");
            //foreach (var item in arromba)
            //{
            //    Console.Write(item + " ");
            //}

            //########################################################################################### LinkedList

            //SINGLY NODE

            //NodeTest<int> first = new NodeTest<int>(5);
            //first.value = 5;

            //NodeTest<int> second = new NodeTest<int>(1);// { value = 1 };

            //NodeTest<int> third = new NodeTest<int>(3);// { value = 3 };

            //first.next = second;
            //second.next = third;

            //NodeTest<int>.PrintLinkedList(first);


            //SINGLY NODE - TESTING WITH STRINGS

            //NodeTest<string> first = new NodeTest<string>();
            //first.value = "DOIDAO";

            //NodeTest<string> second = new NodeTest<string>() { value = "CU" };

            //NodeTest<string> third = new NodeTest<string>() { value = "ASSADO" };

            //first.next = second;
            //second.next = third;

            //NodeTest<string>.PrintLinkedList(first);

            //SINGLY LINKED LIST

            //SinglyLinkedListTest<int> singlyLinkedListTest = new SinglyLinkedListTest<int>();

            //singlyLinkedListTest.AddFirst(5);
            //singlyLinkedListTest.AddFirst(3);
            //singlyLinkedListTest.AddFirst(2);
            //singlyLinkedListTest.AddFirst(6);

            //singlyLinkedListTest.AddLast(5);
            //singlyLinkedListTest.AddLast(3);
            //singlyLinkedListTest.AddLast(2);
            //singlyLinkedListTest.AddLast(6);

            //singlyLinkedListTest.PrintList();


            //singlyLinkedListTest.RemoveFirst();

            //singlyLinkedListTest.PrintList();


            //singlyLinkedListTest.RemoveLast();

            //singlyLinkedListTest.PrintList();



            //Console.WriteLine();


            //Doubly LinkedList

            //######################################################################## STACK


            //Stack Using Arrays!!!!

            //ArrayBasedStackTest<int> stack = new ArrayBasedStackTest<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            //Console.WriteLine("1st Iteration Over the Stack: ");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine($"Should print out 4: {stack.Peek()}");

            //stack.Pop();

            //Console.WriteLine($"Should print out 3: {stack.Peek()}");

            //Console.WriteLine("2nd Iteration Over the Stack: ");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack Using LinkedLists!!!!

            //var stack1 = new LinkedListBasedStackTest<int>();

            //stack1.Push(9);
            //stack1.Push(8);
            //stack1.Push(7);
            //stack1.Push(6);
            //stack1.Push(5);
            //stack1.Push(4);
            //stack1.Push(3);

            //Console.WriteLine("1st Iteration Over the Stack: ");
            //foreach (var item in stack1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine($"Item on the Top of the Stack: {stack1.Peek()}");

            //stack1.Pop();            

            //Console.WriteLine("2nd Iteration Over the Stack: ");
            //foreach (var item in stack1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine($"Item on the Top of the Stack: {stack1.Peek()}");


            //######################################################################## QUEUES

            //Linear Queues Based on Arrays!!!!!

            //var queue1 = new ArrayBasedQueue<int>();

            //queue1.Enqueue(1);
            //queue1.Enqueue(4);
            //queue1.Enqueue(5);
            //queue1.Enqueue(2);
            //queue1.Enqueue(3);
            //queue1.Enqueue(6);

            //Console.WriteLine(queue1.Peek());

            //Console.WriteLine();

            //foreach (var item in queue1)
            //{
            //    Console.WriteLine(item);
            //}

            //queue1.Dequeue();
            //Console.WriteLine();
            //Console.WriteLine(queue1.Peek());
            //Console.WriteLine();

            //foreach (var item in queue1)
            //{
            //    Console.WriteLine(item);
            //}

            //queue1.Dequeue();
            //Console.WriteLine();
            //Console.WriteLine(queue1.Peek());
            //Console.WriteLine();

            //foreach (var item in queue1)
            //{
            //    Console.WriteLine(item);
                
            //}

            //Console.WriteLine(queue1.GetEnumerator());

            //Circular Queues Based on Arrays!!!!!

            //var queueCircular01 = new CircularQueueArrayBasedTest<int>();

            //queueCircular01.Enqueue(50);
            //queueCircular01.Enqueue(4);
            //queueCircular01.Enqueue(5);
            //queueCircular01.Enqueue(8);
            //queueCircular01.Enqueue(11);
            //queueCircular01.Enqueue(43);

            //foreach (var item in queueCircular01)
            //{
            //    Console.WriteLine(item);

            //}

            //Console.WriteLine();
            //Console.WriteLine(queueCircular01.Peek());

            //queueCircular01.Dequeue();

            //Console.WriteLine();
            //Console.WriteLine(queueCircular01.Peek());

            //Console.WriteLine();

            //foreach (var item in queueCircular01)
            //{
            //    Console.WriteLine(item);

            //}


            //Queue With LINKED LISTS!!!!!!!!!!!




            //ListTest.Run();
            //ListTest.ApiMembers();










            //foreach (var item in arromba)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine(RecursionExampleFactorial.FactorialTest(5));
            //Console.WriteLine(RecursionExampleFactorial.RecursiveFactorialTest(5));

            //Console.WriteLine(int.MaxValue);





            //Console.WriteLine();

            //QUESTION CHAP 10.1

            //int[] moz = new int[13];
            //int[] moza = new int[6];
            //moz[0] = 1;
            //moz[1] = 3;
            //moz[2] = 5;
            //moz[3] = 7;
            //moz[4] = 8;
            //moz[5] = 9;
            //moz[6] = 11;

            //moza[0] = 2;
            //moza[1] = 4;
            //moza[2] = 6;
            //moza[3] = 10;
            //moza[4] = 12;
            //moza[5] = 13;


            ////Program.MergeThisSHit(moz, moza, 3, 3);
            //Program.MergeTeuCu(moz, moza);

            //foreach (var item in moz)
            //{
            //    Console.WriteLine(item);
            //}

            //END OF QUESTION

        }


        //QUESTION 10.1
        public static void MergeThisSHit(int[] a, int[] b, int lastA, int lastB)
        {
            int indexA = lastA - 1;
            int indexB = lastB - 1;
            int indexMerged = lastB + lastA - 1;

            while (indexB >= 0)
            {
                if (indexA >= 0 && a[indexA] > b[indexB])
                {
                    a[indexMerged] = a[indexA];
                    indexA--;
                }
                else
                {
                    a[indexMerged] = b[indexB];
                    indexB--;
                }
                indexMerged--;
            }
        }
        
        public static void MergeTeuCu(int[] a, int[] b)
        {
            int indexA = 0;
            int indexB = 0;
            
            int indexMerged = a.Length - 1;           

            indexB = b.Length - 1;
            indexA = a.Length - b.Length - 1;

            while (indexB >= 0)
            {
                if (indexA >= 0 && a[indexA] > b[indexB])
                {
                    a[indexMerged] = a[indexA];
                    indexA--;
                }
                else
                {
                    a[indexMerged] = b[indexB];
                    indexB--;
                }
                indexMerged--;
            }            
        }

        //

    }
}
