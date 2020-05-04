using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    class ListTest
    {
        public class Customer
        {
            public string Name { get; set; }
            public DateTime BirthDate { get; set; }
        }
        public static void Run()
        {
            List<int> list = new List<int>();
            List<string> listOfStrings = new List<string>();
            LogCountAndCapacity(list);

            for (int i = 0; i < 16; i++)
            {
                list.Add(i);
                LogCountAndCapacity(list);
            }
            for (int i = 10; i > 0; i--)
            {
                list.RemoveAt(i - 1);
                LogCountAndCapacity(list);
            }

            list.TrimExcess();
            LogCountAndCapacity(list);
            list.Add(1);
            LogCountAndCapacity(list);
            Console.Read();
        }

        public static void ApiMembers()
        {
            var list = new List<int>() { 1, 0, 5, 3, 4 };
            list.Sort();

            var listCustomers = new List<Customer>()
            {
                new Customer {BirthDate = new DateTime(1988, 08, 12), Name = "Mozo"},
                new Customer {BirthDate = new DateTime(1989, 08, 12), Name = "Bilbo"},
                new Customer {BirthDate = new DateTime(1983, 08, 12), Name = "Gandalf"},
            };

            listCustomers.Sort((left, right) =>
            {
                if (left.BirthDate > right.BirthDate)
                {
                    return 1;
                }
                if (left.BirthDate < right.BirthDate)
                {
                    return -1;
                }
                return 0;
            });

            for (int i = 0; i < listCustomers.Count; i++)
            {
                Console.WriteLine(listCustomers.ElementAt(i).BirthDate + " " + listCustomers.ElementAt(i).Name);
            }
        }

        private static void LogCountAndCapacity(List<int> list)
        {
            Console.WriteLine($"Count= {list.Count}. Capacity= {list.Capacity}");
        }
    }
}
