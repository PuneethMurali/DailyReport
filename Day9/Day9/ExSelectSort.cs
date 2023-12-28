using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class ExSelectSort
    {
        // function for selection sort
        static void SelectSort(int[] arr)
        {
            int n = arr.Length;
            int temp;
            for (int i = 0; i < n; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    { min_idx = j; }
                }

                temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        // function to print array
        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.Write("\n");
        }

        // test the code
        static void Main(string[] args)
        {
            int[] nums = { 4, 2, 1, 8, 3 };
            Console.Write("Original Array\n");
            PrintArray(nums);

            SelectSort(nums);
            Console.Write("\nSorted Array\n");
            PrintArray(nums);
        }
    }
}