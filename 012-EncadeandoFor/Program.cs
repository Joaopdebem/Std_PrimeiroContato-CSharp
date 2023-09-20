using System;

class Programa
{
    static void Main(string[] args)
    {
        // Tentando ajustar o cálculo certo

        Console.WriteLine("Executando o projeto 12 - Calcula rendimentos encadeando 'For'");

        double investimento = 1000;
        double taxaJuros = 0.005;

        int mesesSimulacao = 12;
        int anosSimulacao = 10;


        for (int anos = 1; anos <= anosSimulacao; anos++)
        {
            for (int meses = 1; meses <= mesesSimulacao; meses++)
            {
                investimento += (investimento * taxaJuros);
                Console.WriteLine(investimento + ", " + taxaJuros);
            }
            taxaJuros += 0.001;
            Console.WriteLine(investimento + ", " + taxaJuros);
        }

        Console.WriteLine("Depois de " + anosSimulacao + " anos, você terá R$" + investimento);
       
    }
}