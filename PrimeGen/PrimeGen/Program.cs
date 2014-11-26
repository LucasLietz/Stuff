using System;

namespace PrimeGen
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("PrimGen - Geben Sie ein, bis wohin Sie Primzahlen haben möchten: ");
            var primLimit = Convert.ToInt32(Console.ReadLine());

            //2 ist die einzig gerade Primzahl ==> kann immer angegeben werden.
            Console.WriteLine("2");

            //wir können unser Programm daher bei 3 starten
            //aus performace zwecken nehmen wir direkt nur alle ungeraden zahlen
            for (var odd = 3; odd <= primLimit; odd += 2)
            {
                var isPrime = true;
                //hier holen wir uns die divisoren(?)
                //wir können hier jeweils die wurzel nehmen, da damit die anzahl der teiler ermittelt werden kann.
                //außerdem ist das auch wieder performanter
                for (var z = 2; z <= Math.Sqrt(odd); z++)
                {
                    //prüfung auf rest 0, also ohne rest, was automatisch anzeigt, ob die zahl teiler hat.
                    if (odd % z == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(odd);
                }
            }
            Console.ReadLine();
        }
    }
}