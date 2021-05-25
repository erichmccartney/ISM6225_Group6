using System;

namespace Assignment1_Q3
{
    class Program
    {
        /*
        Given a sorted integer array. He needs to make the array elements distinct 
        by increasing each value as needed, while minimizing the array sum

        Example : 
        Input : arr[] = {2,2,3,5,6};			Output: 20
        Explanation: Array is transformed to {2,3,4,5,6}. Sum becomes 2+3+4+5+6=20
        Input arr[]= {40,40};				Output: 81
        Explanation: Array is transformed to {40,41}. Sum becomes 81
        Input: arr[] = {4,5,6,9};			Output : 24
        Explanation: As the array is sorted and has distinct elements. So result is 
        sum of each elements in the array.

        Time Complexity: O(n)
        public static int minSum(int[] arr)
        */

        static int MinSum(int []arr, int n)
        {
            int sum = arr[0], prev = arr[0]; // define and set array to zero

            for (int i = 1; i < n; i++)  // for loop
            {
                //while number is same or smaller than previous, add 1 plus previous
                if (arr[i] <= prev)
                {
                    prev = prev + 1;
                    sum = sum + prev;
                }
                //next number is larger
                else
                {
                    sum = sum + arr[i];
                    prev = arr[i];
                }
            }
            return sum;
        }
        // Driver Code
        public static void Main()
        {
            int []arr = { 2, 2, 3, 5, 6 };
            int n = arr.Length;
            Console.WriteLine(MinSum(arr, n));
        }
    }
}

