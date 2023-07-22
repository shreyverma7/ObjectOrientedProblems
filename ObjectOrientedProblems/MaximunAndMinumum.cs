using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblems
{
    public class MaximunAndMinumum
    {
        public void findMaxMin(int[] arr, out int max, out int min)
        {
            max = int.MinValue; // Set max to the smallest possible value
            min = int.MaxValue; // Set min to the largest possible value

            foreach (int num in arr)
            {
                if (num > max)
                {
                    max = num; // Update max if a larger element is found
                }

                if (num < min)
                {
                    min = num; // Update min if a smaller element is found
                }
            }
        }
    }
}
