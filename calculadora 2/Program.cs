using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque um numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coloque outro numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();

        }
    }
}
