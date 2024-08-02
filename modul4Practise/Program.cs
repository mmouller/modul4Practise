using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задать, заполнить и вывести мастрицу заданного размера
            //после вывести сумму всех элементов матрицы

            Console.Write("Введите количество строк в матрице: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в матрице: ");
            int cols = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(10);
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int sum = MatrixSum(matrix);

            Console.WriteLine($"Сумма всех элементов матрицы: {sum}");
        }
        static int MatrixSum(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; ++i)
            {
                for ( int j = 0; j < cols; ++j )
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }
    }
}
