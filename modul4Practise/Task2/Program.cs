using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введиите количество строк: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбов: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix1 = GenRandomMatrix(rows, cols);

            int[,] matrix2 = GenRandomMatrix(rows, cols);

            Console.WriteLine("Первая матрица: ");
            PrintMatrix(matrix1);
           
            Console.WriteLine("Вторая матрица: ");
            PrintMatrix(matrix2);
          
            int[,] finalMatrix = SumOfMatrices(matrix1 , matrix2);
      
            Console.WriteLine("Финальная матрица: ");
            PrintMatrix(finalMatrix);
           
        }

        static int[,] GenRandomMatrix(int rows, int cols)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(10);
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }

        static int[,] SumOfMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] finalMatrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;j < cols; j++)
                {
                    finalMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return finalMatrix;
        }
    }
}
