using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblems
{
    public class SumOfAllDigit
    {
        public int sumOfArrayElements(int[] arr)
        {
            int sum = 0;

            foreach (int num in arr)
            {
                sum += num; // Add each element to the running total
            }

            return sum;
        }
    }
}
