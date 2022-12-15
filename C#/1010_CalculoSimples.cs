namespace CalculoSimples_1010;
class Program
{
    static void Main(string[] args)
    {
        string[] Compra1 = Console.ReadLine().Split(' ');
        int peca1 = int.Parse(Compra1[0]);
        int numero1 = int.Parse(Compra1[1]);
        double valor1 = double.Parse(Compra1[2]);

        string[] Compra2 = Console.ReadLine().Split(' ');
        int peca2 = int.Parse(Compra2[0]);
        int numero2 = int.Parse(Compra2[1]);
        double valor2 = double.Parse(Compra2[2]);

        double total = numero1 * valor1 + numero2 * valor2;

        Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2")}");
    }
}

