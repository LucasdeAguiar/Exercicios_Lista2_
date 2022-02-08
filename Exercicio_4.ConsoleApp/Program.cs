using System;

namespace Exercicio_4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {

                Console.Clear();
                Console.WriteLine("Digite um número:");
             int n = System.Convert.ToInt32(Console.ReadLine());
             
            

                if (n % 2 == 0)
                {
                    Console.WriteLine("O número " + n + " é par.");
                  
                }
                else
                {
                    Console.WriteLine("O número " + n + " é impar.");
                   
                }

                Console.WriteLine("Deseja reiniciar o programa?(s/n)");
                   opcao = Console.ReadLine();

            } while (opcao == "s");
        }
    }
}
