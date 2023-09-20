using System;

class Programa
{
    static void Main(string[] args)
    {


        // Primeira resolução
        /*for(int i = 0; i < 100; i++)
        {
            if(i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }*/

        // Segunda resolução

        for(int i = 3; i < 100; i += 3)
        {
            Console.WriteLine(i);
        }


    }
}