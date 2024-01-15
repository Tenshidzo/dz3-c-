using System;

class Program
{
    static void Main()
    {
        //task 1
        int[,] matrix = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        Console.WriteLine("Matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // task 2
        int sum = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                sum += matrix[i, j];
            }
        }
        Console.WriteLine($"\nSum of elements in matrix: {sum}");

        // task3
        int[,] transposedMatrix = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }
        Console.WriteLine("\nReversed matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(transposedMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}