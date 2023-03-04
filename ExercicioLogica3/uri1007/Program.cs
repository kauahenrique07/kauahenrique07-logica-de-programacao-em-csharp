using System;
using System.Globalization;

namespace uri1001 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite o primeiro número: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            int C = int.Parse(Console.ReadLine());
            Console.Write("Digite o quarto número: ");
            int D = int.Parse(Console.ReadLine());

            int diferenca = (A * B - C * D);

            Console.WriteLine("\nDIFERENCA = " + diferenca);
        }
    }
}
