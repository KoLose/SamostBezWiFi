using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите число массива в индексе " + i + ": ");
                int input = Convert.ToInt32(Console.ReadLine());
                array[i] = input;
                sum += input;
            }
            Console.WriteLine("Сумма: " + sum);
            Console.ReadKey();
        }
    }
}
