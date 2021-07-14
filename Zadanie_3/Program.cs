using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba;

            while (true)
            {
                Console.WriteLine("Podaj liczbę naturalną: ");
                liczba = Convert.ToInt32(Console.ReadLine());
                if (liczba >= 0) break;
                else Console.WriteLine("Nieprawidlowa liczba!");
            }

            if (CzyLiczbaPierwsza(liczba)) Console.WriteLine("Liczba {0} jest liczbą pierwszą!", liczba);
            else Console.WriteLine("Liczba {0} nie jest liczbą pierwszą", liczba);

            Console.ReadKey();
        }

        private static bool CzyLiczbaPierwsza(double liczba)
        {
            for (int i = 2; i < liczba; i++)
            {
                if (liczba % i == 0) return false;
            }
            return true;
        }
    }
}
