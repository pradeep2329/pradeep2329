using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversebyword
{
    class ReversebyWords
    {
        static void Main()
        {
            reversebywords();
            Console.ReadLine();
        }
        static void reversebywords()
        {
            Console.WriteLine("Enter the Sentence:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}
