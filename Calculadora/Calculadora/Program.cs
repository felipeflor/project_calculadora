using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float a = 0;
            float x = 0;


            do {

                float n1, n2;
                Console.WriteLine("Type first number: ");
                n1 = (float) (Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Type second number: ");
                n2 = (float) (Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Wich operation you want to do? 1-Sum, 2-Minus, 3-Multiply ou 4-Division");
                int operation = Convert.ToInt32(Console.ReadLine());

                Print(operation, n1, n2);

                Console.WriteLine("Do you want to continue? 1 to yes or 2 to no");
                x = (Convert.ToInt32(Console.ReadLine()));

            } while ( x == 1 );

        }

        static float Sum(float a, float b)
        {
            float result = a + b;
            return result;
        }

        static float Minus(float a, float b)
        {
            float result = a - b;
            return result;
        }

        static float Multiply(float a, float b)
        {
            float result = a * b;
            return result;
        }

        static float Division(float a, float b)
        {
            if (difZero(b)){
                throw new Exception("it's not possible divide by zero");
            }
            float result = a / b;
            return result;

            bool difZero (float b){
                if (b == 0){
                    return true;
                } else{
                    return false;
                }
            }
        }

        static void Print(float operation, float n1, float n2)
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
