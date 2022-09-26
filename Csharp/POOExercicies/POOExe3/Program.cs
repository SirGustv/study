using System;
using System.Globalization;

namespace POOExe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Entre a largura e a altura do retãngulo:");
            rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + rectangle.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + rectangle.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + rectangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
