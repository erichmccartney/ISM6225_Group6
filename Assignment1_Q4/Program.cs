using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Assignment1_Q4
{
    class Program
    {
        /*
       You are given a string and your task is to sort the given string 
       in decreasing order of frequency of occurrence of each character.

       Example 1: 
       Input : “Dell”					Output: “llDe”
       Explanation:  “lleD” is also accepted. Frequency of l is 2 and other 2 characters is 1.
       
        Example 2:
       Input : eebhhh					Output: hhheeb 
       
        Example 3: 
       Input : yYkk				    	Output: kkYy
       Explanation: “Yykk” is not a valid answer as Y and y are treated as two different characters.

       Note: The solution must use a dictionary as the primary data structure.
       public static string FreqSort(string s)
       */


        public static string FreqSort(string s)
        {
                       
            Dictionary<int, string > map = new Dictionary<int, string>();
            map.TryAdd(1, "Dell");
            map.TryAdd(2, "eebhhh");
            map.TryAdd(3, "yYkk");


        }
        // Driver Code
        public static void Main()
        {
            int[] arr = { 2, 2, 3, 5, 6 };
            int n = arr.Length;
            Console.WriteLine(FreqSort(arr, n));
        }
}
