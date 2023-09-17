using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp40
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese dos números: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int producto = 0;
            for (int i = 1; i <= num2; i++) 
            {
                producto = producto + num1;
            }
            Console.WriteLine("El producto es: "+ producto);
            Console.ReadKey();
        }
    }
}
