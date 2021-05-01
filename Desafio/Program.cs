using System;

namespace Desafio
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

            Console.WriteLine("Quantos anos você tem?");
            int idade=int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (idade<5)
            {
                Console.WriteLine("Que pena, você ainda não pode participar");
                Console.WriteLine("");
            }

            else
            {
                if (idade<8) 
                {
                    Console.WriteLine("Você vai participar da Categoria: Infantil A");
                    Console.WriteLine("");
                }

                else 
                {
                    if (idade<11)
                    {
                        Console.WriteLine("Você vai participar da Categoria: Infantil B");
                        Console.WriteLine("");
                    }

                    else 
                    {
                        if (idade<14) 
                        {
                            Console.WriteLine("Você vai participar da Categoria: Juvenil A");
                            Console.WriteLine("");
                        }

                        else 
                        {
                            if (idade<18)
                            {
                                Console.WriteLine("Você vai participar da Categoria: Juvenil B");
                                Console.WriteLine("");
                            }
                        
                            else 
                            {
                                if (idade>=18)
                                { 
                                    Console.WriteLine("Você vai participar da Categoria: Sênior");
                                    Console.WriteLine("");
                                }
                            }
                        }
                    }
                }  
            }  
        }
    }
}
