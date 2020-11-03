using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    /// <summary>
    /// Diese Funktion startet das Programm
    /// </summary>
    /// <param name="args">Kommandozeilenparameter und so</param>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World.....TEST");
            Console.WriteLine("test 2");
            Console.WriteLine("te 3");
            Console.WriteLine("test 4   ");
            #region Schleifen
            int beginn = 0;

            while (beginn < 10)
            {
                int v = beginn++;
                Console.WriteLine("Der Wert von Anfang ist: " +beginn);
            }

            if (1 > 2) //testet einen Ausdruck ob er TRUE oder FALSE ist
            {

                // wenn 1 grösser ist als 2
            }

            if (1 < 2)
            {

                // wen 1 kleiner als 2
            }

            else
            {
                //in jeden anderen Fall
            }

            if (1 < 2 && 3 > 2)
            {
                //wenn beide Bedingungen erfüllt sind
            }

            for (int counter = 0; counter < 10; counter++)
            {

            }

            List<int> ListofNumbers = new List<int>();
            foreach (var item in ListofNumbers)
            {
                
            }
            #endregion Schleifen

            Console.WriteLine("Teste switch in c#");


            int variable_a = 10;


        switch (variable_a)
            {
                case 1:
                    Console.WriteLine("Die Zahl ist 1");
                    break;

                case 10:
                    Console.WriteLine("Die Zahl ist 10");
                    break;

                default:
                    Console.WriteLine("Die Zahl ist weder 1 moch 10");
                    break;
            }

        }

    }
}