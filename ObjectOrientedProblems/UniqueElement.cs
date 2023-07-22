using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblems
{
    public class UniqueElement
    {
        public void printUniqueElements(int[] arr)
        {
            int length = arr.Length;
            bool isDuplicate;

            Console.Write("Unique elements in the array: ");

            for (int i = 0; i < length; i++)
            {
                isDuplicate = false;

                // Check if the current element is a duplicate of any other element
                for (int j = 0; j < length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                // If the current element is not a duplicate, print it
                if (!isDuplicate)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
