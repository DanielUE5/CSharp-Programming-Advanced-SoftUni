public class Program
{
    const int M = 3, N = 3;

    public static void Main()
    {
        int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int rows = dimensions[0], cols = dimensions[1];

        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            int[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = data[j];
            }
        }

        int maxSum = int.MinValue, maxOriginRow = -1, maxOriginCol = -1;

        for (int i = 0; i <= rows - M; i++)
        {
            for (int j = 0; j <= cols - N; j++)
            { 

                int currentSum = SumSubMatrix(matrix, i, j);
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxOriginRow = i;
                    maxOriginCol = j;
                }
            }
        }
        Console.WriteLine($"Sum = {maxSum}");
        PrintSubMatrix(matrix, maxOriginRow, maxOriginCol);
    }

    private static int SumSubMatrix(int[,] matrix, int row, int col)
    {
        int sum = 0;
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++) 
                sum += matrix[row + i, col + j];
        }
        return sum;
    }

    private static void PrintSubMatrix(int[,] matrix, int row, int col)
    {
        for(int i = 0;i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (j > 0) Console.Write(' ');
                Console.Write(matrix[row + i, col + j]);
            }
            Console.WriteLine();
        }
    }
}