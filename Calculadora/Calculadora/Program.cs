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
                int operation = Convert.ToInt32(Console.ReadLine());

                Print(operation, n1, n2);

                Console.WriteLine("Do you want to continue? 1 to yes or 2 to no");
                x = (Convert.ToInt32(Console.ReadLine()));

            } while ( x == 1 );

        }

        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static int Minus(int a, int b)
        {
            int result = a - b;
            return result;
        }

        static int Multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }

        static int Division(int a, int b)
        {
            int result = a / b;
            return result;
        }

        static void Print(int operation, int n1, int n2)
        {
            switch (operation)
            {
                case 1:
                    Console.WriteLine(n1 + " + " + n2 + " = " + Sum(n1, n2));
                    break;

                case 2:
                    Console.WriteLine(n1 + "-" + n2 + " = " + Minus(n1, n2));
                    break;

                case 3:
                    Console.WriteLine(n1 + "x" + n2 + " = " + Multiply(n1, n2));
                    break;

                case 4:
                    Console.WriteLine(n1 + "/" + n2 + " = " + Division(n1, n2));
                    break;
            }
        }

    }
}
