using System;
using System.Collections.Generic;
using BasicType;
using FixExercises;
using SequentialStructures;
using ConditionalStructures;
using WhileStructure;
using ForStructure;

namespace Exercicios
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            ForStruct.ExeProp4();
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
        static void QuartoTeste()
        // Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau (aX² + bX + c = 0)
        // Em seguida, mostrar os valores das raízes da equação usando a fórmula de Baskara.
        // Se a equação não possuir raízes (o valor de "a" não pode ser zero, e o valor de "delta" não pode ser
        // negativo), mostrar uma mensagem "Impossivel calcular"
        {
            double a, b, c, delta, raizDelta, x1, x2;

            Console.WriteLine("Cauculo de Bhaskara");
            Console.WriteLine("Base --> aX² + bX + c = 0\n");

            Console.WriteLine("Insira o valor de 'A' (aX²)");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de 'B' (bX)");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de 'C' (c)");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            delta = (b * b) - (4 * a * c);
            raizDelta = Math.Sqrt(delta);

            if (a == 0)
            {
                Console.WriteLine("Impossível calcular (o valor 'A' não pode ser igual a zero)");
            }

            else if (delta <= 0)
            {
                Console.WriteLine("Impossível calcular (o valor de Delta não pode ser menor ou igual a zero)");
            }

            else
            {
                x1 = ((-b) + raizDelta) / (2 * a);
                x2 = ((-b) - raizDelta) / (2 * a);

                Console.WriteLine($"X1 = {x1.ToString("N5")}\n");
                Console.WriteLine($"X2 = {x2.ToString("N5")}");
            }
        }
        static void QuintoTeste()
        // Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
        // incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
        // impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
        {
            Console.WriteLine("Insira a senha");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida");
                Console.WriteLine("--------------------");
                Console.WriteLine("Insira a senha novamente");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido!");
        }
        static void SextoTeste()
        // Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
        // Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
        // essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
        {
            int n = int.Parse(Console.ReadLine());
            List<int> x = new List<int> { n };
            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < n; i++)
            {
                x.Add(int.Parse(Console.ReadLine()));

                if (x[i] >= 10 && x[i] <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}
