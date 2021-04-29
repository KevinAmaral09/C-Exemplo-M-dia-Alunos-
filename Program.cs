using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício Média dos Alunos");
            Console.WriteLine("");
            Console.WriteLine("Olá, você está prestes a saber sua média de notas!");
            Console.WriteLine("");
            Console.Write("Qual seu nome? ");
            string nomePessoa = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Bem vindo " + nomePessoa + "!!");
            Console.WriteLine("");

            Console.WriteLine("Qual é a sua primeira nota?");
            double Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Qual é a sua segunda nota?");
            double Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Qual é a sua terceira nota?");
            double Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double media = (Nota1 + Nota2 + Nota3) / 3 ;
            Console.WriteLine("");

            Console.WriteLine("A sua média é: " + media.ToString("N1"));
            Console.WriteLine("");

            if (media > 5)
            {
                Console.WriteLine("Parabéns, você foi aprovado!!");
            }
            else
            {
                Console.WriteLine("Infelizmente, você foi reprovado!!");
            }
        
        }
    }
}
