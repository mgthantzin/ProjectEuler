using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Answer for Problem 1 is " + SumOfMultiplesOfXOrYBelow(1000).ToString() + ".");
            Console.Read();            
        }

        /// <summary>        
        /// Problem 1:
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        /// <param name="cap">Variable for the upper cap (e.g. 1000 in the question)</param>
        /// <param name="x">(optional) Variable for the first multiplier (e.g. 3 in the question)</param>
        /// <param name="y">(optional) Variable for the second multiplier (e.g. 5 in the question)</param>
        /// <returns>The sum of all the multiples of X or Y below cap</returns>
        private static long SumOfMultiplesOfXOrYBelow(int cap, int x = 3, int y = 5)
        {
            int sum = 0;

            for(int i = 1; i <= cap; i++)
            {
                if(i % x == 0 || i % y == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
