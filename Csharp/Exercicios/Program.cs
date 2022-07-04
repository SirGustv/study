using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            PrimeiroTeste();
        }
        static void PrimeiroTeste()
        //Fazer um programa para ler o código de uma peça (peça 1), o número de peças 1, o valor unitário de cada peça 1,
        //o código de uma peça (peça 2), o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
        {
            int codPecas1, codPecas2, numPecas1, numPecas2;
            double preco1, preco2;

            Console.WriteLine("Peça 1");
            codPecas1 = int.Parse(Console.ReadLine());
            numPecas1 = int.Parse(Console.ReadLine());
            preco1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nPeça 2");
            codPecas2 = int.Parse(Console.ReadLine());
            numPecas2 = int.Parse(Console.ReadLine());
            preco2 = double.Parse(Console.ReadLine());

            double precoFinal = (preco1 * numPecas1) + (preco2 * numPecas2);

            Console.WriteLine("VALOR A PAGAR: R$ " + precoFinal);
        }
    }
}
