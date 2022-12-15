namespace Media1_1005{    public class Program    {        public static void Main()        {            Double A, B, MEDIA;            A = double.Parse(Console.ReadLine());            B = double.Parse(Console.ReadLine());            A = Math.Round(A, 1);            B = Math.Round(B, 1);            MEDIA = (A * 3.5 + B * 7.5) /11 ;

            Console.WriteLine($"MEDIA = {MEDIA.ToString("F5")}");

        }    }}