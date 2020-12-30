using System;

namespace CA_LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int obergrenze = 50, z3=0, z7=0, z9=0, z13=0;
            bool[] zahlen = new bool[obergrenze];
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = true;
            }
            for (int i = 0; i < zahlen.Length; i++)
            {
               if(i > 0 && (i+1)%3==0)
                {
                    zahlen[i] = false;
                    z3++;
                    if (z3 == 4) { z3 = 1; }
                }
                if (i>0&&(i + 1)%(7+z3)  == 0)
                {
                    zahlen[i] = false;
                    z7++;
                    if (z7 == 7) { z7 = 1; }
                }
                if (i > 0 && (i + 1) % (9 + z3 + z7) == 0)
                {
                    zahlen[i] = false;
                    z9++;
                    if (z9 == 10) { z9 = 1; }
                }
                //if (i > 0 && (i + 1) % (13 + z3 + z7 + z9) == 0)
                //{
                //    zahlen[i] = false;
                //    z3 = 0;
                //    z7 = 0;
                //    z9 = 0;
                //    z13++;
                //}
                if (zahlen[i])
                {
                    Console.Write("{0,6} |", 2*i + 1);
                }
            }
            Console.ReadKey();
        }
    }
}
