using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    class SortOdd
    {
        public SortOdd() { }

        public void Sort(int[] inputArray) {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            int[] combined = new int[inputArray.Length];
            for (int count = 0; count < inputArray.Length; count++) {
                if(count%2 == 0) {
                    even.Add(inputArray[count]);
                }else {
                    odd.Add(inputArray[count]);
                }
            }
            even = even.OrderByDescending(i => i).ToList();
            int[] evenArr = even.ToArray();
            odd = odd.OrderBy(i => i).ToList();
            int[] oddArr = odd.ToArray();
            int j = 0;
            for (int i = 0; i < (combined.Length); i++) {
                if (i % 2 == 0) {
                    combined[i] = even[j];
                }else {
                    combined[i] = odd[j];
                    j++;
                }
            }
            Console.WriteLine(String.Join("; ", inputArray));
            Console.WriteLine(String.Join("; ", combined));
        }
    }
}
