using System;
using System.Transactions;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 8 - Condicionais bolean");

        int idadeJoao = 22;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;


        if (idadeJoao >= 18 && acompanhado)
        {
            Console.WriteLine("Pode entrar!");
        }
        else 
        {
            Console.WriteLine("Não pode entrar");
        }





    }
}