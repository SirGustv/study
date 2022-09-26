using System;
using System.Globalization;

namespace POOExe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Student student = new Student();

            Console.Write("Nome do aluno: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            student.Note1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Note2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Note3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = "
            + student.Result().ToString("F2", CultureInfo.InvariantCulture));
            if (student.Aproved())
                Console.WriteLine("APROVADO");
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + student.RemainingNote().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }

        }
    }
}
