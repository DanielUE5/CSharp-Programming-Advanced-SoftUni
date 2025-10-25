public class MatrixShuffling
{
    public static void Main()
    {
        int[] dimensions = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        if (dimensions.Length != 2)
        {
            Console.WriteLine("Invalid input for dimensions!");
            return;
        }

        int rows = dimensions[0], cols = dimensions[1];

        string[][] matrix = new string[rows][];
        for (int i = 0; i < rows; i++)
        {
            matrix[i] = Console.ReadLine()
                .Split()
                .ToArray();
        }

        string command = Console.ReadLine();
        while (command != "END")
        {
            string[] data = command.Split();

            if (InterpretCommand(matrix, data))
            {
                PrintMatrix(matrix);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            command = Console.ReadLine();
        }
    }

    private static bool InterpretCommand(string[][] matrix, string[] command)
    {
        if (command.Length != 5 || command[0] != "swap") return false;

        int row1, col1, row2, col2;
        bool validRow1 = int.TryParse(command[1], out row1);
        bool validCol1 = int.TryParse(command[2], out col1);
        bool validRow2 = int.TryParse(command[3], out row2);
        bool validCol2 = int.TryParse(command[4], out col2);

        if (!validRow1 || !validCol1 || !validRow2 || !validCol2) return false;

        if (!IndicesAreValid(matrix, row1, col1) || !IndicesAreValid(matrix, row2, col2)) return false;

        string temp = matrix[row1][col1];
        matrix[row1][col1] = matrix[row2][col2];
        matrix[row2][col2] = temp;

        return true;
    }

    private static bool IndicesAreValid(string[][] matrix, int row, int col)
        => 0 <= row && row < matrix.Length && 0 <= col && col < matrix[row].Length;

    private static void PrintMatrix(string[][] matrix)
    {
        foreach (string[] row in matrix)
        {
            Console.WriteLine(string.Join(' ', row));
        }
    }
}
