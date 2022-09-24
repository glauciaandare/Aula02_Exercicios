/*
 * Elabore um programa que tenha como parâmetros de entrada um vetor de 3 posições
    (cujos elementos são do tipo float) e forneça como saída a média aritmética dos
    números do vetor.
 */

using System;
using System.Globalization;

namespace Exer05 {
    internal class Program {
        static void Main(string[] args)
        {
            int posicao;
            double[] vet;

            posicao = Convert.ToInt32(Console.ReadLine());
            vet = new double[posicao];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < posicao; i++) {

               vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            
            }

            double soma = 0;
            for (int i = 0; i < posicao; i++) { 
                
                soma += vet[i];
            }   

            double media = soma / posicao;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}