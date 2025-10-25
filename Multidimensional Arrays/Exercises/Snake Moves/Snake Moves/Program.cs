int[] dimensions = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

string snake = Console.ReadLine();

int rows = dimensions[0], cols = dimensions[1];

char[,] matrix = new char[rows, cols];

int index = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        int col;
        if (i % 2 == 0)
        {
            col = j;
        }
        else
        {
            col = cols - (j + 1);
        }

        matrix[i, col] = snake[index++ % snake.Length];
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}
