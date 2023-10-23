using System;
using System.Collections.Generic;
using System.Linq;

namespace PalindromeExercise
{

    public class WordSmith
    {
          public bool IsAPalindrome(string input) 
          {
            string compare = "";
            foreach (var character in input.Reverse()) 
            {
                compare += character;
            }
            return (compare == input) ? true : false;
          }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
