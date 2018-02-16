using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Test
{
    class SubString
    {
        public SubString() { }

        public void Look()
        {

            string input = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            //string input = inputString;
            int count = 0;
            for (int i =0; i < input.Length; i++)
            {
                
                string a = input[i].ToString();
                int searchIndex = 0;
                for (int j = 0; j < k; j++)
                {
                    //Console.WriteLine(a);
                    //Console.WriteLine(searchIndex);
                    //Console.WriteLine(input.Substring(searchIndex));


                    if (input.Substring(searchIndex).Contains(a))
                    {

                        searchIndex += input.Substring(searchIndex).IndexOf(a) + 1;
                        count++;
                        //Console.WriteLine(a);
                        //Console.WriteLine(count);
                        //Console.WriteLine(searchIndex);
                    }
                    else { break; }
                    if (searchIndex == input.Length) { break; }
                }
                if (count < k) { input = input.Replace(a, ""); i--; }
                
                count = 0;
                
            }
            

            Console.WriteLine(input);
            Console.ReadLine();
        }
    }
}
