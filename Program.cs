using System;

namespace CalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
           [console: CalculadoraIdade] Calcule a sua idade em dias.
           Ex.:
           Eu nasci em 07/09/1981 e já vivi 14128 dias.
           */

           

            DateTime MeuNascimento = new DateTime (2004, 02, 20, 03, 00, 00);

            DateTime ValorAtual = DateTime.Now;

            // Este meu ValorAtual representa o dia em que estamos para ser realizada a subtração.

            TimeSpan NovoValorAtual = ValorAtual - MeuNascimento;

            // Este NovoValorAtual é o que representa a subtração = valor de dias que estou vivo.

            int ValorAtualSecundario = NovoValorAtual.Days;

            // Na resposta optei por colocar diretamente a data em que nasci para identificar melhor a programação.

            Console.WriteLine($"Eu nasci em 20/02/2004 e já vivi {ValorAtualSecundario} dias.");
        }
    }
}
