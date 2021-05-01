using System;

namespace Exercicio_3
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

            Console.WriteLine("Qual o seu salario?" );
            int salario=int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int salarioReajustado=salario+(30%salario);
            Console.WriteLine("");

            if (salario<500)
            {
                Console.WriteLine("O valor do seu salário reajustado será: " + salarioReajustado + " reais");
                Console.WriteLine("");
            }
            
            else
            {
                Console.WriteLine("Você não tem direito ao aumento, consulte as informaçoes no regulamento !");
            }
        }
    }
}
