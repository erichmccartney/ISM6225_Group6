using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment1_Q5
{
    class Program
    {
        /*
        Rocky the Bull is new to programming and is having trouble understating 
        the importance of time complexity. Professor Agrawal assigned you the job 
        of explaining time complexity to Rocky with the example below.

        Given two arrays, write a function to compute their intersection.

        Example 1:
        Input: nums1 = [2,5,5,2], nums2 = [5,5]
        Output: [5,5]

        Example 2:
        Input: nums1 = [3,6,2], nums2 = [6,3,6,7,3]
        Output: [3,6]
        
        Note:
        •	Each element in the result should appear as many times as it shows in both arrays.
        •	The result can be in any order.
        •	Submit 2 Solutions where time complexity of the methods is be less than O(n^2). 

        Hint1: You can sort the both arrays and then compute the intersection, in this way you 
        will achieve a time complexity of O(n log n). 
        
        Hint2: If you make use of a dictionary, you need not sort the arrays to compute the 
        intersection. The time complexity in this case will be O(n).

        public static int[] Intersect1(int[] nums1, int[] nums2)
        public static int[] Intersect1(int[] nums1, int[] nums2)
        */

        static public void Main()
        {
            int[] nums1 = { 7, 1, 5, 2, 3, 6 };
            int[] nums2 = { 3, 8, 6, 20, 7 };

            int[] result = Intersect1(nums1, nums2);
            Console.WriteLine("Test 1:");
            foreach (int i in result)
            {
                Console.Write(i);
                Console.Write(' ');
            }
            Console.WriteLine();

            result = Intersect2(nums1, nums2);
            Console.WriteLine("Test 2:");
            foreach (int i in result)
            {
                Console.Write(i);
                Console.Write(' ');
            }
            Console.WriteLine();
        }

        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            // Sort both arrays and create an ArrayList to start building the output.
            Array.Sort(nums1);
            Array.Sort(nums2);
            List<int> output = new List<int>();

            int i = 0;
            int j = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                // If the arrays match at these indices, add it to the output and increment both array indices.
                if (nums1[i] == nums2[j])
                {
                    output.Add(nums1[i]);
                    ++i;
                    ++j;
                }
                // Otherwise, increment just the array with the smaller value.
                else if (nums1[i] < nums2[j])
                    ++i;
                else
                    ++j;
            }

            return output.ToArray();
        }

        public static int[] Intersect2(int[] nums1, int[] nums2)
        {
            List<int> output = new List<int>();

            // Create a dictionary to hold each unique value in the first array as a key, with the count of each as a value.
            Dictionary<int, int> numberCount = new Dictionary<int, int>();
            foreach (int i in nums1)
            {
                if (numberCount.ContainsKey(i))
                    ++numberCount[i];
                else
                    numberCount[i] = 1;
            }

            // For every value in the second array, check for a match in the dictionary. If so, decrement the value so a single value can't be double-matched.
            foreach (int i in nums2)
            {
                if (numberCount.ContainsKey(i) && numberCount[i] > 0)
                {
                    output.Add(i);
                    --numberCount[i];
                }
            }
            return output.ToArray();
        }
    }
}
