using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class NaturalProgression
    {
        public NaturalProgression(){}
        
        public double CalcNth(int constant, int basis, int exp)
        {
            double s = constant * Math.Pow(basis, exp-1);
            Console.WriteLine(s);
            return s;
        }
        
    }
}
