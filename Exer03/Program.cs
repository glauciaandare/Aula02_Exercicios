/*
 * As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se
    forem compradas pelo menos 12. Escreva um programa que leia o número de maçãs
    compradas, calcule e escreva o custo total da compra. 
 */

namespace Exer03 {
    internal class Program {
        static void Main(string[] args)
        {
            double valor;

            Console.WriteLine("Informe a quantidade de maças, que deseja comprar: \n");
            int maca = Convert.ToInt32(Console.ReadLine());

            if (maca < 12)
            {
                valor = (maca * 1.30);
            } else {
                valor = (maca * 1.00);
            }
            Console.WriteLine("O valor da compra das maças é de: " + "R$" + valor );

            

            }
        }
    }
