using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBIS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("             Calculador de Monto con ITBIS               ");
            Console.WriteLine("");

            double precio = 0, cantidad = 0, ITBIS = 0.18, subtotal = 0, MontoITBIS = 0, total = 0;
            string producto = "";

            Console.WriteLine("Ingrese nombre del producto");
            producto = Console.ReadLine();
            Console.WriteLine("Ingrese el precio");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad");
            cantidad = double.Parse(Console.ReadLine());

            subtotal = precio * cantidad;
            MontoITBIS = subtotal * ITBIS;
            total = subtotal + MontoITBIS;

            Console.WriteLine("");
            Console.WriteLine("         FACTURA         ");
            Console.WriteLine("");
            Console.WriteLine("Subtotal: {0}",subtotal);
            Console.WriteLine("ITBIS: {0}", MontoITBIS);
            Console.WriteLine("Total: {0}", total);

            Console.ReadKey();
        }
    }
}
