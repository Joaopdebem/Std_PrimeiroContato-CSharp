using System;

class Programa
{
    static void Main(string[] args)
    {

        // 1 Solução ( minha) Fatorial do número escolhido

        /*int numero = Convert.ToInt32(Console.ReadLine());
        int numero2 = numero;

        int fatorial = 1;
        string texto = "";

        while (numero2 > 0)
        {
            texto += numero2 + " X ";
            fatorial *= numero2;
            numero2 -= 1;
        }
        texto = texto.Substring(0, texto.LastIndexOf("X")) + "= ";
        Console.WriteLine(texto + fatorial);
        */

        // 2 Solução (Resposta) de 1 a 10

        int fatorial = 1;

        for (int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }


    }
}