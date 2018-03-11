using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestApp
{
    class SubString
    {
        public SubString() { }
        public void Look() {
            //delete characters that are less than min from a string
            string input = Console.ReadLine();
            int min = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i =0; i < input.Length; i++) {
                string currentChar = input[i].ToString();
                int searchIndex = 0;
                for (int j = 0; j < min; j++) {
                    string remainingStr = input.Substring(searchIndex);
                    if (remainingStr.Contains(currentChar)) {
                        searchIndex += remainingStr.IndexOf(currentChar) + 1;
                        count++;
                    }
                    else { break; }
                    if (searchIndex == input.Length) { break; }
                }
                if (count < min) { input = input.Replace(currentChar, ""); i--; }
                count = 0;
            }
            Console.WriteLine(input);
            Console.ReadLine();
        }
    }
}
