using System;
using System.Collections;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            printResult("ADA");
            printResult("ABCD");
            printResult("RENNER");
            printResult("socorram me subi no onibus em marrocos");
            printResult("ARARA");
            printResult("atabaca");
        }

        public static void printResult(string word)
        {
            Console.WriteLine(word + " is an Palindrome? " + palindromeTest(word));
        }
        public static bool palindromeTest(string word)
        {
            string palavraSemEspaco = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].Equals(' '))
                {
                    i++;
                }
                palavraSemEspaco += word[i].ToString();
            }
            string inverseWord = new string(palavraSemEspaco.Reverse().ToArray());

            return inverseWord.Equals(palavraSemEspaco);
        }
    }
}
