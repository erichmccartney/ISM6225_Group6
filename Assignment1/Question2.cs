using System;
/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/

namespace Assignment1
{
    class Question2
    {
        /* 
        Rocky is not aware of the inbuilt functions to split and reverse a string. 
        He is given a string and he needs to reverse the order of characters in each 
        word within a sentence while still preserving whitespace and initial word order. 
        He is not allowed to use any predefined split and reverse function. He is 
        requesting you to complete the method for him.

        Example: 
        Input : “University of South Florida”
        Output: “stisverinU fo htuoS adirolF”
        Note: Time complexity should be O(n) where n is the length of string
        Hint: Create your own split and reverse function.
        Public static string StringReverse(string s)
        */
        public static void StringReverse(string s)
        {

            string Str, Revstr = "";
            Console.Write("Enter A String : ");
            Str = Console.ReadLine();

            for (int i = Str.Length - 1; i >= 0; i--)
            {

                Revstr = Revstr + Str[i];
            }

            Console.WriteLine("Reverse  String  Is  {0}", Revstr);
            Console.ReadLine();
        }
    }

}
