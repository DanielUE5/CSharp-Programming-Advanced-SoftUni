internal class AverageGrades
{
    public static void Main(string[] args)
    {
        int studentsCount = int.Parse(Console.ReadLine());
        Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

        for (int i = 0; i < studentsCount; i++)
        {
            string[] input = Console.ReadLine().Split();
            string studentName = input[0];
            decimal grade = decimal.Parse(input[1]);

            if (!students.ContainsKey(studentName))
            {
                students.Add(studentName, new List<decimal>());
            }
            students[studentName].Add(grade);
        }

        foreach (var (student, grades) in students)
        {
            string[] mappedGrades = grades.Select(grade => $"{grade:f2}").ToArray();

            Console.WriteLine($"{student} -> {string.Join(" ", mappedGrades)} (avg: {grades.Average():F2})");
        }
    }
}
