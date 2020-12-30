using System;

namespace CA_FibonacciReihe_Obergrenze
{
    class Program
    {
        static void Main(string[] args)
        {
            int vor=1, nach =2, og=-1, hilf;
            Console.Write("Bitte geben Sie die Obergrenze des Bereiches an: ");
            og = int.Parse(Console.ReadLine());
            Console.Write("Die Fibonaccifolge bis {0}: ", og);
            while (vor<og)
            {
                Console.Write("{0,6} |", vor);
                hilf = nach;
                nach += vor;
                vor = hilf;
            }
            Console.ReadKey();
        }
    }
}
