using System;
using System.Globalization;

namespace BasicType
{
    public class BasicTypeExe
    {
        public static void Exe1()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.23456700;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}  -   preço: {preco1:F2}");
            Console.WriteLine($"{produto2}   -   preço: {preco2:F2}\n");

            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}\n", idade, codigo, genero);

            Console.WriteLine("Medida com oito casas decimais: " + medida);
            Console.WriteLine($"Aredondado: {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString(CultureInfo.InvariantCulture));
        }
    }
}