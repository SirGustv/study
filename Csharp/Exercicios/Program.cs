using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            TerceiroTeste();
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
        static void SegundoTeste()
        // Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
        // casas decimais conforme exemplos.Considere o valor de π = 3.14159
        // Fórmula: Area=pi . raio²
        {
            double pi, raio, area;
            pi = 3.14159;

            raio = double.Parse(Console.ReadLine());
            area = pi * (raio * raio);

            Console.WriteLine("A=" + area.ToString("N4"));
        }
        static void TerceiroTeste()
        // Com base em uma tabela de preços, faça um programa que leia o código de um item e a quantidade deste item.
        // A seguir, calcule e mostre o valor da conta a pagar.
        {
            double hotDog, xSalada, xBacon, torradaSimples, refrigerante, total;

            Console.WriteLine("Tabela de pedidos!!!");
            Console.WriteLine("\n1 - Cachorro-quente   R$4,00");
            Console.WriteLine("2 - X-Salada   R$4,50");
            Console.WriteLine("3 - X-Bacon   R$5,00");
            Console.WriteLine("4 - Torrada Simples   R$2,00");
            Console.WriteLine("5 - Refrigerante   R$1,50\n");

            Console.WriteLine("Informe o número do pedido");
            int numPedido = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de pedido");
            int quantidade = int.Parse(Console.ReadLine());

            switch (numPedido)
            {
                case 1:
                    {
                        hotDog = 4.00;
                        total = hotDog * quantidade;
                        Console.WriteLine($"Total: R$ {total.ToString("N2")}");
                        break;
                    }
                case 2:
                    {
                        xSalada = 4.50;
                        total = xSalada * quantidade;
                        Console.WriteLine($"Total: R$ {total.ToString("N2")}");
                        break;
                    }
                case 3:
                    {
                        xBacon = 5.00;
                        total = xBacon * quantidade;
                        Console.WriteLine($"Total: R$ {total.ToString("N2")}");
                        break;
                    }
                case 4:
                    {
                        torradaSimples = 2.00;
                        total = torradaSimples * quantidade;
                        Console.WriteLine($"Total: R$ {total.ToString("N2")}");
                        break;
                    }
                case 5:
                    {
                        refrigerante = 1.50;
                        total = refrigerante * quantidade;
                        Console.WriteLine($"Total: R$ {total.ToString("N2")}");
                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
