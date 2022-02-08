using System;

namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
         
            int v1=0, v2=0, v3=0;

            Console.WriteLine("Digite um valor para x:");
              x = System.Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Digite um valor para y:");
                 y = System.Convert.ToInt32(Console.ReadLine());
                if (x == y)
                {
                    Console.Clear();
                    Console.WriteLine("Por favor, digite um número diferente de x:");
                }
            }while (y == x);

                do
                {
                    Console.WriteLine("Digite um valor para z:");
                     z = System.Convert.ToInt32(Console.ReadLine());
                    if (x == z)
                    {
                      Console.Clear();
                      Console.WriteLine("Por favor, digite um número diferente de x:");
                    }else if (y == z) {
                    Console.Clear();
                    Console.WriteLine("Por favor, digite um número diferente de y:");
                }

                } while (x == z || y == z);


        //Saber quem é o maior elemento
           
            if (x>y && x > z)
            {
                v1 = x;
            }else if (y>x && y > z)
            {
                v1 = y;
            }else if(z>x && z > y)
            {
                v1 = z;
            }
        //Saber quem é o elemento do meio
           
            if((x>y && x<z) || (x<y && x > z))
            {
                v2 = x;
            }else if ((y>x && y<z) || (y<x || y>z))
            {
                v2 = y;
            }else if ((z>x && z<y)||(z<x && z>y))
            {
                v2 = z;
            }

        //Saber quem é o menor elemento

            if (x < y && x < z)
            {
                v3 = x;
            }
            else if (y < x && y < z)
            {
                v3 = y;
            }
            else if (z < x && z < y)
            {
                v3 = z;
            }

            Console.Clear ();
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
        }
    }
}
