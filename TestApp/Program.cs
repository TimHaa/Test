using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Mean mObject = new Mean();
            int m = 9;
            int[] a = { 2, 4, 20 };
            int solution = mObject.Calc(a, m);
            Console.WriteLine(solution);
            Console.ReadLine();
        }
    }
}
