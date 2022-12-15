namespace ConversaoDeTempo_1019;
class Program
{
    static void Main(string[] args)
    {
        int tempo = int.Parse(Console.ReadLine());
        int horas = tempo / 3600;
        int minutos = (tempo % 3600) /60;
        int segundos = (tempo % 3600) % 60;

        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
}

