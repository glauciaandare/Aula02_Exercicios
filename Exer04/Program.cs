/*
A empresa Lucro Certo paga R$ 10,00 por hora normal trabalhada, e R$ 15,00 por hora
extra. Faça um programa para calcular e imprimir o salário bruto e o salário líquido de
um determinado funcionário. Considere que o salário líquido é igual ao salário bruto
descontando-se 10% de impostos.
 */

namespace Exer04 {
    internal class Program {
        static void Main(string[] args)
        {
            double quantTrabalhada, salarioLiquido, salarioBruto, quantExtraTrabalhada;
            double horaTrabalhada = 10.00;
            double horaExtra = 15.00;

            Console.WriteLine("Informe a quantidade de horas trabalhada:");
            quantTrabalhada = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas extras trabalhada:");
            quantExtraTrabalhada = Convert.ToDouble(Console.ReadLine());

            salarioBruto = (quantTrabalhada * horaTrabalhada) + (quantExtraTrabalhada * horaExtra);
            salarioLiquido = salarioBruto - ((salarioBruto * 10) / 100);

            Console.WriteLine("Valor do sálario bruto é: " + salarioBruto + "\n");
            Console.WriteLine("Valor do sálario líquido é: " + salarioLiquido + "\n");

        }
    }
}


        