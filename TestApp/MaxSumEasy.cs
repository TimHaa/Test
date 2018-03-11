using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class MaxSumEasy
    {
        public MaxSumEasy() { }
        //https://www.geeksforgeeks.org/maximize-sum-selected-numbers-performing-following-operation/
        public void Sum(int[] inputArray)
        {
            int sum = 0;
            Array.Sort(inputArray);
            Array.Reverse(inputArray);
            
            List<int> inputList = new List<int>(inputArray);
            do
            {

                sum += inputList[0];
                inputList.Remove(inputList[0] - 1);
                inputList.Remove(inputList[0]);

            } while (inputList.Count > 0);
            Console.WriteLine(sum);
        }
    }
}
