using System;
using System.Reflection.PortableExecutable;

class Programa
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;

        int salarioInteiro;
        salarioInteiro = (int)salario;

        // Um tipo inteiro com tamanho de 64bits 
        long x = 2000000000000000000;

        // Um tipo inteiro com tamanho de 16bits
        short km = 32767;

        // Um tipo flutuante com uma precisão muito maior, sendo necessário o f no final do número.
        float altura = 1.62f;


        Console.WriteLine("Fulano tem um sálario de R$" + salario + " sem as casas decimais fica R$" + salarioInteiro);
        Console.WriteLine("Esse mesmo Fulano, tem " + altura + " de altura e um carro com " + km + "Km rodado.");
        Console.WriteLine("E se eu ganhassse R$" + x + " ia ficar ultra rico.");
    }
}