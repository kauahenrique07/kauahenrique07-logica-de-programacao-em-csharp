using System;
using System.Globalization;

namespace uri1002 {
    class Program {
        static void Main(string[] args) {

            Double raio = double.Parse(Console.ReadLine());
            Double pi = 3.14159;

            Double area = pi * Math.Pow(raio, 2.0);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
