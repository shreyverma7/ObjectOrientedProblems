using ObjectOrientedProblems;

internal class Program
{
    private static void Main(string[] args)
    {
        int button = 11;
        switch (button)
        {
            case 1:
                DuplicateElement duplicateElement = new DuplicateElement();
                Console.WriteLine("Object Oriented problems");
                int[] arr = { 1, 2, 3, 4, 5, 2, 6, 7, 8, 3, 9, 9 };
                int totalDuplicates = duplicateElement.countDuplicates(arr);
                Console.WriteLine("Total number of duplicate elements: " + totalDuplicates);
                break;
            case 2:
                int[] arr1 = { 1, 2, 3, 4, 5, 2, 6, 7, 8, 3, 9, 9 };
                UniqueElement uniqueElement = new UniqueElement();
                uniqueElement.printUniqueElements(arr1);
                break;
            case 3:
                int[] arr3 = { 1, 2, 3, 4, 5, 2, 6, 7, 8, 3, 9, 9 };
                int[] elements = new int[arr3.Length];
                int[] frequency = new int[arr3.Length];
                FrequecyEachElement frequecyEachElement = new FrequecyEachElement();
                frequecyEachElement.countFrequency(arr3, elements, frequency);
                Console.WriteLine("Frequency of each element in the array:");
                for (int i = 0; i < elements.Length; i++)
                {
                    if (elements[i] != 0)
                    {
                        Console.WriteLine(elements[i] + ": " + frequency[i]);
                    }
                }
                break;
            case 4:

                int[] arr4 = { 1, 2, 3, 4, 5, 2, 6, 7, 8, 3, 9, 9 };
                int maxElement, minElement;
                MaximunAndMinumum maximunAndMinumum = new MaximunAndMinumum();
                maximunAndMinumum.findMaxMin(arr4, out maxElement, out minElement);

                Console.WriteLine("Maximum element in the array: " + maxElement);
                Console.WriteLine("Minimum element in the array: " + minElement);
                break;

            case 5:
                ReverseEach reverseEach = new ReverseEach();
                string inputString = "Hello World, I am C#";

                string reversedWords = reverseEach.reverseWords(inputString);

                Console.WriteLine("Reversed words in the string: " + reversedWords);
                break;
            case 6:
                string input1 = "This is a title";
                string input2 = "Welcome to the RFP batch";
                CapitalizeFirstLetter capitalizeFirstLetter = new CapitalizeFirstLetter();
                string titleCase1 = capitalizeFirstLetter.convertToTitleCase(input1);
                string titleCase2 = capitalizeFirstLetter.convertToTitleCase(input2);

                Console.WriteLine("Input 1: " + input1);
                Console.WriteLine("Output 1: " + titleCase1);
                Console.WriteLine("Input 2: " + input2);
                Console.WriteLine("Output 2: " + titleCase2);
                break;
            case 7:
                int[] arr7 = { 7, 2, 8, 4, 1, 9, 3, 5, 6 };
                SmallestTwoNumber smallestTwoNumber = new SmallestTwoNumber();
                int lowest1, lowest2;
                smallestTwoNumber.findTwoLowestNumbers(arr7, out lowest1, out lowest2);
                int sum = lowest1 + lowest2;
                Console.WriteLine("Two lowest numbers: " + lowest1 + ", " + lowest2);
                Console.WriteLine("Sum of the two lowest numbers: " + sum);
                break;
            case 8:
                SmallestTwoNumber smallestTwoNumber1 = new SmallestTwoNumber();
                int[] arr8 = { 7, 2, 8, 4, 1, 9, 3, 5, 6 };
                int low1, low2;
                smallestTwoNumber1.findTwoLowestNumbers(arr8, out low1, out low2);

                int sum8 = low1 + low2;

                Console.WriteLine("Two lowest numbers: " + low1 + ", " + low2);
                Console.WriteLine("Sum of the two lowest numbers: " + sum8);
                break;
            case 9:
                PatternTrinangleLower patternTrinangleLower = new PatternTrinangleLower();
                patternTrinangleLower.patternTrinangleLower(8);
                break;
            case 10:
                HollowSquare hollowSquares = new HollowSquare();
                hollowSquares.hollowSquare(8);
                break;
            case 11:
                int[] arr11 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                SumOfAllDigit sumOfAllDigit = new SumOfAllDigit();
                int sum11 = sumOfAllDigit.sumOfArrayElements(arr11);

                Console.WriteLine("Sum of array elements: " + sum11);
                break;

        }

       

    }
       
}
