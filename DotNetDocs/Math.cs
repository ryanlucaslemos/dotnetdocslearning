using System;


namespace DotNetDocs
{
    /*
     Classe retirada da documentação da Microsoft 
    disponível em: https://docs.microsoft.com/pt-br/dotnet/csharp/codedoc
     */


    /// <sumary>
    /// Implementa funções básicas de matematica
    /// </sumary>
    /// <remarks>
    /// Essa classe possui funções de soma, subtração, multiplicação e divisão
    /// </remarks>
    public class Math
    {
        /// <summary>
        /// Adiciona dois números
        /// </summary>
        /// <returns>
        /// Retorna a soma de dois inteiros
        /// </returns>
        public static int Add(int a, int b)
        {
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
                throw new OverflowException();

            return a + b;
        }

        /// <summary>
        /// Adiciona dois números
        /// </summary>
        /// <returns>
        /// Retorna a soma de dois ponto flutuantes
        /// </returns>
        public static double Add(double a, double b)
        {
            if ((a == double.MaxValue && b > 0) || (b == double.MaxValue && a > 0))
                throw new OverflowException();

            return a + b;
        }

        /// <summary>
        /// Subtrai dois numeros
        /// </summary>
        /// <returns>
        /// Retorna o resultado da subtração de dois inteiros
        /// </returns>
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Subtrai dois numeros
        /// </summary>
        /// <returns>
        /// Retorna o resultado da subtração de dois ponto flutuantes
        /// </returns>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Retorna a multiplicação de dois números inteiros
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Retorna a multiplicação de dois números ponto flutuantes
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Retorna o resultado da divisão de dois numeros inteiros
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Divide(int a, int b)
        {
            return a / b;
        }

        /// <summary>
        /// Retorna o resultado da divisao de dois numeros ponto flutuantes
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
