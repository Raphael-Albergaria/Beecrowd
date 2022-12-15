namespace Esfera_1011;
class Program
{
    static void Main(string[] args)
    {
        Double raio = double.Parse(Console.ReadLine());
        Double pi = 3.14159;
        Double volume = (4 / 3.0) * pi * Math.Pow(raio, 3);

        Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
    }
}

