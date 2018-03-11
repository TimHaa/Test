using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp {
    class Chocolats {
        public string output = "";
        public Chocolats() { }
        public void Buy() {
            Console.WriteLine("How many times?");
            int t = Convert.ToInt32(Console.ReadLine());
            if (1 <= t && t <= 101) {//test if t is possible
                do {
                    Calc();
                } while (--t > 0);
                Console.WriteLine(output);
            } else {
                Console.WriteLine("Input for t not viable.");
            }
            Console.ReadLine();
        }
        private void Calc() {
            int moneySpent = 100-Convert.ToInt32(Console.ReadLine());
            if (0 <= moneySpent && moneySpent <= 100) {
                int moneyCalculated = 0;
                while (moneyCalculated < moneySpent){
                    int add3s = moneyCalculated;
                    while (add3s < moneySpent) {
                         add3s += 3;
                    }
                    if (add3s == moneySpent) { moneyCalculated = add3s; }
                    else {
                        moneyCalculated += 7; }
                }
                if (moneyCalculated == moneySpent) {
                    output += "1\n"; }
                else {
                    output += "0\n"; }
            }
            else {
                output += "Input for m not viable.\n";
            }
           
        }
        
    }
}
