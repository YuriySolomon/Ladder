using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            int num = 3;
            Console.Write("Введите количество от 1 до 10: ");
            int s = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[s];
            Console.WriteLine();
            Console.WriteLine("***");
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 1; j < num; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
                for (int j = 1; j < num; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("***");
                num += 2;
            }
        }
    }
}
