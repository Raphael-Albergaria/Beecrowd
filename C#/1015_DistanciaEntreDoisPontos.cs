using System;

namespace DistanciaEntreDoisPontos_1015;
class Program
{
    static void Main(string[] args)
    {
        String[] p1 = Console.ReadLine().Split(' ');
        Double x1 = Double.Parse(p1[0]);
        Double y1 = Double.Parse(p1[1]);


        String[] p2 = Console.ReadLine().Split(' ');
        Double x2 = Double.Parse(p2[0]);
        Double y2 = Double.Parse(p2[1]);

        Double distancia = (Math.Pow(x2 - x1, 2))+(Math.Pow(y2 - y1, 2));
        distancia = Math.Sqrt(distancia);

        Console.WriteLine($"{distancia.ToString("F4")}");
    }
}

