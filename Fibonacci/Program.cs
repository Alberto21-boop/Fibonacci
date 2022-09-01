using System;

namespace Fibonacci;

public class Program
{
    static void Main(string[] args)
    {
        //Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
        //(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número,
        //ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

        int A, B, C;
        B = 1;
        C = 0;
        A = 0;

        Console.WriteLine("Vamos consultar a sequancia Fibonacci");
        Console.Write("Entre com um numero interio = ");
        int var = int.Parse(Console.ReadLine());

        while(var > C)
        {
            C ++;
            C = A + B;
            A = B;
            B = C;
        }
        if(var == 0 || var == 1)
        {
            Console.WriteLine("O numero faz parte da sequancia Fibonacci");
        }
        else if(var == C)
        {
            Console.WriteLine("O número faz parte da sequência de Fibonacci");
        }
        else
        {
            Console.WriteLine("O número digitado não faz parte da sequência de Fibonacci.");
        }
    }
}