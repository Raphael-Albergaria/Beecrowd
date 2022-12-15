namespace IdadeEmDias_1020;
class Program
{
    static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());
        int ano = numero / 365;
        int mes = (numero % 365) / 30;
        int dias = (numero % 365) % 30;

        Console.WriteLine($"{ano} ano(s)");
        Console.WriteLine($"{mes} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }
}



