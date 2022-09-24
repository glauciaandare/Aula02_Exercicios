/*
 * Escreva um programa que armazene o valor 10 em uma variável A e o valor 20 em
    uma variável B. A seguir (utilizando apenas atribuições entre variáveis) troque os seus
    conteúdos fazendo com que o valor que está em A passe para B e vice-versa. Ao final,
    escrever os valores que ficaram armazenados nas variáveis.
 * 
*/

namespace Exer01 {
    internal class Program {
        static void Main(string[] args) {

            int variavelA = 10;
            int variavelB = 20;
            int troca;

            troca = variavelA;
            variavelA = variavelB;
            variavelB = troca;

            Console.WriteLine("*****Valores após a troca***** \n");
            Console.WriteLine("VariávelA = " + variavelA + "\n");
            Console.WriteLine("VariávelB = " + variavelB + "\n");

        }

            
        
    }
}