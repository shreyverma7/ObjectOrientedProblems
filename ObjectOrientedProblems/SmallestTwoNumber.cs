using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblems
{
    public class SmallestTwoNumber
    {
        public void findTwoLowestNumbers(int[] arr, out int lowest1, out int lowest2)
        {
            lowest1 = arr[0];
            lowest2 = arr[1];

            if (lowest2 < lowest1)
            {
                int temp = lowest1;
                lowest1 = lowest2;
                lowest2 = temp;
            }

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] < lowest1)
                {
                    lowest2 = lowest1;
                    lowest1 = arr[i];
                }
                else if (arr[i] < lowest2)
                {
                    lowest2 = arr[i];
                }
            }
        }
    }
}
