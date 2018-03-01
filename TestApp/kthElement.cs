using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class KthElement
    { 
        public KthElement() { }
        public void Find(int[][] rangeCollection, int[] queries)
        {
            //Find k-th smallest element in given n ranges
            
            //example Input:
            //int [] inputK = { 1, 3, 5};
            //int[][] inputN = {
            //    new int[] {1,3},
            //    new int[] {6,9},
            //    new int[] {10, 13},
            //};
            //output: 1, 3, 7

            List<int> combinedList = new List<int>();
            for (int i = 0; i < rangeCollection.Length; i++)
            {
                int indexJagged = rangeCollection[i][0];
                if (i>0 && indexJagged < combinedList[combinedList.Count-1]) { indexJagged = combinedList[combinedList.Count-1] + 1; }
                while (indexJagged <= rangeCollection[i][1])
                {
                    combinedList.Add(indexJagged);
                    indexJagged++;
                }
            }

            Console.WriteLine("Combined String:");
            Console.Write("{");
            foreach (int element in combinedList)
            {
                Console.Write(element.ToString());
                if (element != combinedList[combinedList.Count - 1]) { Console.Write(","); }
            }
            Console.WriteLine("}");
            Console.WriteLine("k th smallest elements:");
            foreach (int queryIndex in queries)
            {
                Console.Write(combinedList[queryIndex-1]);
                if (queryIndex != queries[queries.Length-1]) { Console.Write(","); }
            }
        }
    }
}
