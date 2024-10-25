using System;

class Program
{
    static void Main()
    {
        Console.Write("tedad satr matris aval: ");
        int rowsA = int.Parse(Console.ReadLine());
        Console.Write("tedat soton matris aval va satr matris dovom: ");
        int colsA = int.Parse(Console.ReadLine());

        Console.Write("tedad soton matris dovom: ");
        int colsB = int.Parse(Console.ReadLine());

        int[,] matrixA = new int[rowsA, colsA];
        int[,] matrixB = new int[colsA, colsB];
        int[,] result = new int[rowsA, colsB];

        Console.WriteLine("anasor matris aval: ");
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsA; j++)
            {
                Console.Write($"A[{i},{j}]: ");
                matrixA[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("anasor matris dovom: ");
        for (int i = 0; i < colsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                Console.Write($"B[{i},{j}]: ");
                matrixB[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < colsA; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        Console.WriteLine("hasel zarb matris: ");
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                Console.Write($"{result[i, j],4} ");
            }
            Console.WriteLine();
        }
    }
}
