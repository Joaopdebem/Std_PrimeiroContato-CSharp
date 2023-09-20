using System;

class Programa
{
    static void Main(string[] args)
    {
        string funcionario;
        double salario;
        double imposto;
        int valeAlimentacao;

        Console.Write("Informe o Funcionário: ");
        funcionario = Console.ReadLine();
        salario = 3000.13;
        imposto = salario * 0.13;
        valeAlimentacao = 120;

        Console.WriteLine(funcionario + " recebe R$" + salario + ", e seu vale alimentação é de R$" + valeAlimentacao + ", porém, ele paga de imposto R$" + imposto);



    }
}