using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
        // Máximos e mínimos (tipos numéricos mais comuns)
        Console.WriteLine($"sbyte   : {sbyte.MinValue} .. {sbyte.MaxValue}");
        Console.WriteLine($"byte    : {byte.MinValue} .. {byte.MaxValue}");
        Console.WriteLine($"short   : {short.MinValue} .. {short.MaxValue}");
        Console.WriteLine($"ushort  : {ushort.MinValue} .. {ushort.MaxValue}");
        Console.WriteLine($"int     : {int.MinValue} .. {int.MaxValue}");
        Console.WriteLine($"uint    : {uint.MinValue} .. {uint.MaxValue}");
        Console.WriteLine($"long    : {long.MinValue} .. {long.MaxValue}");
        Console.WriteLine($"ulong   : {ulong.MinValue} .. {ulong.MaxValue}");

        // char: imprimir como número (código)
        Console.WriteLine($"char    : {(int)char.MinValue} .. {(int)char.MaxValue}");

        Console.WriteLine($"float   : {float.MinValue} .. {float.MaxValue}");
        Console.WriteLine($"double  : {double.MinValue} .. {double.MaxValue}");
        Console.WriteLine($"decimal : {decimal.MinValue} .. {decimal.MaxValue}");

        // Valores especiais (float e double)
        Console.WriteLine(float.NegativeInfinity);
        Console.WriteLine(float.PositiveInfinity);
        Console.WriteLine(float.NaN);

        Console.WriteLine(double.NegativeInfinity);
        Console.WriteLine(double.PositiveInfinity);
        Console.WriteLine(double.NaN);

        // 1) Overflow em uint (wrap-around com unchecked)
        uint uMax = uint.MaxValue;

        uint uOverflow1 = unchecked(uMax + 1); // 4294967295 + 1 -> 0
        uint uOverflow2 = unchecked(0u - 1u);  // 0 - 1 -> 4294967295

        Console.WriteLine("uint overflow (+1): " + uOverflow1);
        Console.WriteLine("uint overflow (-1): " + uOverflow2);

        // 2) Dois tipos de overflow em float (-> +Inf e -Inf)
        float fOverflowPos = float.MaxValue * 2f; // +Infinity
        float fOverflowNeg = float.MinValue * 2f; // -Infinity

        Console.WriteLine("float overflow (+): " + fOverflowPos);
        Console.WriteLine("float overflow (-): " + fOverflowNeg);

        // 3) Underflow em float (-> 0)
        float fUnderflow = float.Epsilon / 2f; // 0
        Console.WriteLine("float underflow: " + fUnderflow);


        }
    }
}
