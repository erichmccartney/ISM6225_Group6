using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public static void Main()
        {
            Console.WriteLine(FreqSort("test1"));
            Console.WriteLine(FreqSort("test2!!!"));
            Console.WriteLine(FreqSort("Test3!!"));
        }

        public static string FreqSort(string s)
        {
            Dictionary<char, int> characterCounts = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (characterCounts.ContainsKey(c))
                    characterCounts[c]++;
                else
                    characterCounts[c] = 1;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var item in characterCounts.OrderByDescending(key => key.Value))
            {
                for (int i = 0; i < item.Value; i++) sb.Append(item.Key);
            }
            return sb.ToString();
        }
    }
}
