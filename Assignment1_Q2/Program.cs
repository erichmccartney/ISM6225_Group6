using System;

namespace Assignment1_Q2
{
    class Program
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
        static void Main(string[] args)
        {
            string input = "University of South Florida";
            string temp = "";
            string output = "";

            for (int c = input.Length - 1; c > -1; c--) //for loop that stops when c is negative
            {
                if (input[c] == ' ') //check empty space
                {
                    output = temp + " " + output; //append each word in reverse order
                    temp = "";
                }
                else
                {
                    temp += input[c]; //if no empty spaces adds 'input' value in array for delination
                }
            }
            output = temp + " " + output;  // adds last word from for loop
            Console.WriteLine(output);
        }
    }

    /*
     * string Str, StringReverse = "";
    Console.Write("Enter A String : ");
    Str = Console.ReadLine();

    for (int i = Str.Length - 1; i >= 0; i--)
    {

        StringReverse = StringReverse + Str[i];
    }

    Console.WriteLine("Reverse  String  Is: {0}", StringReverse);
    Console.ReadLine();
    */
}