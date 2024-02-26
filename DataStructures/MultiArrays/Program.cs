public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demonstrating 2D arrays with a matrix calculator...");

        // matrix dimensions come from user
        Console.Write("Enter the number of rows in matrix A: ");
        int rowsMatrixA = int.Parse(Console.ReadLine().Trim());

        Console.Write("Enter the number of columns in matrix A: ");
        int colsMatrixA = int.Parse(Console.ReadLine().Trim());

        Console.Write("Enter the number of rows in matrix B: ");
        int rowsMatrixB = int.Parse(Console.ReadLine().Trim());

        Console.Write("Enter the number of columns in matrix B: ");
        int colsMatrixB = int.Parse(Console.ReadLine().Trim());

        // is matrix multiplication possible?
        if(colsMatrixA != rowsMatrixB)
        {
            Console.WriteLine("Matrix multiplication is not possible with the given dimensions.");
            return;
        }

        Console.WriteLine($"\nMatrix A: {rowsMatrixA} rows and {colsMatrixA} columns");
        Console.WriteLine($"Matrix B: {rowsMatrixB} rows and {colsMatrixB} columns\n");

        // Initialize the two matrices
        int[,] matrixA = InitializeMatrix("A", rowsMatrixA, colsMatrixA);
        int[,] matrixB = InitializeMatrix("B", rowsMatrixB, colsMatrixB);

        // display the matrices
        Console.WriteLine("\nMatrix A:");
        PrintMatrix(matrixA);

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMatrix Addition (A+B):");
        int[,] sum = AddMatrices(matrixA, matrixB);
        PrintMatrix(sum);

        Console.WriteLine("\nMatrix Subtraction (A-B):");
        int[,] difference = SubtractMatrices(matrixA, matrixB);
        PrintMatrix(difference);

        Console.WriteLine("\nMatrix Multiplication (A*B):");
        int[,] product = MultiplyMatrices(matrixA, matrixB);
        PrintMatrix(product);
    }

    static int[,] InitializeMatrix(string matrixName, int rows, int cols)
    {
        Console.WriteLine($"\nEnter the values for Matrix {matrixName} ({rows}x{cols}):");
        int[,] matrix = new int[rows, cols];

        for(int row = 0; row < rows; row++)
        {
            for(int col = 0; col < cols; col++)
            {
                Console.Write($"Enter value for element ({row+1},{col+1}): ");
                matrix[row, col] = int.Parse(Console.ReadLine().Trim());
            }
        }

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row,col] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);

        int[,] sum = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                sum[row,col] = matrixA[row,col] + matrixB[row,col];
            }
        }
        return sum;
    }

    static int[,] SubtractMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);

        int[,] difference = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                difference[row, col] = matrixA[row, col] - matrixB[row, col];
            }
        }
        return difference;
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowsMatrixA = matrixA.GetLength(0);
        int colsMatrixA = matrixA.GetLength(1);
        int colsMatrixB = matrixB.GetLength(1);

        int[,] product = new int[rowsMatrixA, colsMatrixB];

        for (int rowA = 0; rowA < rowsMatrixA; rowA++)
        {
            for (int colB = 0; colB < colsMatrixB; colB++)
            {
                for(int colA = 0; colA < colsMatrixA; colA++)
                {
                    product[rowA, colB] += matrixA[rowA, colA] * matrixB[colA, colB];
                }

            }
        }
        return product;
    }
}