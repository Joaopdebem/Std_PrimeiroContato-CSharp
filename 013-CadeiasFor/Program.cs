using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 13 - Cadeias For");

        string asterisco = "*";
        int quantidade = 10;

        for(int i = 1; i <= quantidade; i++)
        {
            Console.WriteLine(asterisco);
            asterisco += "*";
        }



    }
}