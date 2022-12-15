namespace Consumo_1014;
class Program
{
    static void Main(string[] args)
    {
        int km = int.Parse(Console.ReadLine());
        float litro = float.Parse(Console.ReadLine());
        float consumo = km / litro;

        Console.WriteLine($"{consumo.ToString("F3")} km/l");
    }
}

