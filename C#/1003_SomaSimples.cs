using System.Security.AccessControl;

namespace SomaSimples_1003
{
    public class Program
    {
        public static void Main()
        {
            int A, B, SOMA;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            SOMA = A + B;

            Console.WriteLine($"SOMA = {SOMA}");
        }
    }
}

