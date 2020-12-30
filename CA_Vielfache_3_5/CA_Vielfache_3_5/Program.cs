using System;

namespace CA_Vielfache_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int summe3 = 0, summe5 = 0, n3=0, n5=0, og=-1;
            Console.Write("Bitte geben Sie die Obergrenze des Bereiches an: ");
            og = int.Parse(Console.ReadLine());
            for (int i = 1; i < og; i++)
            {
                if (i % 3 == 0) 
                { 
                    n3++;
                    summe3 += n3 * 3; 
                }
                if (i % 5 == 0)
                {
                    n5++;
                    summe5 += n5 * 5;
                }
            }
            Console.WriteLine("Bis {2} gibt es {0} durch drei teilbare Zahlen. Ihre Summe beträgt {1}.",
                n3, summe3, og) ;
            Console.WriteLine("Bis {2} gibt es {0} durch fünf teilbare Zahlen. Ihre Summe beträgt {1}.",
                n5, summe5,og);
            Console.ReadKey();
        }
    }
}
