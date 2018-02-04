using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class Mean
    {
        public Mean()
        {

        }


        public int Calc(int[] arr, int mean) {
            int arraySum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arraySum += arr[i];
            }
            int sol = mean * (arr.Length + 1) - arraySum;
            return sol;
            

        }
    }
}
