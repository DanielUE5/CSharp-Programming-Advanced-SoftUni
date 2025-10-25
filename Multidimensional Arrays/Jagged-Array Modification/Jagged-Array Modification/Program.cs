int rows = int.Parse(Console.ReadLine());

int[][] matrix = new int[rows][];
for (int i = 0; i < rows; i++)
{
    matrix[i] = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
}
string command = Console.ReadLine();

while (command != "END")
{

    string[] data = command.Split();
    string operation = data[0];
    int row = int.Parse(data[1]), 
        col = int.Parse(data[2]), 
        val = int.Parse(data[3]);

    if (row < 0 || row > matrix.Length || col < 0 || col >= matrix[row].Length)
        Console.WriteLine("Invalid coordinates");
    else if (operation == "Add")
        matrix[row][col] += val;
    else if (operation == "Subtract")
        matrix[row][col] -= val;

    command = Console.ReadLine();

}

foreach (int[] row in matrix)
    Console.WriteLine(string.Join(' ', row));
