using System;
using System.Collections;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            printResult("ADA");
            printResult("ABCD");
            printResult("RENNER");
            printResult("socorram me subi no on ibus em marrocos");
            printResult("ARARA");
            printResult("atabaca");
        }

        public static void printResult(string word)
        {
            Console.WriteLine(word + " is an Palindrome? " + palindromeTest(word));
        }
        public static bool palindromeTest(string word)
        {
            Stack stack = new Stack();

            for (int i = 0; i < word.Length; i++)
            {
                stack.Push(word[i]);
            }
            var inverseWord = "";
            while (stack.Count >=1 )
            {
                inverseWord += stack.Pop();
            }
            if (inverseWord.Equals(word))
            {
                return true;
            }
            return false;
        }
    }
}
