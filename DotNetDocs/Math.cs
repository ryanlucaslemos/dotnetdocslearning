using System;


namespace DotNetDocs
{
    /*
        Classe de exemplo retirada da documentação da Microsoft 
        disponível em: https://docs.microsoft.com/pt-br/dotnet/csharp/codedoc
        
        Para identificar o comentário como um comentário de documentação, deve-se utilizar três barras em vez de duas (///).
        # ----------- Significado das Tags ----------- #
            summary -> Descrição breve
            remarks -> Complemento ao summary
            returns -> Indica o que a função retorna
            value   -> semelhante ao returns mas para propriedades da classe
    */

    /// <sumary>
    /// Implementa funções básicas de matematica
    /// </sumary>
    /// <remarks>
    /// Essa classe possui funções de soma, subtração, multiplicação e divisão
    /// </remarks>
    public class Math
    {
        /// <value>
        /// Retorna o valor de PI
        /// </value>
        public static double PI { get; }

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
        /// Multiplica dois números
        /// </summary>
        /// <returns>
        /// Retorna a multiplicação de dois números inteiros
        /// </returns>
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Multiplica dois números
        /// </summary>
        /// <returns>
        /// Retorna a multiplicação de dois números ponto flutuantes
        /// </returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Divide dois números
        /// </summary>
        /// <returns>
        /// Retorna o resultado da divisão de dois numeros inteiros
        /// </returns>
        public static int Divide(int a, int b)
        {
            return a / b;
        }

        /// <summary>
        /// Divide dois números
        /// </summary>
        /// <returns>
        /// Retorna o resultado da divisão de dois ponto flutuantes
        /// </returns>
        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
