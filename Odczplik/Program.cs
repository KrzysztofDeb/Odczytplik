using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odczplik
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc = 0;
            List<List<string>> punkt = new List<List<string>>();
            string[] linia = File.ReadAllLines(@"..\..\..\Rodział1.txt");
            for (int i = 0; i < linia.Length; i++)
            {
                punkt.Add(new List<string>());
                ilosc++;
                foreach (string slowo in linia[i].Split(',', ' ', ':'))
                {
                    punkt[i].Add(slowo);
                }
            }
            double liczba = 0;

            for (int i = 0; i < ilosc; i++)
            {
                liczba = 0;
                for (int j = 2; j < 6; j++)
                {
                    liczba += Convert.ToDouble(punkt[i][j]);

                }
                if (liczba >= 50)
                {
                    Console.WriteLine(punkt[i][0] + " " + punkt[i][1] + " zdobył " + liczba + " punktów i zdał egzamin");
                }
                else if (liczba < 50)
                {
                    Console.WriteLine(punkt[i][0] + " " + punkt[i][1] + " zdobył " + liczba + " punktów i nie zdał egzaminu");
                }
            }
            Console.ReadLine();
        }

    }
}
