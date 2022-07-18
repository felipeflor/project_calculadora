using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int x = 0;


            do {

                int n1, n2;
                Console.WriteLine("Type first number: ");
                n1 = (Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Type second number: ");
                n2 = (Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Wich operation you want to do? 1-Sum, 2-Minus, 3-Multiply ou 4-Division");
                int operacao = Convert.ToInt32(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        Sum(n1, n2);
                        break;

                    case 2:
                        Minus(n1, n2);
                        break;

                    case 3:
                        Multiply(n1, n2);
                        break;

                    case 4:
                        Division(n1, n2);
                        break;
                }

                
                static int Sum(int a, int b)
                {
                    int result = a + b;
                    return result;
                    Console.WriteLine(a + " + " + b + " = " + result);
                }

                static int Minus(int a, int b)
                {
                    int result = a - b;
                    return result;
                    Console.WriteLine(a + "-" + b + " = " + result);
                }

                static int Multiply(int a, int b)
                {
                    int result = a * b;
                    return result;
                    Console.WriteLine(a + "x" + b + " = " + result);
                }

                static int Division(int a, int b)
                {
                    int result = a / b;
                    return result;
                    Console.WriteLine(a + "/" + b + " = " + result);
                }

                

                Console.WriteLine("Do you want to continue? 1 to yes ou 2 to no");
                x = (Convert.ToInt32(Console.ReadLine()));

            } while ( x == 1 );

        }
    }
}
