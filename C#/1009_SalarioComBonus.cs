namespace SalarioComBonus_1009;
class Program
{
    static void Main(string[] args)
    {
        string nome = Console.ReadLine();

        double salario, bonus;
        salario = double.Parse(Console.ReadLine());
        bonus = double.Parse(Console.ReadLine());
        salario = salario + bonus * 0.15;

        Console.WriteLine($"TOTAL = R$ {salario.ToString("F2")}");
    }
}

