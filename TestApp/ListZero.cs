using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class ListZero
    {
        public ListZero() { }
        //Main part:
        //List<int> testList1 = new List<int>() { 0, 1, 0, 1, 2, 0, 5, 0 };
        //List<int> testList2 = new List<int>() { 1, 1, 2, 3, 0, 0, 0 };
        ////testList1.Add(4);
        //ListZero n = new ListZero();
        //n.Sort(testList1);
        public void Sort(List<int> l) {
            //move zeros to beginning of a List
            List<int> sorted = new List<int>();
            List<int> withoutZero = new List<int>(l);
            foreach (int i in l){
                if (i == 0)
                {
                    sorted.Add(0);
                    withoutZero.Remove(0);
                }
            }
            sorted.AddRange(withoutZero);
            PrintList(l);
            PrintList(sorted);
            Console.ReadLine();
        }
        public void PrintList(List<int> l)
        {
            foreach (int i in l)
            {
                Console.Write(i.ToString());
            }
            Console.Write("\n");
        }
    }
}
