using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }
            if (input % 5 == 0)
            {
                Console.WriteLine("Число делится на 5 без остатка");
            }
            else
            {
                Console.WriteLine("Число не делится на 5 без остатка");
            }
            Console.ReadKey();
        }
    }
}
