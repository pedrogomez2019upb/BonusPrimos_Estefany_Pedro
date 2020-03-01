using System;
using System.Collections.Generic;

namespace NumerosPrimos_Estefany_Pedro
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numPrueba = 2;
            int numero;
            List<int> factoresP = new List<int>();
            string input = Console.ReadLine();
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero != 1)
            {
                if (numero % numPrueba == 0)
                {
                    factoresP.Add(numPrueba);
                    numero = numero / numPrueba;
                }
                else
                {
                    numPrueba += 1;
                }

            }
            foreach (int i in factoresP)
            {
                Console.WriteLine(i);
            }
        }
    }
}
