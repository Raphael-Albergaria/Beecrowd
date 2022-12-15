namespace AreaDoCirculo_1002
{
	public class Program
	{
		public static void Main()
		{
			double raio, PI;
			raio = double.Parse(Console.ReadLine());
			PI = 3.14159 * Math.Pow(raio,2);

            Console.WriteLine($"A={PI:F}");
		}
	}
}