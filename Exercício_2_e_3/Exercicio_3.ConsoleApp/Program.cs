using System;

namespace Exercicio_3.ConsoleApp
{
    internal class Program
    {
        //A fórmula é IMC = peso / (altura) ²
        //Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a tabela abaixo.

        //IMC em adultos Condição
        //Abaixo de 18,5 Abaixo do peso
        //Entre 18,5 e 25 Peso normal
        //Entre 25 e 30 Acima do peso
        //Acima de 30 obeso


        static void Main(string[] args)
        {
            
            double peso=0,altura=0,imc;
            int idade;
            string opcao;

            do
            {

                Console.Clear();
                Console.WriteLine("Informe sua idade:");
                idade = System.Convert.ToInt32(Console.ReadLine());

                if (idade >= 18)
                {

                    Console.WriteLine("Digite seu peso:(kg)");
                    peso = System.Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite sua altura:(cm)");
                    altura = System.Convert.ToDouble(Console.ReadLine());

                    imc = (peso / (altura * altura) * 10000);
                    imc = Math.Round(imc, 1);

                    if (imc < 18.5)
                    {
                        Console.WriteLine("Seu imc é: " + imc);
                        Console.WriteLine("Você está abaixo do peso.");
                    }
                    else if (imc >= 18.5 && imc <= 25)
                    {
                        Console.WriteLine("Seu imc é: " + imc);
                        Console.WriteLine("Você está com o peso normal.");
                    }else if (imc>25 && imc <=30)
                    {
                        Console.WriteLine("Seu imc é: " + imc);
                        Console.WriteLine("Você está acima do peso.");
                    }else if (imc > 30)
                    {
                        Console.WriteLine("Seu imc é: " + imc);
                        Console.WriteLine("Você está obeso.");
                    }


                }
                else
                {
                    Console.WriteLine("Desculpe, mas o programa está configurado para indivíduos de maioridade ");
                }


                Console.WriteLine("Deseja recomeçar? (s/n)");
                    opcao = Console.ReadLine();

             

            } while (opcao == "s");
           

        }
    }
}
