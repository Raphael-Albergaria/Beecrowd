namespace NotasEMoedas_1021;
class Program
{
    static void Main(string[] args)
    {
        Double valor, nota100, nota50, nota20, nota10, nota5, nota2, moeda1, moeda50, moeda25, moeda10, moeda5, moeda01, resto;
        valor = Double.Parse(Console.ReadLine());

        Console.WriteLine("NOTAS:");
        nota100 = valor / 100;
        resto = valor % 100;
        Console.WriteLine($"{(int)nota100} nota(s) de R$ 100.00");
        nota50 = resto / 50;
        resto = resto % 50;
        Console.WriteLine($"{(int)nota50} nota(s) de R$ 50.00");
        nota20 = resto / 20;
        resto = resto % 20;
        Console.WriteLine($"{(int)nota20} nota(s) de R$ 20.00");
        nota10 = resto / 10;
        resto = resto % 10;
        Console.WriteLine($"{(int)nota10} nota(s) de R$ 10.00");
        nota5 = resto / 5;
        resto = resto % 5;
        Console.WriteLine($"{(int)nota5} nota(s) de R$ 5.00");
        nota2 = resto / 2;
        resto = resto % 2;
        Console.WriteLine($"{(int)nota2} nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        moeda1 = resto / 1;
        resto = (resto % 1)*100;
        Console.WriteLine($"{(int)moeda1} moeda(s) de R$ 1.00");
        moeda50 = resto/ 50;
        resto = resto % 50;
        Console.WriteLine($"{(int)moeda50} moeda(s) de R$ 0.50");
        moeda25 = resto / 25;
        resto = resto % 25;
        Console.WriteLine($"{(int)moeda25} moeda(s) de R$ 0.25");
        moeda10 = resto / 10;
        resto = resto % 10;
        Console.WriteLine($"{(int)moeda10} moeda(s) de R$ 0.10");
        moeda5 = resto / 5;
        resto = resto % 5;
        Console.WriteLine($"{(int)moeda5} moeda(s) de R$ 0.05");
        moeda01 = resto / 1;
        Console.WriteLine($"{(int)moeda01} moeda(s) de R$ 0.01");


       
    }
}

