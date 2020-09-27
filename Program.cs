using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule o montante final de um investimento a juros simples.!");
            double c = 1200.00;
            double i = 0.02;
            double t = 15;
            double juros = c * i * t;
            double Montante = c + juros;
            Console.WriteLine($"{c} * {i} * {t} = {juros:C}");
            Console.WriteLine($"{c} + {juros} = {Montante:C}");


        }
    }
}
