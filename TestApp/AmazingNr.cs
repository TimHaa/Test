using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class AmazingNr
    {
        
        public AmazingNr()
        {
        }
        private bool Calc()
        {
            double ni = Convert.ToDouble(Console.ReadLine());
            if (1 <= ni && ni <= 2 * Math.Pow(10, 18))
            {
                if (ni % 2 == 0 && !(ni % 3 == 0) && !(ni == 2))
                {
                    return true;
                }
                else if (!(ni % 2 == 0) && ni % 3 == 0 && !( ni == 3))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else {
                Console.WriteLine("Input for n not viable.");
                return false;
            }
            
        }
        public void Amaze()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            string output ="";
            if (1 <= t && t <= 107)
            {
                do
                {
                    
                    if (Calc()) { output += "1\n"; }
                    else { output+= "0\n"; }



                } while (--t > 0);
                Console.WriteLine(output);
            }
            else { Console.WriteLine("Input for t not viable."); }
            Console.ReadLine();
        }

    }

}
