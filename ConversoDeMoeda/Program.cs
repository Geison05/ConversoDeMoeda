using System;
using System.Globalization;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual e a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Quantos dolares voçê ira comprar? ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double result = ConversoDeMoeda.DolarParaReal(quantia,cotacao);

            Console.WriteLine("Valor a ser pago em reais = R$ "+ result.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}