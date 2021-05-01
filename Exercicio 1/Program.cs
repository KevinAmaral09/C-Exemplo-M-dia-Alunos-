using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade*12;
            int dias = idade*365;
            int horas = dias*24;
            int minutos = horas*60;

            Console.WriteLine("Idade em meses é: " + meses + " meses!");
            Console.WriteLine("");
            Console.WriteLine("Idade em dias é: " + dias + " dias!");
            Console.WriteLine("");
            Console.WriteLine("Idade em horas é: " + horas + " horas!");
            Console.WriteLine("");
            Console.WriteLine("Idade em minutos é: " + horas + " minutos!");
            
        }
    }
}
