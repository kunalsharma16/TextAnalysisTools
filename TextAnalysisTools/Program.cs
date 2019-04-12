using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysisTools
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("the longest word is :");
            
            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));

        }
      //kunal sharma//
      //c0727250//
       public string MyFunctionA(string input)
        {// Write a c# program to find the longest word in a string.
            string[] words = input.Split();

            int wordsArrayLength = words.Length;
            int[] wordsLength = new int[wordsArrayLength];

            for(int i=0; i<words.Length;i++)
            {
                wordsLength[i] = words[i].Length;
            }
            // loop post condition: we now have array wordsLength which
            // contains the length of each word

            string currentWord = words[0];
            string nextWord;

            for(int y =0; y< words.Length-1;y++)
            {
                currentWord = words[y];
                nextWord = words[y + 1];
                
            }

           
            return currentWord;

        }

        
        
        
    }
}
