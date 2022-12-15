namespace Cedulas_1018;
class Program
{
    static void Main(string[] args)
    {
        
        int valor = int.Parse(Console.ReadLine());

        int nota100 = valor / 100;
        int resto = valor % 100;
        int nota50 = resto / 50;
        resto = resto % 50;
        int nota20 = resto / 20;
        resto = resto % 20;
        int nota10 = resto / 10;
        resto = resto % 10;
        int nota5 = resto / 5;
        resto = resto % 5;
        int nota2 = resto / 2;
        resto = resto % 2;
        int nota1 = resto / 1;

       Console.WriteLine($"{valor}");
       Console.WriteLine($"{nota100} nota(s) de R$ 100,00");
       Console.WriteLine($"{nota50} nota(s) de R$ 50,00");
       Console.WriteLine($"{nota20} nota(s) de R$ 20,00");
       Console.WriteLine($"{nota10} nota(s) de R$ 10,00");
       Console.WriteLine($"{nota5} nota(s) de R$ 5,00");
       Console.WriteLine($"{nota2} nota(s) de R$ 2,00");
       Console.WriteLine($"{nota1} nota(s) de R$ 1,00");

    }
}

