using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class EquationSolver
    {
        public EquationSolver() { }
        public void Linear(string equation)
        {
            //solve linear equation by summing up numbers and x's and dividing sumX/sumNr

            equation = equation.Replace(" ", string.Empty);
            Console.WriteLine(equation);
            int xLeft = 0;
            int xRight = 0;
            int nrLeft = 0;
            int nrRight = 0;
            bool sideChanged = false;
            int posPreviousSign = 0;
            
            for (int i = 0; i < equation.Length; i++)
            {
                if (equation[i] == '=')
                {
                    Evaluate(equation, posPreviousSign, i, sideChanged, ref xRight, ref xLeft, ref nrRight, ref nrLeft);
                    sideChanged = true;
                    posPreviousSign = i+1;
                }
                else if(equation[i]== '+')
                {
                    Evaluate(equation, posPreviousSign, i, sideChanged, ref xRight, ref xLeft, ref nrRight, ref nrLeft);
                    posPreviousSign = i+1;
                }
                else if (equation[i] == '-')
                {
                    Evaluate(equation, posPreviousSign, i, sideChanged, ref xRight, ref xLeft, ref nrRight, ref nrLeft);
                    posPreviousSign = i;
                }
            }
            Evaluate(equation, posPreviousSign, equation.Length, sideChanged, ref xRight, ref xLeft, ref nrRight, ref nrLeft);

            float nrSum = nrRight - nrLeft;
            float xSum = xLeft - xRight;
            Console.WriteLine("sum x: {0};sum nr : {1}", xSum, nrSum);
            Console.WriteLine("left nr: {0};right nr : {1}", nrLeft, nrRight);
            Console.WriteLine("left x: {0};right x : {1}", xLeft, xRight);
            Console.WriteLine();
            if (xSum == 0 && nrSum == 0)
            {
                Random rand = new Random();
                int rnd = rand.Next(1000);
                Console.WriteLine("There are infinit possible solutions. May I propose {0}?", rnd);
            }
            else if (xSum == 0 && !(nrSum == 0))
            {
                Console.WriteLine("There are no possible solutions for x.");
            }
            else
            {
                float solution = nrSum/xSum ;
                Console.WriteLine("X equals {0}.", solution);
            }
        }

        private void Evaluate(string fullString, int start, int end, bool side, ref int xRSum, ref int xLSum, ref int nrRSum, ref int nrLSum)
        {
            //Check if contains x and then add to according sum

            string term = fullString.Substring(start, end-start);
            int value;
            if (term.Contains("x"))
            {
                Int32.TryParse(term.Replace("x", string.Empty), out value);
                if(value == 0) { value = 1; }
                if (side) { xRSum += value; }
                else { xLSum += value; }
                Console.WriteLine("left x: {0};right x : {1}", xLSum, xRSum);
            }
            else
            {
                Int32.TryParse(term, out value);
                if (side) { nrRSum += value; }
                else { nrLSum += value; }
                Console.WriteLine("Only Numbers");
                Console.WriteLine("left nr: {0};right nr : {1}", nrLSum, nrRSum);
            }
        }


    }
}
