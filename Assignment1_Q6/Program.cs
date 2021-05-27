using System;
using System.Collections.Generic;

namespace Assignment1_Q6
{
    class Program
    {
        /*
        You are given an array of characters and an integer k, and are required 
        to find out whether there are two distinct indices i and j in the array 
        such that arr[i]=arr[j] and the absolute difference between i and j is 
        at most k.

        Example 1: 

        Input: arr=[a,g,h,a], k=3
        Output= true

        Explanation= arr[0] and arr[3] contains “a”; hence the absolute difference 
        between 0 and 3 is 3 which is equal to 3 therefore output is true.

        Example 2: arr=[k,y,k,k], k=1
        Output= true
        Example 3: 
        Input: arr=[a,b,c,a,b,c], k=2
        Output: false
        Explanation= arr[0]=arr[3] but absolute difference is not at most 2 
                    arr[1]=arr[4] but absolute difference is not at most 2
                    arr[2]=arr[5] but absolute difference is not at most 2
                    There fore output is false.
        */

        public static void Main()
        {
            char[] arr = new char[] { 'a', 'g', 'h', 'a' };
            int k = 3;
            Console.WriteLine(ContainsDuplicate(arr, k));
            arr = new char[] { 'k', 'y', 'k', 'k' };
            k = 1;
            Console.WriteLine(ContainsDuplicate(arr, k));
            arr = new char[] { 'a', 'b', 'c', 'a', 'b', 'c' };
            k = 2;
            Console.WriteLine(ContainsDuplicate(arr, k));
        }

        // Iterates once through the array (arr) while using a dictionary to keep track of the
        // last index at which it saw each character. If it finds a character which it previously
        // found within k index positions, returns true. Otherwise returns false.
        public static bool ContainsDuplicate(char[] arr, int k)
        {
            Dictionary<char, int> previouslyFoundIndex = new Dictionary<char, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                // Get the next character from the array and check whether we've found it previously.
                char c = arr[i];
                if (previouslyFoundIndex.ContainsKey(c))
                {
                    //  We've seen it, so see if it was recent enough to pass the test.
                    if (i - previouslyFoundIndex[c] <= k) return true;
                }
                // Add or update the entry for this character to the current index.
                previouslyFoundIndex[c] = i;
            }
            return false;
        }
    }
}
