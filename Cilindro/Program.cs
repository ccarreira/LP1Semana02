using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Altura do cilindro: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Raio do cilindro: ");
            double r = double.Parse(Console.ReadLine());

            // Volume: V = π r² h
            double V = Math.PI * Math.Pow(r, 2) * a;

            // Área total: Sa = 2πr² + 2πrh
            double Sa = 2 * Math.PI * Math.Pow(r, 2) +
                        2 * Math.PI * r * a;

            Console.WriteLine($"Volume: {V:F3}");
            Console.WriteLine($"Área de superfície: {Sa:F3}");
        }
    }
}
