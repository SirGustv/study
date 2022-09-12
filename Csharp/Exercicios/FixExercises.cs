using System;
using System.Globalization;

namespace FixExercises
{
    public class FixExercise
    {
        public static void FixExe1()
        {
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int bedrooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (na mesma lnha)");
            string[] vector = Console.ReadLine().Split(' ');
            string lastName = vector[0];
            int age = int.Parse(vector[1]);
            double stature = double.Parse(vector[2]);

            Console.WriteLine("-------------------");
            Console.WriteLine(name);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(stature);
        }

    }
}

namespace ConditionalStructures
{
    public class ExeProp
    {
        public static void ExeProp1()
        // Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
        // mensagem explicativa.
        {
            int value1 = int.Parse(Console.ReadLine());
            int value2 = int.Parse(Console.ReadLine());
            int soma = value1 + value2;
            Console.WriteLine("SOMA = " + soma);
        }

        // O exercício proposto 2 já foi realizado, é possível vê-lo no arquivo 'Program.cs' descrito como o método 'SegundoTeste".
        public static void ExeProp3()
        // Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
        // de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diff = (a * b) - (c * d);

            Console.WriteLine("DIFERENCA = " + diff);
        }
    }
}