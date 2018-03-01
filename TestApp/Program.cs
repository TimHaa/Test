using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            KthElement k = new KthElement();
            int[] inputK = { 1, 3, 5 };
            int[][] inputN = {
                new int[] {1,3},
                new int[] {6,9},
                new int[] {10, 13},
            };
            k.Find(inputN, inputK);
            Console.ReadLine();

        }
    }
}
