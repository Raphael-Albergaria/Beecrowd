namespace Area_1012;
class Program
{
    static void Main(string[] args)
    {
        String[] dados = Console.ReadLine().Split(' ');
        float A = float.Parse(dados[0]);
        float B = float.Parse(dados[1]);
        float C = float.Parse(dados[2]);

        Double tri = (A*C)/2;
        Double cir = 3.14159 * Math.Pow(C,2);
        Double tra = ((A+B) * C)/2;
        Double qua = Math.Pow(B , 2);
        Double ret = A * B;

        Console.WriteLine($"TRIANGULO: {tri.ToString("F3")}");
        Console.WriteLine($"CIRCULO: {cir.ToString("F3")}");
        Console.WriteLine($"TRAPEZIO: {tra.ToString("F3")}");
        Console.WriteLine($"QUADRADO: {qua.ToString("F3")}");
        Console.WriteLine($"RETANGULO: {ret.ToString("F3")}");

    }
}

