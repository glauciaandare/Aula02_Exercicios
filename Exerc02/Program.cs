/*
 * Faça um programa que leia a idade de uma pessoa expressa em anos, meses e dias e
    escreva a idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e
    mês com 30 dias.
 */
namespace Exerc02 {
    internal class Program {
        static void Main(string[] args)
        {
                        
            Console.WriteLine("Informe a idade: \n");
            int idade = Convert.ToInt32(Console.ReadLine());


           int ano = idade / 365;
           int mes = (idade % 365) / 30;
           int dia = (idade % 365) % 30;

            Console.WriteLine("A idade em anos, meses e dias é: " + ano + " anos " + mes + " meses " + dia + " dias");
        }
        
    }
}