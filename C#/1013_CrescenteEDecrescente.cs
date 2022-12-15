namespace CrescenteEDecrescente_1013;
class Program
{
    static void Main(string[] args)
    {
        int num1, num2;
        String[] Inicio = Console.ReadLine().Split();
        num1 = int.Parse(Inicio[0]);
        num2 = int.Parse(Inicio[1]);

        while (num1 != num2)
        {

            if (num1 > num2)
            {
                Console.WriteLine("Decrescente");
            }
            else 
            {
                Console.WriteLine("Crescente");
            }       
            Inicio = Console.ReadLine().Split();
            num1 = int.Parse(Inicio[0]);
            num2 = int.Parse(Inicio[1]);
        }
    }
}

