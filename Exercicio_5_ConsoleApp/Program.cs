using System;

namespace Exercicio_5_ConsoleApp
{
    internal class Program
    {

        //Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem
        //iguais deverá se somar os dois, caso contrário multiplique A por B.

        //Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
        //variável C e mostrar seu conteúdo na tela.
        static void Main(string[] args)
        {
            int a, b, c;
            string opcao;

            do
            {


                Console.Clear();
                Console.WriteLine("Digite o valor de A: ");
                a = System.Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o valor de B: ");
                b = System.Convert.ToInt32(Console.ReadLine());

                if (a == b)
                {
                    c = a + b;
                }
                else
                {
                    c = a * b;
                }

                Console.WriteLine("Valor de A: " + a);
                Console.WriteLine("Valor de B: " + b);
                Console.WriteLine("Resultado: " + c);



                Console.WriteLine("Deseja recomeçar ?(s/n)");
                opcao = Console.ReadLine();

            } while (opcao == "s");  




        }
    }
}
