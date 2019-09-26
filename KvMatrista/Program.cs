using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvMatrista
{
    class Program
    {
        static void Main()
        {
            var matr = new int[8, 8];
            var k =1;
            Console.WriteLine("Сортированный массив");
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(0); j++)
                {
                    matr[i, matr.GetLength(0) - j - 1 + (2 * j + 1 - matr.GetLength(0)) * (i % 2)] = k++;
                }
            }
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(0); j++)
                    Console.Write(matr[j, i] + "\t");
                Console.WriteLine();
            }
        }
    }
}