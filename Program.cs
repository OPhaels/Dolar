using Calculos;
using System;

namespace Dolar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            conta res = new conta();
            double dolar = 5.10; //valor do dólar

            Console.WriteLine($"Valor da cotação do Dólar: {dolar}");
            Console.Write("Quantos dólares deseja comprar? ");
            float val = float.Parse(Console.ReadLine()); //capta a entrada do usuário
         
            res.ValorDolar = dolar;
            res.ValorPagamento = val;
            var valor = res.Resultado();
            var resultadoFinal = res.porcentagem();

            Console.WriteLine($"Valor a ser pago em reais contando com o IOF de 6% {resultadoFinal}");
            Console.ReadLine();
        }
    }
}
