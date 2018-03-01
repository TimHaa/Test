using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EquationSolver e = new EquationSolver();
            e.Linear("5x+x=2");//TODO x=2
            Console.ReadLine();

        }
    }
}
