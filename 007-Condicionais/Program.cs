using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 7 - Condicionais");

        string nome = "Joao";
        int idade = 22;
        int quantidadePessoas = 2;

        if (idade >= 18)
        {
            Console.WriteLine(nome + ", você pode entrar");
        }
        else
        {
            if (quantidadePessoas > 0)
            {
                Console.WriteLine(nome + " está acompanhado, pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");

            }

        }
    }
}