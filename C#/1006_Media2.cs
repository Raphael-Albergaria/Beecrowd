using System;

namespace Media1_1005
{
    public class Program
    {
        public static void Main()
        {
            Double NOTA1, NOTA2, NOTA3, MEDIA;
            NOTA1 = Math.Round(double.Parse(Console.ReadLine()),1);
            NOTA2 = Math.Round(double.Parse(Console.ReadLine()),1);
            NOTA3 = Math.Round(double.Parse(Console.ReadLine()),1);
            
            MEDIA = (NOTA1 * 2 + NOTA2 * 3 + NOTA3 * 5) / 10;

            Console.WriteLine($"MEDIA = {MEDIA.ToString("F1")}");

        }
    }
}