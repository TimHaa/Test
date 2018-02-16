using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class NaturalProgression
    {
        public NaturalProgression(){}

        

        public double CalcNth(int a, int r, int n)
        {
            double s = a *Math.Pow(r, n-1);
            Console.WriteLine(s);
            return s;
        }
        
    }
}
