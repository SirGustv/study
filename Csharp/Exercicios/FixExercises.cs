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

namespace SequentialStructures
{
    public class SequentStructure
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

        public static void ExeProp4()
        // Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
        // hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
        // decimais.
        {
            int numFunc = int.Parse(Console.ReadLine());
            int hoursJob = int.Parse(Console.ReadLine());
            double hourValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salary = (double)hoursJob * hourValue;

            Console.WriteLine("NUMBER = " + numFunc);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));

        }

        public static void ExeProp5()
        // Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
        // código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
        {
            string[] parts1 = Console.ReadLine().Split(' ');
            int codParts1 = int.Parse(parts1[0]);
            int numParts1 = int.Parse(parts1[1]);
            double valueUnit1 = double.Parse(parts1[2], CultureInfo.InvariantCulture);

            string[] parts2 = Console.ReadLine().Split(' ');
            int codParts2 = int.Parse(parts2[0]);
            int numParts2 = int.Parse(parts2[1]);
            double valueUnit2 = double.Parse(parts2[2], CultureInfo.InvariantCulture);

            double totalValue = (double)(numParts1 * valueUnit1) + (numParts2 * valueUnit2);

            Console.WriteLine("VALOR A PAGAR: R$ " + totalValue.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void ExeProp6()
        // Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
        // a) a área do triângulo retângulo que tem A por base e C por altura.
        // b) a área do círculo de raio C. (pi = 3.14159)
        // c) a área do trapézio que tem A e B por bases e C por altura.
        // d) a área do quadrado que tem lado B.
        // e) a área do retângulo que tem lados A e B.
        {
            string[] values = Console.ReadLine().Split(' ');
            double A = double.Parse(values[0], CultureInfo.InvariantCulture);
            double B = double.Parse(values[1], CultureInfo.InvariantCulture);
            double C = double.Parse(values[2], CultureInfo.InvariantCulture);

            double triangle = A * C / 2.0;
            double circle = 3.14159 * C * C;
            double trapeze = (A + B) / 2.0 * C;
            double square = B * B;
            double rectangle = A * B;

            Console.WriteLine("TRIANGULO: " + triangle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapeze.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + square.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + rectangle.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

namespace ConditionalStructures
{
    public class CondtStructure
    {
        public static void ExeProp1()
        // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
        {
            int number = int.Parse(Console.ReadLine());
            if (number >= 0)
                Console.WriteLine("NAO NEGATIVO");
            else
                Console.WriteLine("NEGATIVO");
        }

        public static void ExeProp2()
        // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");
        }

        public static void ExeProp3()
        // Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
        // Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
        // ordem crescente ou decrescente.
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            if (A % B == 0 || B % A == 0)
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao Sao Multiplos");
        }

        public static void ExeProp4()
        // Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
        // começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
        {
            string[] values = Console.ReadLine().Split(' ');
            int hour1 = int.Parse(values[0]);
            int hour2 = int.Parse(values[1]);

            int duration;

            if (hour1 < hour2)
                duration = hour2 - hour1;
            else
                duration = 24 - hour1 + hour2;

            Console.WriteLine($"O JOGO DUROU {duration} HORA(S)");
        }

        public static void ExeProp5()
        // Escreva um programa que leia o código de um item e a quantidade deste item. A
        // seguir, calcule e mostre o valor da conta a pagar.
        {
            string[] request = Console.ReadLine().Split(' ');
            double cod = double.Parse(request[0]);
            double qntd = double.Parse(request[1]);

            double price = 0.0;

            if (cod == 1)
                price = 4.00 * qntd;
            else if (cod == 2)
                price = 4.50 * qntd;
            else if (cod == 3)
                price = 5.00 * qntd;
            else if (cod == 4)
                price = 2.00 * qntd;
            else
                price = 1.50 * qntd;

            Console.WriteLine("Total: R$ " + price.ToString("F2"));
        }
        public static void ExeProp6()
        // Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
        // seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
        // nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
        {
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (value >= 0.0 && value <= 25.0)
                Console.WriteLine("Intervalo (0,25)");
            else if (value > 25.0 && value <= 50.0)
                Console.WriteLine("Intervalo (25,50)");
            else if (value > 50.0 && value <= 75.0)
                Console.WriteLine("Intervalo (50,75)");
            else if (value > 75.0 && value <= 100.0)
                Console.WriteLine("Intervalo (75,100)");
            else
                Console.WriteLine("Fora de Intervalo");
        }

        public static void ExeProp7()
        // Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
        // de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
        // ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
        // Se o ponto estiver na origem, escreva a mensagem “Origem”.
        // Se o ponto  estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
        // situação.
        {
            string[] values = Console.ReadLine().Split(' ');
            double x = double.Parse(values[0]);
            double y = double.Parse(values[1]);

            if (x == 0 && y == 0)
                Console.WriteLine("Origem");
            else if (x == 0.0)
                Console.WriteLine("Eixo X");
            else if (y == 0.0)
                Console.WriteLine("Eixo Y");
            else if (x > 0 && y > 0)
                Console.WriteLine("Q1");
            else if (x > 0 && y < 0)
                Console.WriteLine("Q4");
            else if (x < 0 && y > 0)
                Console.WriteLine("Q2");
            else
                Console.WriteLine("Q3");
        }

        public static void ExeProp8()
        // Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
        // que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
        // qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
        // Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
        // mostre o valor que esta pessoa deve pagar de Imposto de Renda.
        // Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
        // salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
        // de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
        // duas casas decimais.
        {
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double tax;

            if (value <= 2000.00)
                tax = 0.0;
            else if (value <= 3000.0)
                tax = (value - 2000.0) * 0.08;
            else if (value <= 4500.0)
                tax = (value - 3000.0) * 0.18 + 1000.0 * 0.08;
            else
                tax = (value - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            if (tax == 0.0)
                Console.WriteLine("Isento");
            else
                Console.WriteLine("R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

namespace WhileStructure
{
    public class WhileStruct
    {
        public static void ExeProp1()
        // Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
        // incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
        // impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
        {
            int password = int.Parse(Console.ReadLine());
            while (password != 2002)
            {
                Console.WriteLine("Senha Inválida");
                password = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
        public static void ExeProp2()
        // Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
        // cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
        // menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
        {
            string[] entry = Console.ReadLine().Split(' ');
            int x = int.Parse(entry[0]);
            int y = int.Parse(entry[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                    Console.WriteLine("Primeiro");
                else if (x > 0 && y < 0)
                    Console.WriteLine("Quarto");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Terceiro");
                else
                    Console.WriteLine("Segundo");
                entry = Console.ReadLine().Split(' ');
                x = int.Parse(entry[0]);
                y = int.Parse(entry[1]);
            }
        }
    }
}