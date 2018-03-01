using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestApp
{
    class MaximumUniqueString
    {
        //find the string with most unique characters from an array of strings
        public MaximumUniqueString() { }
        public void Find(string[] inputStrings)
        {
            int indexCount = 0;
            int[] count = new int[inputStrings.Length];
            foreach (string word in inputStrings)
            {
                bool[] doublet = new bool[word.Length];
                for (int i = 0; i < word.Length; i++)
                {
                    if (!doublet[i])
                    {
                        count[indexCount]++;
                        for (int j = i + 1; j < word.Length; j++)
                        {
                            if(word[j] == word[i]) { doublet[j] = true; }
                        }
                    }
                }
                Console.Write(word + " ");
                indexCount++;
            }
            Console.WriteLine();
            string longest = inputStrings[Array.IndexOf(count, count.Max())];
            foreach (int nr in count) { Console.Write(nr + "\t"); }
            Console.WriteLine();
            Console.WriteLine(longest + " with a unique-letter-count of " + count.Max());
        }
    }
}
