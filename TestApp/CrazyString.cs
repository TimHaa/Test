using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class CrazyString
    {
        public CrazyString() { }

        public void MakeCrazy()
        {
            int t = Convert.ToInt16(Console.ReadLine());
            if (1 <= t && t <= 100)
            {
                for (int x = 0; x < t; x++)
                {
                    string s = Console.ReadLine();
                    Transform(s);
                }
                Console.ReadLine();
            }
            else { Console.WriteLine("Input for t not viable."); }
        }

        public void Transform(string input)
        {
            string crazy = "";
            string inputUp = input.ToUpper();
            string inputDown = input.ToLower();
            int nr = input.Length;
            int j = 0;
            if (input[0] == inputUp[0]) { j = 1; crazy += inputUp[0]; }//wenn 1. Buchstabe groß -> i fängt bei 1 an und 1.Buchstabe wird von Up übernommen
            int i = j;
            while (i <= nr-2)    //fügt alternierend hinzu, bis i nr oder nr - 1 erreicht, also letzter Buchstabe bei nr-2 oder nr - 1 ist.
            {
                crazy += inputDown[i++];
                crazy += inputUp[i++];
            }
            if (!((nr-j)%2 == 0)) { crazy += inputDown[nr-1]; }     //wenn kleines Wort ungerade bzw. großes gerade fürge noch letztes hinzu
            Console.WriteLine(crazy);
        }
    }
}
