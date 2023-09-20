using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula poupança 'While'");

        double investimento = 1000;
        double totalRetorno = 0;
        int meses = 12;
        int cont = 0;

        // Rendimento de 0.5% ao mês

        while (cont < meses)
        {
            investimento = investimento + (investimento * 0.005);
            cont += 1;
        }
        
        totalRetorno = investimento;
        Console.WriteLine("Nesses " + meses + " meses que o dinheiro será investido com um rendimento de 0.5% ao mês, lhe trará um retorno no final de R$" + totalRetorno);





    }
}