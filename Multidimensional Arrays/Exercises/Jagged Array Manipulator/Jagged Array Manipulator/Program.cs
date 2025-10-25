internal class Program
{
    public static void Main()
    {
        int rowsCount = int.Parse(Console.ReadLine());

        int[][] matrix = new int[rowsCount][];

        for (int row = 0; row < matrix.Length; row++)
        {
            matrix[row] = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray(); 
        }

        AnalyzeMatrix(matrix);

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] tokens = command.Split();
            string operation = tokens[0];
            int row = int.Parse(tokens[1]);
            int col = int.Parse(tokens[2]);
            int value = int.Parse(tokens[3]);

            if (IsValidIndex(matrix, row, col))
            {
                if (operation == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (operation == "Subtract")
                {
                    matrix[row][col] -= value;
                }
            }
        }

        PrintMatrix(matrix);
    }

    static void AnalyzeMatrix(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length - 1; i++)
        {
            if (matrix[i].Length == matrix[i + 1].Length)
            {
                MultiplyRowBy(matrix[i], 2);
                MultiplyRowBy(matrix[i + 1], 2);
            }
            else
            {
                DivideRowBy(matrix[i], 2);
                DivideRowBy(matrix[i + 1], 2);
            }
        }
    }
    static void MultiplyRowBy(int[] row, int factor)
    {
        for (int i = 0; i < row.Length; i++)
        {
            row[i] *= factor;
        }
    }

    static void DivideRowBy(int[] row, int divisor)
    {
        for (int i = 0; i < row.Length; i++)
        {
            row[i] /= divisor;
        }
    }

    static bool IsValidIndex(int[][] matrix, int row, int column)
    {
        return row >= 0 && row < matrix.Length && column >= 0 && column < matrix[row].Length;
    }

    static void PrintMatrix(int[][] matrix)
    {
        foreach (var row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}
