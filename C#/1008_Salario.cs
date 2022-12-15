namespace Salario_1008
{
    public class Program
    {
        public static void Main()
        {
            int numFun, horas;
            
            numFun = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            float salario = float.Parse(Console.ReadLine());
            salario = horas * salario;

            Console.WriteLine($"NUMBER = {numFun}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2")}");
            
        }
    }
}