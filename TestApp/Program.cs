using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SortOdd sObject = new SortOdd();
            int[] arrIn = { 7, 10, 11, 3, 6, 9, 2, 13, 0};

            sObject.Sort(arrIn);
            Console.ReadLine();
        }
    }
}
