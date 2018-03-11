using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class ArrayMinMax
    {
        //remove from the top and bottom of an array until max-min <= k
        public ArrayMinMax() { }

        public void SetMinMax(int[] inputArray, int avgInput)
        {
            Array.Sort(inputArray);
            ArrPrint(inputArray);
            int start=0;
            int end = 1;
            int i = 1;
            int nrOfRemovals = inputArray.Length - 1;
            while (i <= nrOfRemovals)
            {
                for (int j = 0; j <= nrOfRemovals -i; j++)
                {
                    if(inputArray[inputArray.Length-i]-inputArray[j] <= avgInput && j + i <= nrOfRemovals) { nrOfRemovals = j + i - 1 ;end = inputArray.Length - i; start = j;  break; }
                }
                i++;
            }
            if(nrOfRemovals == inputArray.Length - 1 || inputArray.Length <= 1) { Console.WriteLine("Number cannot be generated."); }
            else
            {
                Console.WriteLine("Needed to remove {0} numbers.", nrOfRemovals);
                int[] arrSol = new int[end - start+1];
                Array.Copy(inputArray, start, arrSol, 0, end - start+1);
                ArrPrint(arrSol);
            }
        }

        private void ArrPrint(int[] arrIn)
        {
            for (int i = 0; i < arrIn.Length; i++)
            {
                Console.Write(arrIn[i]);
                if (i != arrIn.Length - 1) { Console.Write(","); }
            }
            Console.WriteLine();
        }
    }
}
