using System;

namespace Assignment1_Q1
{
    class Program
    {

        /* Q1: Prof receives an array of integer points sorted in ascending order, the
        task is to find the initial and final index of a given target point’s value.

        If the target point value is not found in the array of integers, return [-1,-1]*/

        static void question1(int[] array, int x)
        {
            int n = array.Length;
            int first = -1, last = -1;

            for (int i = 0; i < n; i++)  //for loop starting at i=0, in increments of 1
            {
                if (x != array[i]) //convert varible to array with "!"
                    continue;
                if (first == -1)
                    first = i; //first position identified
                last = i;
            }
            if (first != -1) //convert variable to integer with "!"
            {
                Console.WriteLine("[" + first + ", " + last + "]");
            }
            else
                Console.WriteLine("[-1,-1]");
        }
        // Driver code
        public static void Main()
        {
            int[] array = { 1, 2, 2, 2, 2, 3,
                      4, 7, 8, 8 };
            int x = 8;
            question1(array, x);
        }
    }

}