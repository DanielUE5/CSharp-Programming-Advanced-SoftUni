int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

for (int i = 0; i < n; i++)
{
    char[] data = Console.ReadLine().ToCharArray();
    

    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = data[j];
    }
}

char symbol = Console.ReadLine()[0];
bool found = false;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (matrix[i, j] == symbol)
        {
            Console.WriteLine($"({i}, {j})");
            found = true;
            break; 
        }
    }
    if (found)
    {
        break;
    }
}

if (!found)
{
    Console.WriteLine($"{symbol} does not occur in the matrix");
}
    
