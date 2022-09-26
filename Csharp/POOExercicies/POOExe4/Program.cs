using System;
using System.Globalization;

namespace POOExe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Funcionary funcionary = new Funcionary();

            Console.Write("Nome: ");
            funcionary.Name = Console.ReadLine();
            Console.Write("Salário: ");
            funcionary.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionary.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + funcionary);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionary.IncreaseSalary(percent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionary);
        }
    }
}
