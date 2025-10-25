int squareMatrix = int.Parse(Console.ReadLine());

int[,] matrix = new int[squareMatrix, squareMatrix];

for (int i = 0; i < squareMatrix; i++)
{
    int[] data = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

    for (int j = 0; j < squareMatrix; j++)
    {
        matrix[i, j] = data[j];
    }
}

int sum1 = 0;
int sum2 = 0;

for (int i = 0; i < squareMatrix; i++)
{
    sum1 += matrix[i, i];
    sum2 += matrix[i, squareMatrix - i - 1];
}


Console.WriteLine(Math.Abs(sum1-sum2));