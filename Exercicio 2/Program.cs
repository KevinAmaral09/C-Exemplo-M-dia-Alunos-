using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            string nomePessoa=Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Seja bem vindo "+nomePessoa+"!!!");
            Console.WriteLine("");
            
            Console.WriteLine("Qual seu ano de nascimento?");
            int anoNascimento=int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Qual o ano em que estamos?");
            int anoAtual=int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int idade=anoAtual-anoNascimento;
            int semanas=idade*52;
            Console.WriteLine("");

            Console.WriteLine("Você tem " + idade + " anos, ou seja, " + semanas + " semanas");
        }
    }
}
