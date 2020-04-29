using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataReview
{
    class RecursionExampleFactorial
    {
        public static int RecursiveFactorialTest(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * RecursiveFactorialTest(number - 1);
        }
        
        public static int FactorialTest(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
