namespace GastoDeCombustivel_1017;
class Program
{
    static void Main(string[] args)
    {
        int horas = int.Parse(Console.ReadLine());
        int velocidade = int.Parse(Console.ReadLine());



        Double gasto = velocidade * horas;
        gasto = gasto / 12;

        Console.WriteLine($"{gasto.ToString("F3")}");
    }
}

