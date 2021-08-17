using System;
using System.Collections.Generic;

namespace quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new();
            List<int> test = new List<int>();
            for(int i = 0; i < 6; i++)
            {
                test.Add(r.Next(20));
            }
            test = sort(test);
            foreach (int i in test) Console.Write(" " + i);
        }

        public static List<int> sort(List<int> unsorted)
        {
            if(unsorted.Count < 1)
            {
                return unsorted;
            }
            Random r = new();
            List<int> high = new List<int>();
            List<int> low = new List<int>();
            List<int> piv = new List<int>();
            int pi = unsorted[r.Next(unsorted.Count-1)];
            List<int> maybesorted = new List<int>();
            foreach (int i in unsorted)
            {
                if(i == pi)
                {
                    piv.Insert(piv.Count, i);
                }
                else if(i > pi)
                {
                    high.Insert(high.Count,i);
                }
                else
                {
                    low.Insert(low.Count,i);
                }
            }
            foreach (int i in low)
            {
                maybesorted.Insert(maybesorted.Count, i);
            }
            foreach (int i in piv)
            {
                maybesorted.Insert(maybesorted.Count, i);
            }
            foreach (int i in high)
            {
                maybesorted.Insert(maybesorted.Count, i);
            }
            for (int i = 1; i < maybesorted.Count; i++)
            {
                
                if (maybesorted[i - 1] > maybesorted[i])
                {
                    low = sort(low);
                    high = sort(high);
                    break;
                }
            }
            List<int> sorted = new List<int>();
            foreach (int i in low)
            {
                sorted.Insert(sorted.Count, i);
            }
            foreach (int i in piv)
            {
                sorted.Insert(sorted.Count, i);
            }
            foreach (int i in high)
            {
                sorted.Insert(sorted.Count, i);
            }
            return sorted;
        }
    }
}
