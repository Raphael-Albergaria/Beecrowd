using System;

namespace Diferenca_1007
{
    public class Program
    {
        public static void Main()
        {
            int A, B, C, D, DIF;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            DIF = A * B - C * D;

            Console.WriteLine($"DIFERENCA = {DIF}");
        }
    }
}