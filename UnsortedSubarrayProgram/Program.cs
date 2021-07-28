using System;

namespace UnsortedSubarrayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 4, 3, 2, 3, 4 };

            FindUnsortedSubarray(array);
        }

        static void FindUnsortedSubarray(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Your array is empty!");
                Console.ReadLine();
                return;
            }

            int leftIndexElement, rightIndexElement, i;

            for (leftIndexElement = 0; leftIndexElement < array.Length - 1; leftIndexElement++)
            {
                if (array[leftIndexElement] > array[leftIndexElement + 1])
                {
                    break;
                }
            }

            if (leftIndexElement == array.Length - 1)
            {
                Console.WriteLine("You don't need to sort it, it's already!");
                Console.ReadLine();
                return;
            }

            for (rightIndexElement = array.Length - 1; rightIndexElement > 0; rightIndexElement--)
            {
                if (array[rightIndexElement] < array[rightIndexElement - 1])
                {
                    break;
                }
            }

            int max = array[leftIndexElement], min = array[leftIndexElement];

            for (i = leftIndexElement + 1; i <= rightIndexElement; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            for (i = 0; i < leftIndexElement; i++)
            {
                if (array[i] > min)
                {
                    leftIndexElement = i;
                    break;
                }
            }

            for (i = array.Length - 1; i > rightIndexElement; i--)
            {
                if (array[i] < max)
                {
                    rightIndexElement = i;
                    break;
                }
            }

            Console.WriteLine($"[{leftIndexElement},{rightIndexElement}]");
            Console.ReadLine();
        }
    }
}
