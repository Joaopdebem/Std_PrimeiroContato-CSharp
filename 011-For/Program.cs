using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11 - Calcula poupança 'For'");

        double investimento = 1000;
        double totalRetorno = 0;
        double rendimento = 1.005;

        int meses = 12;

        // Rendimento de 0.5% ao mês

        //for (int i = 0; i < meses; i++){}
        for (int cont = 0; cont < meses; cont++)
        {
            //investimento = investimento * rendimento;
            investimento *= rendimento;
        }

        totalRetorno = investimento;
        Console.WriteLine("Nesses " + meses + " meses que o dinheiro será investido com um rendimento de 0.5% ao mês, lhe trará um retorno no final de R$" + totalRetorno);


    }
}