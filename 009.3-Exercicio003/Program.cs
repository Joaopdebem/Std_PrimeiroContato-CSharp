using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;
        double imposto = 0;

        double primeiroPisoIR = (salario * 0.075) - 142.0;
        double segundoPisoIR = (salario * 0.15) - 350.0;
        double terceiroPisoIR = (salario * 0.225) - 636;
        double quartoPisoIR = (salario * 0.275) - 869;



        if (salario >= 1900.0 && salario <= 2800.0)
        {
            imposto = primeiroPisoIR;
            Console.WriteLine("O salario pertence ao primeiro piso da alíquota, com IR de 7.5%, com a dedução de R$142, fica a pagar R$" + imposto);
        }
        if(salario >= 2800.01 && salario <= 3751.0)
        {
            imposto = segundoPisoIR;
            Console.WriteLine("O salario pertence ao segundo piso da alíquota, com IR de 15%, com a dedução de R$350, fica a pagar R$" + imposto);
        }
        if(salario >= 3751.01 && salario <= 4664.0)
        {
            imposto = terceiroPisoIR;
            Console.WriteLine("O salario pertence ao terceiro piso da alíquota, com IR de 22.5%, com a dedução de R$636, fica a pagar R$" + imposto);
        }
        if(salario >=4664.01)
        {
            imposto = quartoPisoIR;
            Console.WriteLine("O salario pertence ao quarto e último piso da alíquota, com IR de 27.5%, com a dedução de R$869, fica a pagar R$" + imposto);
        }


    }
}