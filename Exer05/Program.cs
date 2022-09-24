/*
 * Elabore um programa que tenha como parâmetros de entrada um vetor de 3 posições
    (cujos elementos são do tipo float) e forneça como saída a média aritmética dos
    números do vetor.
 */

using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Exer05 {
    internal class Program {
        static void Main(string[] args)
        {
            float[] numeros = { 12, 3, 4 };
            Console.WriteLine($"Media: {calcularMedia(numeros)}");

        }

        static float calcularMedia(float[] n { 
            float media = 0;
            media = (n[0] + n[1] + n[2]) / 3;
            return media;
            
            }
        
        }
}
