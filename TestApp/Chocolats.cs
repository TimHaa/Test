using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Chocolats
    {
        public string output = "";
        public Chocolats() { }
        public void Buy()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            if (1 <= t && t <= 101)//test if t is possible
            {
                do//for each t do a Calculation and add to Output
                {

                    Calc();



                } while (--t > 0);
                Console.WriteLine(output);
            }
            else { Console.WriteLine("Input for t not viable."); }
            Console.ReadLine();
        }
        private void Calc()
        {
            int m = 100-Convert.ToInt32(Console.ReadLine());//get Input from User -> Money spent
            
            if (0 <= m && m <= 100)
            {
                int monT = 0;
                
                while (monT < m){
                    
                        int j = monT;
                        while (j < m)
                        {
                        
                                
                                j += 3;
                        
                        }
                    if (j == m) { monT = j; }
                    else { monT += 7; }
                }
                if (monT == m) { output += "1\n"; }
                else { output += "0\n"; }
                
            }else
            {
                output += "Input for m not viable.";
            }
           
        }
        
    }
}
