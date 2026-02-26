using System;

namespace FormataString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Interpolação simples
            int xx = 5;
            Console.WriteLine($"x = {xx}");

            //Formatação numérica (f — fixed point)
            double x = 3.14159;
            Console.WriteLine($"x = {x:f1}");
            Console.WriteLine($"x = {x:f3}");

            //Múltiplas variáveis
            int a = 2;
            int b = 3;
            Console.WriteLine($"a = {a}, b = {b}, soma = {a + b}");

            //alinhamento
            int n = 42;
            Console.WriteLine($"|{n,5}|");   // alinhado à direita
            Console.WriteLine($"|{n,-5}|");  // alinhado à esquerda

            //percentagem
            double p = 0.2567;
            Console.WriteLine($"Percentagem = {p:P2}");

            //notacao cientifica
            double v = 12345.6789;
            Console.WriteLine($"v = {v:E2}");

            //hexadecimal
            int m = 255;
            Console.WriteLine($"Hex = {m:X}");
            Console.WriteLine($"Hex = {m:X4}");

            //datas
            DateTime hoje = DateTime.Now;
            Console.WriteLine($"Data: {hoje:dd/MM/yyyy}");
            Console.WriteLine($"Hora: {hoje:HH:mm}");
        }
    }
}
