using System;

namespace CA_GrössterPrimfaktor
{
    class Program
    {
        static bool IsPrim(decimal _zahl)
        {
            bool ret_ = true;
            if (_zahl % 2 == 0)
            {
                ret_ = false;
            }
            for (int j = 3; j < (int)(Math.Sqrt((double)_zahl) + 1); j += 2)
            {
                if (_zahl % j == 0)
                {
                    ret_ = false;
                    break;
                }
            }
            return ret_;
        }

        static void Main(string[] args)
        {
            decimal zahl;// = 600851475143m;
            decimal lastDivisor = 2;
            Console.Write("Bitte geben Sie die zu untersuchende Zahl ein: ");
            zahl = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Größter Primfaktor von {0} \n\n",zahl);
            if (zahl%2==0)
            {
                lastDivisor = 2;
                Console.Write("Teiler: {0,6} |", 2);
            }
            for (decimal i = lastDivisor; i < zahl/2;)
            {
                if (IsPrim(zahl))
                {
                    lastDivisor = zahl;
                    break;
                }
                if (IsPrim(i))
                {
                    do
                    {
                        if (zahl % i == 0)
                        {
                            Console.Write("{0,6} |", i);
                            zahl /= i;
                            if (zahl>i)
                            {
                                lastDivisor = zahl;
                            }
                            else
                            {
                                lastDivisor = i;
                            }
                        }
                        else
                        {
                            i++;
                        }
                    } while (i < zahl);
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine("\nDer größte Primfaktor als Teiler ist: {0}.", lastDivisor);
        }
    }
}
