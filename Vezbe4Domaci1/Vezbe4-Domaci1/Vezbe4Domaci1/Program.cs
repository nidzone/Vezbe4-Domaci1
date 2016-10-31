using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vezbe4Domaci1
{
    class Program
    {
        static void Main(string[] args)
        {//gitTest
            int[] koloneZamena = new int[2];

            Console.WriteLine("Unesite broj redova matrice: ");
            int redovi = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Unesite broj kolona matrice: ");
            int kolone = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Unesite elemente matrice: ");
            int[,] pocetnaMatrica = new int[kolone, redovi];
            for (int i = 0; i < pocetnaMatrica.GetLength(0); i++)
            {
                for (int j = 0; j < pocetnaMatrica.GetLength(1); j++) pocetnaMatrica[i, j] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Uneta matrica: ");
            for (int i = 0; i < pocetnaMatrica.GetLength(0); i++)
            {
                for (int j = 0; j < pocetnaMatrica.GetLength(1); j++) Console.Write(pocetnaMatrica[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("Unesite brojeve kolona koje zelite da zamenite: ");
            for (int i = 0; i < 2; i++) koloneZamena[i] = Int32.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Rezultirajuca matrica: ");
            int[] tempNiz = new int[kolone];
            for (int z = 0; z < pocetnaMatrica.GetLength(0); z++)
            {
                tempNiz[z] = pocetnaMatrica[z, koloneZamena[0]];
                pocetnaMatrica[z, koloneZamena[0]] = pocetnaMatrica[z, koloneZamena[1]];
                pocetnaMatrica[z, koloneZamena[1]] = tempNiz[z];
            }

            for (int i = 0; i < pocetnaMatrica.GetLength(0); i++)
            {
                for (int j = 0; j < pocetnaMatrica.GetLength(1); j++) Console.Write(pocetnaMatrica[i, j]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
