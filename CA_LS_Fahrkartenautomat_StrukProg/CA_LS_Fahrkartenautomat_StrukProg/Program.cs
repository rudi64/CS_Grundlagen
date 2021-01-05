using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA_LS_Fahrkartenautomat_StrukProg
{
    class Program
    {
        static void Main(string[] args)
        {
            double zuZahlenderBetrag;
            double eingezahlterGesamtbetrag;
            double eingeworfeneMuenze;
            double rueckgabebetrag;

            Console.Write("Zu zahlender Betrag (EURO): ");
            zuZahlenderBetrag = double.Parse(Console.ReadLine());

            // Geldeinwurf
            // -----------
            eingezahlterGesamtbetrag = 0.0;
            while (eingezahlterGesamtbetrag < zuZahlenderBetrag)
            {
                Console.WriteLine("Noch zu zahlen: " + (zuZahlenderBetrag - eingezahlterGesamtbetrag));
                Console.Write("Eingabe (mind. 5Ct, höchstens 2 Euro): ");
                eingeworfeneMuenze = double.Parse(Console.ReadLine());
                eingezahlterGesamtbetrag += eingeworfeneMuenze;
            }

            // Fahrscheinausgabe
            // -----------------
            Console.WriteLine("\nFahrschein wird ausgegeben");
            for (int i = 0; i < 8; i++)
            {
                Console.Write("=");               
                Thread.Sleep(250);
            }
            Console.WriteLine("\n\n");

            // Rückgeldberechnung und -Ausgabe
            // -------------------------------
            rueckgabebetrag = eingezahlterGesamtbetrag - zuZahlenderBetrag;
           if(rueckgabebetrag > 0.0)
           {
    	       Console.WriteLine("Der Rückgabebetrag in Höhe von " + rueckgabebetrag + " EURO");
            Console.WriteLine("wird in folgenden Münzen ausgezahlt:");

               while(rueckgabebetrag >= 2.0) // 2 EURO-Münzen
               {
        	      Console.WriteLine("2 EURO");
                    rueckgabebetrag -= 2.0;
               }
               while(rueckgabebetrag >= 1.0) // 1 EURO-Münzen
               {
        	      Console.WriteLine("1 EURO");
                     rueckgabebetrag -= 1.0;
               }
               while(rueckgabebetrag >= 0.5) // 50 CENT-Münzen
               {
        	      Console.WriteLine("50 CENT");
                    rueckgabebetrag -= 0.5;
               }
               while(rueckgabebetrag >= 0.2) // 20 CENT-Münzen
               {
        	      Console.WriteLine("20 CENT");
                    rueckgabebetrag -= 0.2;
               }
               while(rueckgabebetrag >= 0.1) // 10 CENT-Münzen
               {
        	      Console.WriteLine("10 CENT");
                    rueckgabebetrag -= 0.1;
               }
               while(rueckgabebetrag >= 0.05)// 5 CENT-Münzen
               {
        	      Console.WriteLine("5 CENT");
                    rueckgabebetrag -= 0.05;
               }
           }

           Console.WriteLine("\nVergessen Sie nicht, den Fahrschein\n"+
                              "vor Fahrtantritt entwerten zu lassen!\n"+
                              "Wir wünschen Ihnen eine gute Fahrt.");
           Console.ReadKey();
        }
    }
}
