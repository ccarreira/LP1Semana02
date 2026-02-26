using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro-não negativo: ");
            byte n = byte.Parse(Console.ReadLine());

            Console.WriteLine(n / 2);        // divisão inteira por 2
            Console.WriteLine(n << 3);       // shift left por 3 (×8)
            Console.WriteLine(n ^ 6);        // XOR com 6
            Console.WriteLine(n > 103);      // maior que 103?

            //Operadores aritméticos
            Console.WriteLine(n % 2);      // resto da divisão por 2
            Console.WriteLine(n * 4);      // multiplicação
            Console.WriteLine(n - 1);      // decremento simples
            Console.WriteLine(++n);        // pré-incremento

            //Shift operators
            Console.WriteLine(n >> 1);     // shift right (÷2 se não houver overflow)
            Console.WriteLine(n << 1);     // shift left (×2)
            Console.WriteLine(n << 2);     // ×4
            Console.WriteLine(n >> 3);     // ÷8

            //Bitwise
            Console.WriteLine(n & 1);      // AND com 1 (verifica se é ímpar)
            Console.WriteLine(n | 8);      // OR com 8 (ativa bit 3)
            Console.WriteLine(n ^ 3);      // XOR com 3
            Console.WriteLine(~n);         // NOT bit a bit (com promoção para int)

            //Comparações booleanas
            Console.WriteLine(n == 0);
            Console.WriteLine(n != 10);
            Console.WriteLine(n <= 50);
            Console.WriteLine(n >= 128);   // sempre false para byte válido

            //Combinação lógica
            Console.WriteLine(n > 10 && n < 20);
            Console.WriteLine(n % 2 == 0);
            Console.WriteLine(n > 5 || n == 0);
            Console.WriteLine(!(n > 100));

            //Operadores compostos
            n += 5;
            n <<= 1;
            n ^= 2;
            n &= 15;

            //Variante exemplo completo
            Console.WriteLine(n >> 1);
            Console.WriteLine(n & 1);
            Console.WriteLine(n ^ 10);
            Console.WriteLine(n > 50 && n < 100);
        }
    }
}
