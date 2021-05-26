using System;

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
        /* static void printUnion(int[] nums1, int[] nums2, int m,
                           int n)
        {
            // Find which array is smaller
            if (m > n)
            {
                int[] tmp1 = nums1;
                nums1 = nums2;
                nums2 = tmp1;

                int tmp = m;
                m = n;
                n = tmp;
            }

            // Sort smaller array
            Array.Sort(nums1);
            for (int i = 0; i < m; i++)
                Console.Write(nums1[i] + " ");

            // Compare larger and smaller array
            for (int i = 0; i < n; i++)
            {
                if (binarySearch(nums1, 0, m - 1, nums2[i]) == -1)
                    Console.Write(nums2[i] + " ");
            }
        } */

        // Print intersection of the first and second array
        static void printIntersection(int[] nums1, int[] nums2,
                                      int m, int n)
        {
            // Before finding intersection,
            // Find smaller array
            if (m > n)
            {
                int[] tmp1 = nums1;
                nums1 = nums2;
                nums2 = tmp1;

                int tmp = m;
                m = n;
                n = tmp;
            }

        
            // Sort smaller array nums1
            Array.Sort(nums1);

            // Search every element of bigger array in
            // smaller array and print the element if found
            for (int i = 0; i < n; i++)
            {
                if (binarySearch(nums1, 0, m - 1, nums2[i]) != -1)
                    Console.Write(nums2[i] + " ");
            }
        }

       /* // A recursive binary search function.
        // It returns location of x in given
        // array arr[l..r] is present, otherwise -1
        static int binarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at
                // the middle itself
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then it
                // can only be present in left subarray
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                // Else the element can only be
                // present in right subarray
                return binarySearch(arr, mid + 1, r, x);
            }

            // We reach here when element is
            // not present in array
            return -1;
        }
*/
        // Driver Code
        static public void Main()
        {
            int[] nums1 = { 7, 1, 5, 2, 3, 6 };
            int[] nums2 = { 3, 8, 6, 20, 7 };
            int m = nums1.Length;
            int n = nums2.Length;

            // Function call
            Console.WriteLine("Union of two arrays is ");
            printUnion(nums1, nums2, m, n);
            Console.WriteLine("");
            Console.WriteLine("Intersection of two arrays is ");
            printIntersection(nums1, nums2, m, n);
        }
    
   /* static void Main(string[] args)
        {
            Console.WriteLine("Question 5");
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            int[] intersect1 = Intersect1(nums1, nums2);

        } */ 
    }
}
