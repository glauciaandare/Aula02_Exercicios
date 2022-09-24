/*
 * Elabore um programa que tenha como parâmetros de entrada um vetor de 3 posições
    (cujos elementos são do tipo float) e forneça como saída a média aritmética dos
    números do vetor.
 */

using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Exer05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float[] numeros = { 12, 3, 4 };
            Console.WriteLine($"Media: {CalcularMedia(numeros)}");

        }

        private static float CalcularMedia(float[] n)
        {
            float media = 0;
            for (int i = 0; i < n.Length; i++)
            
                media += n[i];
                media /= n.Length;
                return media;
            

        }
    }
}
