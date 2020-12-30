using System;

namespace CA_LuckyNumbers_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie die Obergrenze der Lucky Numbers ein: ");
            int og = int.Parse(Console.ReadLine());
            int min = -1;
            int del = 0, pos =0;
            bool[] numbers = new bool[og];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = true;
            }
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                if (numbers[i]) { min = 2 * i + 1; }
                for (int j = 1; j < numbers.Length; j+=3)
                {
                    
                    if (j % (min+del) == 0 && numbers[j])
                    {
                        numbers[j] = false;
                        del++;
                    }
                    
                }

            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]) { Console.Write("{0,6} |", i*2+1); }
            }
            Console.ReadKey();

        }
    }
}
