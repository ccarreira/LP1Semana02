using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //******************************* ex1

            Console.Write("Insere número inteiro: ");
            sbyte n = sbyte.Parse(Console.ReadLine());

            Console.WriteLine(--n);  // decremento
            Console.WriteLine(++n);  // incremento

            //******************************* ex2 

            int i1 = 3;
            int i2 = 1;
            int i3 = -8;
            int x = 2;

            x = i1 - i3;
            // Subtração simples: calcula a diferença entre i1 e i3
            x = i3 / i1;
            // Divisão inteira: divide i3 por i1 (descarta parte decimal)
            x += i2;
            // Operador composto: equivalente a x = x + i2
            x *= i1;
            // Operador composto: equivalente a x = x * i1
            x %= i2 - 0b1001;
            // Resto da divisão (módulo).
            // 0b1001 é literal binário (9 em decimal).
            // Primeiro calcula (i2 - 9), depois x recebe o resto da divisão por esse valor.
            x = i1 << 2;
            // Left shift: desloca os bits de i1 duas posições à esquerda.
            // Equivale a multiplicar por 2^2 (×4), se não houver overflow.
            x <<= x;
            // Left shift composto: desloca os bits de x para a esquerda
            // o número de posições indicado pelo próprio valor de x.
            x &= 0x21AD ^ i1;
            // XOR bit a bit entre 0x21AD (literal hexadecimal) e i1.
            // Depois AND bit a bit entre x e o resultado dessa operação.
            x = ~(i1 | i3);
            // OR bit a bit entre i1 e i3.
            // Em seguida aplica NOT bit a bit (inversão de todos os bits).
            Console.WriteLine(x);

            //************************************** ex3

            float f1 = 1.4f;
            float f2 = -13.7f;
            bool b1 = true;
            bool b2 = false;
            bool xx = true;
            //Short-circuit evaluation (avaliação de curto-circuito)
            //É um mecanismo em que a segunda expressão só é avaliada se 
            //for necessário para determinar o resultado lógico.
            //Em C#, aplica-se a:
            //&& (AND lógico)
            //|| (OR lógico)
            //ex:bool xx = false && Metodo(); Metodo nao executa


            xx = true && false;
            // AND lógico: verdadeiro apenas se ambos forem true.
            // Resultado: false

            xx = !true || false;
            // NOT lógico aplicado a true → false.
            // OR lógico: false || false → false

            xx = true ^ b2;
            // XOR lógico: true se os valores forem diferentes.
            // Se b2 for false → resultado é true.

            xx &= f2 < f1;
            // Operador composto AND lógico.
            // Primeiro avalia (f2 < f1), depois:
            // x = x && (f2 < f1), 
            // porque um deles é bool & faz de && mas sem short circuit

            xx ^= !(f2 != f1);
            // Avalia (f2 != f1). Sao diferentes?
            // Aplica NOT ao resultado. Negacao
            // Depois aplica XOR lógico com o valor atual de x.

            xx |= !true ^ b1;
            // !true → false.
            // XOR entre false e b1.
            // Depois OR lógico composto:
            // x = x || (resultado do XOR)

            xx = b1 && b2 && !(f1 >= f2);
            // AND encadeado.
            // Só é true se:
            // b1 for true,
            // b2 for true,
            // e (f1 >= f2) for false.

            xx &= b1 ^ b2 ^ (f1 == f2);
            // XOR encadeado entre:
            // b1, b2 e o resultado de (f1 == f2).
            // Depois AND lógico composto com x.

            xx ^= !(b1 || b2);
            // OR lógico entre b1 e b2.
            // Aplica NOT.
            // Depois XOR lógico composto com x.

            Console.WriteLine(x);


            // **************************** EX 4

        }
    }
}
