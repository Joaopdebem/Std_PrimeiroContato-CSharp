﻿using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 9 - Escopo");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        //string textoAdicional;

        if (acompanhado == true)
        {
            string textoAdicional = "João está acompanhado";
        }
        else
        {
            string textoAdicional = "João não está acompanhado";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não pode entrar!");
        }

    }
}