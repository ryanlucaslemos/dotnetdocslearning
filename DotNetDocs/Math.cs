using System;


namespace DotNetDocs
{
    /*
     Classe retirada da documentação da Microsoft 
    disponível em: https://docs.microsoft.com/pt-br/dotnet/csharp/codedoc
     */
    public class Math
    {
        public static int Add(int a, int b)
        {
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
                throw new OverflowException();

            return a + b;
        }


        public static double Add(double a, double b)
        {
            if ((a == double.MaxValue && b > 0) || (b == double.MaxValue && a > 0))
                throw new OverflowException();

            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }


        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
